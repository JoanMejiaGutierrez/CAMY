using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RecorridoMatriz
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("Persist Security Info=False;Integrated Security=true;Initial Catalog = automatas; Server = DESKTOP-L77M9B0");
            cn.Open();
            return cn;
        }
    }
}
