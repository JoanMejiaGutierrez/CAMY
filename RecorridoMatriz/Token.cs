using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecorridoMatriz
{
    class Token
    {
        private string _strNombreTOKEN;

        public string NombreTOKEN
        {
            get { return _strNombreTOKEN; }
            set { _strNombreTOKEN = value; }
        }

        private int _intNumLinea;

        public int NumLinea
        {
            get { return _intNumLinea; }
            set { _intNumLinea = value; }
        }

    }
}
