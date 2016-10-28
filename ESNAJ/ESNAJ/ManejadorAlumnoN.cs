using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ESNAJ
{
    class ManejadorAlumnoN
    {

        public static bool altaJugador(Jugador j)
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

        public static bool actualizaBase(Jugador j)
        {
            bool resp = false;
            SqlConnection con = Conexion.conectar();
            if (j.id == 0)
            {
                int nvoId = nuevoId();
                if(nvoId != -1){
                    j.id = nvoId;
                    j.contra = "default";
                    ManejadorAlumnoN.altaJugador(j); 
                }
            }
            else
            {
                double puntosActuales = 0;
                SqlCommand cmd = new SqlCommand(String.Format("SELECT a.puntosTotales FROM alumno a WHERE a.idAlumno = '{0}'", j.id), con);
                SqlDataReader lector = cmd.ExecuteReader();

                if (lector.HasRows)
                {
                    lector.Read();
                    puntosActuales = lector.GetDouble(0);
                    lector.Close();
                    cmd = new SqlCommand(String.Format("UPDATE alumno SET puntosTotales = '{0}' WHERE idAlumno = '{1}'", puntosActuales + j.puntos, j.id), con);
                    if (cmd.ExecuteNonQuery() > 0)
                        resp = true;
                }
            }
            actualizaParticipacion(j.categoria, j.posicion, j.puntos, j.id, j.torneo);
            con.Close();
            return resp;
        }

        public static bool actualizaParticipacion(String cat, int pos, double puntos, int idAl, int idTor)
        {
            bool resp = false;
            int id = nuevoIdPart();
            SqlConnection con = Conexion.conectar();
            SqlCommand cmd = new SqlCommand(String.Format("INSERT INTO participo(idParticipo, categoria, posicionFinal, puntajeObtenido, idAlumno, idTorneo) VALUES ('{0}','{1}', '{2}', '{3}', '{4}' ,'{5}')", id, cat, pos, puntos, idAl, idTor), con);
            if (cmd.ExecuteNonQuery() > 0)
                resp = true;
            return resp;
        }

        public static int nuevoId()
        {
            int nuevoId = -1;
            SqlConnection con = Conexion.conectar();
            SqlCommand cmd = new SqlCommand("SELECT MAX(a.idAlumno) FROM alumno a WHERE a.idAlumno < 20000", con);
            SqlDataReader lector = cmd.ExecuteReader();
            if (lector.HasRows)
            {
                lector.Read();
                if (lector.IsDBNull(0))
                {
                    nuevoId = 1;
                }
                else
                {
                    nuevoId = lector.GetInt32(0) + 1;
                }
            }
            lector.Close();
            con.Close();
            return nuevoId;
        }

        private static int nuevoIdPart()
        {
            int nuevoId = 1;
            SqlConnection con = Conexion.conectar();
            SqlCommand cmd = new SqlCommand("SELECT MAX(p.idParticipo) FROM participo p", con);
            SqlDataReader lector = cmd.ExecuteReader();
            lector.Read();
            if (!lector.IsDBNull(0))
                nuevoId = lector.GetInt32(0) + 1;
            lector.Close();
            con.Close();
            return nuevoId;
        }

    }
}
