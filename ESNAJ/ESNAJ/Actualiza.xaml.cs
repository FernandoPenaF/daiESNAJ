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
        public Actualiza()
        {
            InitializeComponent();
        }

        private void btRegresa_Click(object sender, RoutedEventArgs e)
        {
            Menu w = new Menu();
            this.Hide();
            w.Show();

        }

        private void btActualiza_Click(object sender, RoutedEventArgs e)
        {
            int escuela=0;
            SqlConnection cnn = Conexion.agregarConexion();
            String query = "SELECT * from escuela";
            SqlCommand cmd = new SqlCommand(query, cnn);
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

            Torneo to= new Torneo(int.Parse(cbID.Text),tbNombre.Text,dpFecha.Text,escuela);
            if ((bool)cboxNombre.IsChecked)
            {
                int var = TorneoG.cambiaNombre(to);
                if(var>0)
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

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            Conexion c = new Conexion();
            c.llenarComboTorneo(cbID);
            c.llenarComboSede(cbSede);
        }
    }
}
