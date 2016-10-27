using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESNAJ
{
    class ManejadorAlumnoN
    {
        public static bool alta(Jugador j)
        {
            bool resp = false;
            SqlConnection con = Conexion.conectar();
            SqlCommand cmd = new SqlCommand(String.Format("INSERT INTO alumno(idAlumno, nombre, correo, contra, puntosTotales, categoria, idEscuela) VALUES ('{0}','{1}', '{2}', '{3}', '{4}' ,'{5}', '{6}')", j.id, j.nombre, j.correo, j.contra, j.puntos, j.categoria, j.escuela), con);
            if (cmd.ExecuteNonQuery() > 0)
                resp = true;
            con.Close();
            return resp;
        }

        public static bool altaEscuela(Escuela e)
        {
            bool resp = false;
            SqlConnection con = Conexion.conectar();
            SqlCommand cmd = new SqlCommand(String.Format("INSERT INTO escuela(idEscuela, nombre) VALUES ('{0}','{1}')", e.id, e.nombre), con);
            if (cmd.ExecuteNonQuery() > 0)
                resp = true;
            con.Close();
            return resp;
        }
    }
}
