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

        public static bool actualizaBase(Jugador j)
        {
            bool resp = false;
            SqlConnection con = Conexion.conectar();
            if (j.id == 0)
            {
                int nvoId = nuevoId();
                MessageBox.Show("ID " + nvoId);
                if(nvoId != -1){
                    j.id = nvoId;
                    ManejadorAlumnoN.alta(j); 
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
            con.Close();
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
                if (lector.IsDBNull(1))
                {
                    nuevoId = 1;
                }
                else
                {
                    lector.Read();
                    nuevoId = lector.GetInt32(0) + 1;
                }
            }
            lector.Close();
            con.Close();
            return nuevoId;
        }
    }
}
