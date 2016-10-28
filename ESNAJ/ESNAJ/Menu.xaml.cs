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
            List<Jugador> l = Excel.infoActualizar("pachon");
            for (int i = 0; i < l.Count; i++)
            {
                ManejadorAlumnoN.actualizaBase(l[i]);
            }
            MessageBox.Show("Actualizacion terminada");
        }

    }
}
