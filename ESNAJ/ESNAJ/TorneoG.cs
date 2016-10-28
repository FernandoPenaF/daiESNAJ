using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESNAJ
{
    class TorneoG
    {
        public static int cambiaFecha(Torneo t)
        {
            SqlConnection con = Conexion.conectar();
            String query = "UPDATE torneo SET fecha='" + t.fecha + "' WHERE idTorneo=" + t.ID;
            SqlCommand cmm = new SqlCommand(query, con);
            int var = cmm.ExecuteNonQuery();
            return var;
        }

        public static int cambiaNombre(Torneo t)
        {
            SqlConnection con = Conexion.conectar();
            String query = "UPDATE torneo SET nombre='" + t.nombre + "' WHERE idTorneo=" + t.ID;
            SqlCommand cmm = new SqlCommand(query, con);
            int var = cmm.ExecuteNonQuery();
            return var;
        }

        public static int cambiaSede(Torneo t)
        {
            SqlConnection con = Conexion.conectar();
            String query = "UPDATE torneo SET idEscuela='" + t.idEscuela + "' WHERE idTorneo=" + t.ID;
            SqlCommand cmm = new SqlCommand(query, con);
            int var = cmm.ExecuteNonQuery();
            return var;
        }
    }
}
