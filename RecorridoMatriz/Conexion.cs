using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace RecorridoMatriz
{

    class Conexion
    {

        public SqlConnection cn = new SqlConnection();


        public Conexion()
        {
            cn.ConnectionString = "Persist Security Info=False;Integrated Security=true;Initial Catalog = automatas; Server = DESKTOP-L77M9B0";
        }
        public void Conectar()
        {
            try
            {
                cn.Open();
                //MessageBox.Show("Conectado a SqlSever2014");
            }
            catch (Exception x)
            {
                x.ToString();
            }
        }   

        public void Cerrar()
        {
            cn.Close();
        }


        

        public int cantidadEstados()
        {
            this.Conectar();
            string consulta = "SELECT COuNt(*) as cantidad FROM MT";
            SqlCommand cmd = new SqlCommand(consulta);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                return int.Parse(dr["cantidad"].ToString());
            }
            dr.Close();
            this.Cerrar();
            return 0;
        }


        public string ObtenerCelda(string EstadoAct, string Simbolo)
        {
            try
            {
                Conexion conn = new Conexion();
                this.Conectar();
                SqlCommand CMD = new SqlCommand("select [" + Simbolo + "] from Matriz where ESTADO = " + EstadoAct);
                SqlDataReader dr = CMD.ExecuteReader();
                while (dr.Read())
                {
                    return dr[Simbolo].ToString();
                }
                dr.Close();
                return "No se encontro ningun resultado";
            }
            catch (Exception ex)
            {
                return "exepcion";
            }
            finally
            {
                this.Cerrar();
            }
        }



        public static List<string> listaCampos = new List<string>();
        public void listaCamposBD()
        {
            this.Conectar();
            string consulta = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'MT' ORDER BY ORDINAL_POSITION";
            SqlCommand cmd = new SqlCommand(consulta);
            cmd.Connection = this.cn;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listaCampos.Add(dr["COLUMN_NAME"].ToString());
            }
            dr.Close();
            this.Cerrar();
        }




        public static List<string> listaEstados = new List<string>();
        public void listaEstadosBD()
        {
            this.Conectar();
            string consulta = "SELECT estado FROM MT";
            SqlCommand cmd = new SqlCommand(consulta);
            cmd.Connection = this.cn;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listaEstados.Add(dr["estado"].ToString());
            }
            dr.Close();
            this.Cerrar();
        }




        public string[,] cargarMatriz()
        {
            int cantidadDeEstados = listaEstados.Count;
            int cantidadDeCampos = listaCampos.Count;
            string[,] miMatriz = new string[cantidadDeEstados, cantidadDeCampos];
            int indiceEstado = 0;
            foreach (string miEstado in listaEstados)
            {
                int indiceCampo = 0;
                foreach (string miCampo in listaCampos)
                {
                    string campo = miCampo;
                    if (miCampo != "]")
                        campo = "[" + miCampo + "]";
                    else
                        campo = "[]]]";


                    this.Conectar();
                    string consulta = "SELECT " + campo + " FROM MT WHERE estado ='" + (miEstado) + "'";
                    SqlCommand cmd = new SqlCommand(consulta);
                    cmd.Connection = this.cn;
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        miMatriz[indiceEstado, indiceCampo] = dr[miCampo].ToString();
                        indiceCampo++;
                    }
                    dr.Close();
                    cmd.Connection.Close();
                    this.Cerrar();
                    // indiceCampo++;
                }

                indiceEstado++;
            }

            return miMatriz;
        }

    }
}
