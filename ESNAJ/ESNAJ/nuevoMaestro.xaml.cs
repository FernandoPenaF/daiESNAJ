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
    /// Lógica de interacción para nuevoMaestro.xaml
    /// </summary>
    public partial class nuevoMaestro : Window
    {

        SqlConnection con;
        SqlCommand cmm;

        Menu ventanaAnt;

        public nuevoMaestro(Menu ventMenu)
        {
            ventanaAnt = ventMenu;
            InitializeComponent();
        }

        private void btcancela_Click(object sender, RoutedEventArgs e)
        {
            ventanaAnt.Show();
            this.Close();
        }

        private void btagrega_Click(object sender, RoutedEventArgs e)
        {
            con = MainWindow.conectarBase();
            String query = "INSERT INTO maestro VALUES ('"+ tbNombre.Text +"')";
            cmm = new SqlCommand(query, con);
            bool resp = false;
            if (cmm.ExecuteNonQuery() > 0)
                resp = true;
            if (resp)
                MessageBox.Show("Se agregó correctamente");
            else
                MessageBox.Show("No se pudo agregar");
            con.Close();
        }

    }
}