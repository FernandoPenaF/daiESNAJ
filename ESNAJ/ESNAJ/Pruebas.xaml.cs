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
    /// Lógica de interacción para Pruebas.xaml
    /// </summary>
    public partial class Pruebas : Window
    {
        public Pruebas()
        {
            InitializeComponent();
        }

        private void btCarga_Click(object sender, RoutedEventArgs e)
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
