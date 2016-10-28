using System;
using System.Collections.Generic;
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
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow ventana = new MainWindow();
            ventana.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            nuevoJug ventana = new nuevoJug(this);
            ventana.Show();
            this.Visibility = System.Windows.Visibility.Hidden;
        }

        private void btNuevoMaestro_Click(object sender, RoutedEventArgs e)
        {
            nuevoMaestro nvo = new nuevoMaestro(this);
            nvo.Show();
            this.Visibility = System.Windows.Visibility.Hidden;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            List<Escuela> l = Excel.getEscuelas("escuela");
            List<Jugador> j = Excel.infoActualizar("pachon");
            List<Jugador> ju = Excel.altaInicial("Puntos CXVIII");
            MessageBox.Show("Info leida");

            for (int i = 0; i < j.Count; i++)
            {
                ManejadorAlumnoN.actualizaBase(j[i]);
            }
            MessageBox.Show("Actualizacion terminada");
        }

        private void btactualizarTor_Click(object sender, RoutedEventArgs e)
        {
            Actualiza a = new Actualiza(this);
            a.Show();
            this.Visibility = System.Windows.Visibility.Hidden;
        }

        private void btTorneos_Click(object sender, RoutedEventArgs e)
        {
            Torneos t = new Torneos(this);
            t.Show();
            this.Visibility = System.Windows.Visibility.Hidden;
        }

        private void btCargarDatos_Click(object sender, RoutedEventArgs e)
        {
            ActualizaBase ab = new ActualizaBase();
            ab.Show();
            Close();
        }

        private void btWeb_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost:54480/ESNAJ(WEB)/index.aspx");
        }

    }
}
