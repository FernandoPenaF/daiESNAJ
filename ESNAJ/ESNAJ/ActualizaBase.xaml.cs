using Microsoft.Win32;
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
    /// Lógica de interacción para ActualizaBase.xaml
    /// </summary>
    public partial class ActualizaBase : Window
    {
        public ActualizaBase()
        {
            InitializeComponent();
        }

        private void getPath(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Excel files (*.xls)|*.xls";
            if (openFileDialog1.ShowDialog() == true)
            {
                tbCat1.Text = openFileDialog1.FileNames[0].ToString();
            }

        }

        private void btActualiza_Click(object sender, RoutedEventArgs e)
        {
            
        }

    }
}
