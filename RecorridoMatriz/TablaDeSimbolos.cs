using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecorridoMatriz
{
    class TablaDeSimbolos
    {
        private int _intNumIdentificador;

        public int NumIdentificador
        {
            get { return _intNumIdentificador; }
            set { _intNumIdentificador = value; }
        }

        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private string _strTipoDeDato;

        public string TipoDeDato
        {
            get { return _strTipoDeDato; }
            set { _strTipoDeDato = value; }
        }

        private string _strValor;

        public string Valor
        {
            get { return _strValor; }
            set { _strValor = value; }
        }
    }
}
