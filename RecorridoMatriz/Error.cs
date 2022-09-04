using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecorridoMatriz
{
    class Error
    {
        private int _intNLinea;

        public int NLinea
        {
            get { return _intNLinea; }
            set { _intNLinea = value; }
        }

        private string _strNombreDeError;

        public string NombreDeError
        {
            get { return _strNombreDeError; }
            set { _strNombreDeError = value; }
        }
    }
}
