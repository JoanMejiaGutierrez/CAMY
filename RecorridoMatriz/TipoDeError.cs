using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecorridoMatriz
{
    class TipoDeError
    {
        private int _intNumero;

        public int Numero
        {
            get { return _intNumero; }
            set { _intNumero = value; }
        }

        /*private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }*/

        private bool _blnActiva;

        public bool Activa
        {
            get { return _blnActiva; }
            set { _blnActiva = value; }
        }

    }
}
