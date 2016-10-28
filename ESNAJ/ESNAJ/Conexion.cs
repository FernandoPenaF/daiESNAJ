using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESNAJ
{
    class Conexion
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader lector;

        public static SqlConnection conectar()
        {
            SqlConnection nuevaCon = new SqlConnection("Data Source=112SALAS14;Initial Catalog=ESNAJ;User ID=sa;Password=sqladmin");
            nuevaCon.Open();
            return nuevaCon;
        }
    }
}
