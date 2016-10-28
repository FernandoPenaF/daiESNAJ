using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ESNAJ
{
    class Conexion
    {
        public static SqlConnection agregarConexion()
        {
            String conexion="";
            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            MessageBox.Show("Conectado");

            return con;
        }


        public void llenarComboTorneo(ComboBox cb)
        {
            try
            {
                SqlConnection con = Conexion.agregarConexion();
                String query = "SELECT idTorneo FROM torneo";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    cb.Items.Add(lector.GetString(0));
                }
                cb.SelectedIndex = 0;
                lector.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo hacer la lectura" + ex);
            }
        }

        public void llenarComboSede(ComboBox cb)
        {
            try
            {
                SqlConnection con = Conexion.agregarConexion();
                String query = "SELECT nombre FROM escuela";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    cb.Items.Add(lector.GetString(0));
                }
                cb.SelectedIndex = 0;
                lector.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo hacer la lectura" + ex);
            }
        }
    }
}
