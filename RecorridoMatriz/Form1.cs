using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;
using System.Diagnostics;
using System.Windows.Controls;

namespace RecorridoMatriz
{
    //aqui
    public partial class frmLenguaje : Form
    {
        //listas a utilizar
        List<Token> listaTokens = new List<Token>();
        List<Error> listaErrores = new List<Error>();
        List<TablaDeSimbolos> tablaDeSimbolos = new List<TablaDeSimbolos>();
        //List<TipoDeError> listaDeTiposDeErrores = new List<TipoDeError>();
        List<string> listaPalabrasErroneas = new List<string>();
 

        //datos auxiliares
                //variable para enumerar identificadores de tabla de simbolos
                int numIdentificador = 0;
                //variables a usar para control de estado
                int intEstadoActual = 0;
                int intEstadoSiguiente = 0;

                //arreglo para guardar los caracteres de cada linea
                char[] caracteresPorLinea;

                //cadena donde se guarda cada linea de codigo
                string strLineaDeCodigo;

                //variable para indicar linea de codigo
                int numLinea;

                //variable para guardar identificador
                string strIDEN = "";
                bool banderaIDEN = false;

                //variable para ir guardando cadenas
                string strPalabra = "";

                //contador para contador las comillas de CAD
                int contadorCAD=0;

        public frmLenguaje()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            rtxbSentencias.SelectionStart = rtxbSentencias.Text.Length - 4;
            dtgIden.ReadOnly = true;
            dtgIden.AllowUserToAddRows = false;
            dtgIden.AllowUserToDeleteRows = false;
            //dtgIden.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgTablaDeSimbolos.ReadOnly = true;
            dtgTablaDeSimbolos.AllowUserToAddRows = false;
            dtgTablaDeSimbolos.AllowUserToDeleteRows = false;
            dtgTablaDeSimbolos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //dtgIden.DataSource = LlenarDatos();
            Conexion conn = new Conexion();
            conn.Conectar();


            conn.listaCamposBD();
            conn.listaEstadosBD();
            string[,] m  = conn.cargarMatriz();



            //dtgIden.DataSource = new ArrayDataView(conn.cargarMatriz());

            //BindingSource CantonesBindingSource;
            //CantonesBindingSource = new BindingSource(conn.cargarMatriz(), null);
            //dtgIden.DataSource = CantonesBindingSource;
        }

 

        //metodo para añadir texto al richtextbox del token
        void AgregarAToken(string strNota)
        {
            if (rtxbTokens.Text == "")
            {
                rtxbTokens.Text = strNota;
            }
            else
            {
                rtxbTokens.Text = rtxbTokens.Text + "\n" + strNota;
            }
            rtxbTokens.SelectionStart = rtxbTokens.Text.Length;
            rtxbTokens.ScrollToCaret();
        }
        void AgregarALineaToken(string strNota)
        {
            if (rtxbLineasTokens.Text == "")
            {
                rtxbLineasTokens.Text = strNota;
            }
            else
            {
                rtxbLineasTokens.Text = rtxbLineasTokens.Text + "\n" + strNota;
            }
            rtxbLineasTokens.SelectionStart = rtxbLineasTokens.Text.Length;
            rtxbLineasTokens.ScrollToCaret();
        }

        void AgregarAErrores(string strNota, string strNumero)
        {
            //nombre de error
            if (rtxbNombreError.Text == "")
            {
                rtxbNombreError.Text = strNota;
            }
            else
            {
                rtxbNombreError.Text = rtxbNombreError.Text + "\n" + strNota;
            }
            rtxbNombreError.SelectionStart = rtxbNombreError.Text.Length;
            rtxbNombreError.ScrollToCaret();

            //num de linea
            if(rtxbNumError.Text == "")
            {
                rtxbNumError.Text = strNumero;
            }
            else
            {
                rtxbNumError.Text = rtxbNumError.Text + "\n" + strNumero;
            }
            rtxbNumError.SelectionStart = rtxbNumError.Text.Length;
            rtxbNumError.ScrollToCaret();
        }

        private void btnCargarPrograma_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();

            abrir.Filter = "Documento de texto| *.txt";
            abrir.Title = "Abrir sentencias";
            var resultado = abrir.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                StreamReader leer = new StreamReader(abrir.FileName);
                rtxbSentencias.Text = leer.ReadToEnd();
                leer.Close();
            }
        }

        void ActualizarTOKENS()
        {
            rtxbTokens.Clear();
            foreach(Token unToken in listaTokens)
            {
                AgregarAToken(unToken.NombreTOKEN);
            }

            rtxbLineasTokens.Clear();
            //actualiza los numeros de linea
            int n = rtxbTokens.Lines.Length;
            for(int i=1; i<=n; i++)
            {
                AgregarALineaToken(i.ToString());
            }
        }

        void ActualizarListaErrores()
        {
            rtxbNumError.Clear(); rtxbNombreError.Clear();
            foreach (Error unError in listaErrores)
            {
                AgregarAErrores(unError.NombreDeError, unError.NLinea.ToString());
            }
            lblNumErrores.Text = rtxbNumError.Lines.Length.ToString();
        }

        void ActualizarTablaDeSimbolos()
        {
            dtgTablaDeSimbolos.Rows.Clear();
            foreach(TablaDeSimbolos registro in tablaDeSimbolos)
            {
                dtgTablaDeSimbolos.Rows.Add(registro.NumIdentificador, registro.Nombre);
            }
        }

        //--Métodos que se usan en el análisis lexico--

        //metodo de lectura de cadena
        void LecturaDeCadena()
        {
            //empieza recorrido de lineas de codigo
            for (numLinea = 0; numLinea < rtxbSentencias.Lines.Length; numLinea++)
            {
                //brincar si es una linea vacia
                if (rtxbSentencias.Lines[numLinea] == "")
                {
                    continue;
                }

                //guardamos linea de codigo y le agregamos una "marca/blanco" para el FDC
                strLineaDeCodigo = rtxbSentencias.Lines[numLinea] + " ";

                //se guarda la cadena en el arreglo de caracteres
                caracteresPorLinea = strLineaDeCodigo.ToCharArray();

                //aseguramos reiniciar valores para recorrer matriz
                int intColumna = 0;
                intEstadoActual = 0; intEstadoSiguiente = 0;

                //empieza recorrido de caracteres de cada linea de codigo
                foreach (char c in caracteresPorLinea)
                {
                    intColumna = 0;
                    //recorrido de alfabeto
                    RecorrerMatriz(c, ref intColumna);
                }
            }
        }

        //Metodo para leer la matriz de la base de datos
        public DataTable LlenarDatos()
        {
            try
            {
                Conexion conn = new Conexion();
                conn.Conectar();
                DataTable dt = new DataTable();
                string consulta = "SELECT * FROM MT";
                SqlCommand cmd = new SqlCommand(consulta);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
            catch
            {
                return null;
            }
            
        }


        



       


        string[,] _matriz;
        void GenerarMatriz()
        {
            _matriz = new string[(dtgIden.Rows.Count), (dtgIden.Columns.Count)];
            foreach (DataGridViewRow row in dtgIden.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cel in row.Cells)
                    {
                        _matriz[cel.RowIndex, cel.ColumnIndex] = Convert.ToString(cel.Value);
                    }
                }
            }
        }


        //metodo de recorrido de matriz
        void RecorrerMatriz(char c, ref int intColumna)
        {
            //recorrido de alfabeto
            foreach (string simbolo in Conexion.listaCampos)
            {
                //si el caracter se encuentra en el alfabeto
                if (c.ToString() == simbolo)
                {
                    //verificamos si se trata de un IDEN
                    if (c.ToString() == "_")
                    {
                        //activa bool
                        banderaIDEN = true;
                    }
                    if (banderaIDEN)
                    {
                        //va guardando el nombre del IDEN
                        strIDEN = strIDEN + c.ToString();
                    }
                    //añadimos caracter para formar palabra
                    strPalabra = strPalabra + c.ToString();


                    //verificar si es una cadena
                    if(c.ToString() == "\"")
                    {
                        contadorCAD++;
                    }

                    //avanza al estado indicado en la celda
                    intEstadoSiguiente = int.Parse(_matriz[(intEstadoActual), intColumna]);
                    intEstadoActual = intEstadoSiguiente;
                    break;
                }

                //si es el caso de una cadena y encuentra espacio en blanco
                if( ( (contadorCAD == 1) && (simbolo == "Δ") && (c.ToString() == " ")))
                {
                    intEstadoSiguiente = int.Parse(_matriz[(intEstadoActual), intColumna]);
                    intEstadoActual = intEstadoSiguiente;
                    break;
                }

                //si llegamos a FDC
                if (c.ToString() == " " && simbolo == "FDC")
                {
                    //si es un blanco en el estado 0
                    if (intEstadoActual == 0)
                    {
                        strPalabra = "";
                        break;
                    }

                    //verificar si se trata de un error
                    if ((_matriz[intEstadoActual, intColumna]).Contains("ERROR"))
                    {
                        ElementosNoValidos(ref intColumna);
                    }
                    else
                    {
                        //continua normal
                        strPalabra = "";
                        intEstadoSiguiente = int.Parse(_matriz[(intEstadoActual), intColumna]);
                        intEstadoActual = intEstadoSiguiente;

                        intColumna++;
                    }

                    //estado de aceptacion


                    //Se procede a añadir a la lista de TOKENS

                    //declaramos un bool para indicar si es un token en nueva linea de codigo
                    bool bandera = true;

                    //verifica si es de la misma linea de codigo
                    int iteracion = 0;
                    foreach (Token token in listaTokens)
                    {
                        if (token.NumLinea == numLinea)
                        {
                            Token unToken1 = new Token();
                            unToken1.NombreTOKEN = _matriz[intEstadoActual, intColumna];
                            if(unToken1.NombreTOKEN.Contains("ERROR"))
                            {
                                string numeros = Regex.Match(unToken1.NombreTOKEN, @"\d+").Value;
                                if (numeros != "")
                                {
                                    unToken1.NombreTOKEN = unToken1.NombreTOKEN.Replace(numeros, string.Empty);
                                }
                            }
                            
                            //verificamos si se trata de un identificador
                            bool yaExiste = false;
                            if (unToken1.NombreTOKEN == "IDEN")
                            {
                                //buscamos en la tabla de simbolos si ya existe un IDEN con el mismo nombre
                                BusquedaEnLaTablaDeSimbolos(ref yaExiste);

                                //si ya existe IDEN...
                                if (yaExiste)
                                {
                                    //agregamos al archivo con TOKEN ya existente
                                    unToken1.NombreTOKEN = unToken1.NombreTOKEN + numIdentificador;
                                }
                                //sino, se enumera TOKEN y añadimos IDEN a tabla de simbolos
                                else
                                {
                                    int conteoIDEN = 0;
                                    //buscamos si ya existe algún IDEN para ENUMERARLO
                                    ConteoDeTablaDeSimbolos(ref conteoIDEN);
                                    /*if(conteoIDEN == 0)
                                    {
                                        conteoIDEN = 1;
                                    }*/
                                    conteoIDEN = conteoIDEN + 1;
                                    unToken1.NombreTOKEN = unToken1.NombreTOKEN + conteoIDEN;

                                    //añadimos a la tabla de simbolos
                                    TablaDeSimbolos unRegistro = new TablaDeSimbolos();
                                    unRegistro.Nombre = strIDEN;
                                    unRegistro.NumIdentificador = conteoIDEN;
                                    tablaDeSimbolos.Add(unRegistro);
                                }
                                //limpiamos variable que guarda nombre de IDEN
                                strIDEN = "";
                            }


                            //agrega a la linea de TOKEN que actualmente se encuentra
                            string tokenAnterior = listaTokens[iteracion].NombreTOKEN;
                            listaTokens[iteracion].NombreTOKEN = tokenAnterior + " " + unToken1.NombreTOKEN;
                            //volvemos a reiniciar estados
                            intEstadoActual = 0; intEstadoSiguiente = 0; contadorCAD = 0;
                            bandera = false; banderaIDEN = false;
                            break;
                        }
                        iteracion++;
                    }

                    //se ejecutara este codigo si el token se añade en nueva linea de codigo
                    if (bandera)
                    {
                        Token unToken = new Token();
                        unToken.NombreTOKEN = _matriz[intEstadoActual, intColumna];
                        if(unToken.NombreTOKEN.Contains("ERROR"))
                        {
                            string numeros = Regex.Match(unToken.NombreTOKEN, @"\d+").Value;
                            if (numeros != "")
                            {
                                unToken.NombreTOKEN = unToken.NombreTOKEN.Replace(numeros, string.Empty);
                            }
                        }

                        //verificamos si se trata de un identificador
                        bool yaExiste = false;
                        if (unToken.NombreTOKEN == "IDEN")
                        {
                            //buscamos en la tabla de simbolos si ya existe un IDEN con el mismo nombre
                            BusquedaEnLaTablaDeSimbolos(ref yaExiste);

                            //si ya existe IDEN...
                            if (yaExiste)
                            {
                                //agregamos al archivo con TOKEN ya existente
                                unToken.NombreTOKEN = unToken.NombreTOKEN + numIdentificador;
                            }
                            //sino, se enumera TOKEN y añadimos IDEN a tabla de simbolos
                            else
                            {
                                int conteoIDEN = 0;
                                //buscamos si ya existe algún IDEN para ENUMERARLO
                                ConteoDeTablaDeSimbolos(ref conteoIDEN);

                                conteoIDEN = conteoIDEN + 1;
                                unToken.NombreTOKEN = unToken.NombreTOKEN + conteoIDEN;

                                //añadimos a la tabla de simbolos
                                TablaDeSimbolos unRegistro = new TablaDeSimbolos();
                                unRegistro.Nombre = strIDEN;
                                unRegistro.NumIdentificador = conteoIDEN;
                                tablaDeSimbolos.Add(unRegistro);
                            }
                            //limpiamos variable que guarda nombre de IDEN
                            strIDEN = "";
                        }
                        unToken.NumLinea = numLinea;
                        listaTokens.Add(unToken);

                        /*MessageBox.Show(_matriz[intEstadoActual, intColumna]);
                        MessageBox.Show("Estado: " + intEstadoActual);*/

                        //volvemos a reiniciar estados
                        intEstadoActual = 0; intEstadoSiguiente = 0; contadorCAD = 0;
                        banderaIDEN = false;
                        break;
                    }
                }
                intColumna++;
            }
        }

        //metodo de busqueda en la tabla de simbolos y asignacion de nuevos valores
        void BusquedaEnLaTablaDeSimbolos(ref bool yaExiste)
        {
            foreach (TablaDeSimbolos tablaDeSimbolos in tablaDeSimbolos)
            {
                if (tablaDeSimbolos.Nombre == strIDEN)
                {
                    yaExiste = true;
                    numIdentificador = tablaDeSimbolos.NumIdentificador;
                }
            }
        }
        void ConteoDeTablaDeSimbolos(ref int conteoIDEN)
        {
            foreach (TablaDeSimbolos registros in tablaDeSimbolos)
            {
                if (registros == null)
                {
                    break;
                }
                conteoIDEN++;
            }
        }

        //metodo para recuperacion de errores
        void ElementosNoValidos(ref int intColumna)
        {
            Error unError = new Error();
            unError.NombreDeError = _matriz[intEstadoActual, intColumna];
            //para un caso especial...
            string extraerNumero = Regex.Match(unError.NombreDeError, @"\d+").Value;
            if (extraerNumero != "")
            {
                unError.NombreDeError = _matriz[int.Parse(extraerNumero), 83];
                unError.NLinea = numLinea + 1;
            }
            else
            {
                int intColumnaError = intColumna + 1;

                unError.NLinea = numLinea + 1;
                unError.NombreDeError = _matriz[intEstadoActual, intColumnaError];
            }
            //añade palabra erronea a la lista
            listaPalabrasErroneas.Add(strPalabra);
            listaErrores.Add(unError);
            ActualizarListaErrores();
            strPalabra = "";
            strIDEN = "";
        }
        void CambiarColor()
        {
            //camnbia color en el código
            foreach (string s in listaPalabrasErroneas)
            {
                //MessageBox.Show(s);
                Utility.CambiarColor(rtxbSentencias, s, Color.Red);
            }

            

            //cambiar color en los TOKENS
            Utility.CambiarColor(rtxbTokens, "ERROR", Color.Red);
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            //generar matriz
            GenerarMatriz();

            //limpiar listas
            listaTokens.Clear(); listaErrores.Clear(); tablaDeSimbolos.Clear(); listaPalabrasErroneas.Clear();
            

            banderaIDEN = false;

            //empieza recorrido de lineas de codigo
            LecturaDeCadena();
            
            //se actualiza rtxb para archivo token
            ActualizarTOKENS();

            //se actualiza tabla de simbolos
            ActualizarTablaDeSimbolos();

            //se actualiza la lista de errores
            ActualizarListaErrores();

            //cambiamos color de errores en codigo
            CambiarColor();
        }

        private void rtxbSentencias_Enter(object sender, EventArgs e)
        {
            
        }

        private void rtxbSentencias_TextChanged(object sender, EventArgs e)
        {
            rtxbSentencias.SelectionBackColor = Color.FromArgb(9, 17, 59);
            ActualizarLineasDeCodigo();
            //codigo para restablecer color normal de codigo
            string strTexto = rtxbSentencias.Text;
            foreach (string s1 in listaPalabrasErroneas)
            {
                strTexto.Replace(s1, string.Empty);
            }
            Utility.CambiarColor(rtxbSentencias, strTexto, Color.FromArgb(128, 255, 255));
            CambiarColor();
            rtxbSentencias.SelectionBackColor = Color.FromArgb(9, 17, 59);
        }

        private void ActualizarLineasDeCodigo()
        {
            string strCodigo = rtxbSentencias.Text;
            int ic = 2;
            rtxbLineasCodigo.Text = "1";
            foreach (var c in strCodigo)
            {
                if ((int)c == 10)
                {
                    rtxbLineasCodigo.Text += "\n" + ic;
                    ic++;
                    rtxbLineasCodigo.SelectionStart = rtxbLineasCodigo.TextLength;
                    rtxbLineasCodigo.ScrollToCaret();
                }
            }
        }
        private void btnEditarPrograma_Click(object sender, EventArgs e)
        {

        }

        private void rtxbLineasCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtxbSentencias_Click(object sender, EventArgs e)
        {
            rtxbSentencias.SelectionColor = Color.FromArgb(128, 255, 255);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rtxbSentencias.Text != "")
            {
                DialogResult res = MessageBox.Show("Desea Guardar el Archivo actual", "Aviso", MessageBoxButtons.YesNoCancel);

                if (res == DialogResult.Yes)
                {
                    SaveFileDialog guardar = new SaveFileDialog();

                    guardar.Filter = "Documento de texto| *.txt";
                    guardar.Title = "Guardar sentencias";
                    guardar.FileName = "Sin titulo 1";
                    var resultado = guardar.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        StreamWriter escribir = new StreamWriter(guardar.FileName);
                        foreach (object line in rtxbSentencias.Lines)
                        {
                            escribir.WriteLine(line);
                        }
                        escribir.Close();

                        rtxbTokens.Text = "";
                        rtxbNombreError.Clear();

                        rtxbSentencias.Text = "";
                    }
                }
                else if (res == DialogResult.No)
                {
                    rtxbSentencias.Text = "";
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void frmLenguaje_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        

        private void RbtnGuardarPrograma_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();

            guardar.Filter = "Documento de texto| *.txt";
            guardar.Title = "Guardar sentencias";
            guardar.FileName = "Archivo de matriz";
            var resultado = guardar.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                StreamWriter escribir = new StreamWriter(guardar.FileName);
                foreach (object line in rtxbSentencias.Lines)
                {
                    escribir.WriteLine(line);
                }
                escribir.Close();

                //rtxbTokens.Text = "";
                //listBoxErrores.Items.Clear();
                //listBoxTablasimbolos.Items.Clear(); //Ni tenemos esto todavia
            }
        }

        private void RbtnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();

            abrir.Filter = "Documento de texto| *.txt";
            abrir.Title = "Abrir sentencias";
            var resultado = abrir.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                StreamReader leer = new StreamReader(abrir.FileName);
                rtxbSentencias.Text = leer.ReadToEnd();
                leer.Close();
            }
        }

        private void RbtnNuevo_Click(object sender, EventArgs e)
        {
            if (rtxbSentencias.Text != "")
            {
                DialogResult res = MessageBox.Show("Desea Guardar el Archivo actual", "Aviso", MessageBoxButtons.YesNoCancel);

                if (res == DialogResult.Yes)
                {
                    SaveFileDialog guardar = new SaveFileDialog();

                    guardar.Filter = "Documento de texto| *.txt";
                    guardar.Title = "Guardar sentencias";
                    guardar.FileName = "Sin titulo 1";
                    var resultado = guardar.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        StreamWriter escribir = new StreamWriter(guardar.FileName);
                        foreach (object line in rtxbSentencias.Lines)
                        {
                            escribir.WriteLine(line);
                        }
                        escribir.Close();

                        rtxbTokens.Text = "";
                        rtxbNombreError.Clear();

                        rtxbSentencias.Text = "";
                    }
                }
                else if (res == DialogResult.No)
                {
                    rtxbSentencias.Text = "INICIO\n\nFIN";
                }
            }
        }

        private void RbtnGuardarArchivo_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();

            guardar.Filter = "Documento de texto| *.txt";
            guardar.Title = "Guardar sentencias";
            guardar.FileName = "Tokens";
            var resultado = guardar.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                StreamWriter escribir = new StreamWriter(guardar.FileName);
                foreach (object line in rtxbTokens.Lines)
                {
                    escribir.WriteLine(line);
                }
                escribir.Close();

                //rtxbTokens.Text = "";
                //listBoxErrores.Items.Clear();
                //lsbTablasimbolos.Items.Clear(); //No tenemos esto todavia 
            }
        }

        public static string stringBetween(string Source, string Start, string End)
        {
            string result = "";
            if (Source.Contains(Start) && Source.Contains(End))
            {
                int StartIndex = Source.IndexOf(Start, 0) + Start.Length;
                int EndIndex = Source.IndexOf(End, StartIndex);
                result = Source.Substring(StartIndex, EndIndex - StartIndex);
                return result;
            }

            return result;
        }

        //para medir los tiempos de ejecucion
        Stopwatch timeMeasure = new Stopwatch();
        Stopwatch timeMeasure2 = new Stopwatch();
        Stopwatch timeMeasure3 = new Stopwatch();
        private void rbtnEjecutar_Click(object sender, EventArgs e)
        {
            timeMeasure.Start();
            //generar matriz
            GenerarMatriz();
            timeMeasure.Stop();
            //MessageBox.Show($"Tiempo de ejecución de generación de matriz: {timeMeasure.Elapsed.TotalMilliseconds} ms");

            //limpiar listas
            listaTokens.Clear(); listaErrores.Clear(); tablaDeSimbolos.Clear(); listaPalabrasErroneas.Clear();


            banderaIDEN = false;

            //empieza recorrido de lineas de codigo
            timeMeasure2.Start();
            LecturaDeCadena();
            timeMeasure2.Stop();
            //MessageBox.Show($"Tiempo de ejecución de lectura de cadena y recorrido de matriz: {timeMeasure.Elapsed.TotalMilliseconds} ms");

            //se actualiza rtxb para archivo token
            ActualizarTOKENS();

            //se actualiza tabla de simbolos
            ActualizarTablaDeSimbolos();

            //se actualiza la lista de errores
            ActualizarListaErrores();

            //cambiamos color de errores en codigo
            timeMeasure3.Start();
            CambiarColor();
            timeMeasure3.Stop();
            //MessageBox.Show($"Tiempo de ejecución de cambio de color: {timeMeasure.Elapsed.TotalMilliseconds} ms");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
