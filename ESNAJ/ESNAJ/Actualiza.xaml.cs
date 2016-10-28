using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ESNAJ
{
    /// <summary>
    /// Lógica de interacción para Actualiza.xaml
    /// </summary>
    public partial class Actualiza : Window
    {
        SqlConnection cnn;
        SqlCommand cmd;

        public Actualiza()
        {
            InitializeComponent();

            //LENADO DE COMBOBOX TORNEOS
            try
            {
                SqlConnection con = Conexion.conectar();
                String query = "SELECT idTorneo FROM torneo";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    cbID.Items.Add(lector.GetInt32(0));
                }
                cbID.SelectedIndex = 0;
                lector.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo hacer la lectura" + ex);
            }

            //LLENADO DE COMBOBOX SEDES
            try
            {
                SqlConnection con = Conexion.conectar();
                String query = "SELECT nombre FROM escuela";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    cbSede.Items.Add(lector.GetString(0));
                }
                cbSede.SelectedIndex = 0;
                lector.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo hacer la lectura" + ex);
            }
        }
        

        private void btRegresa_Click(object sender, RoutedEventArgs e)
        {
            Menu m = new Menu();
            Close();
        }

        private void btActualiza_Click(object sender, RoutedEventArgs e)
        {
            int escuela = 0;
            cnn = Conexion.conectar();
            String query = "SELECT * from escuela";
            cmd = new SqlCommand(query, cnn);
            SqlDataReader lector = cmd.ExecuteReader();
            Boolean status = false;
            while (!status && lector.Read())
            {
                if (lector.GetString(1) == cbSede.Text)
                {
                    status = true;
                    escuela = lector.GetInt32(0);
                }
            }
            lector.Close();

            Torneo to = new Torneo(int.Parse(cbID.Text), tbNombre.Text, dpFecha.Text, escuela);
            if ((bool)cboxNombre.IsChecked)
            {
                int var = TorneoG.cambiaNombre(to);
                if (var > 0)
                    MessageBox.Show("Cambio exitoso");
                else
                    MessageBox.Show("Error");
            }
            if ((bool)cboxSede.IsChecked)
            {
                int var = TorneoG.cambiaSede(to);
                if (var > 0)
                    MessageBox.Show("Cambio exitoso");
                else
                    MessageBox.Show("Error");
            }
            if ((bool)cboxFecha.IsChecked)
            {
                int var = TorneoG.cambiaFecha(to);
                if (var > 0)
                    MessageBox.Show("Cambio exitoso");
                else
                    MessageBox.Show("Error");
            }

            if (!(bool)cboxFecha.IsChecked && !(bool)cboxSede.IsChecked && !(bool)cboxNombre.IsChecked)
            {
                MessageBox.Show("No ha seleccionado que datos va a cambiar");
            }

        }
    }
}
