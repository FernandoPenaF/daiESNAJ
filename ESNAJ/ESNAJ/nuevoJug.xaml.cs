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
    /// Lógica de interacción para nuevoJug.xaml
    /// </summary>
    public partial class nuevoJug : Window
    {
        SqlConnection con;
        SqlCommand cmm;

        Menu ventanaAnt;

        public nuevoJug(Menu ventanaMenu)
        {
            ventanaAnt = ventanaMenu;

            InitializeComponent();
            cbGrados.Items.Add("Pachón");
            cbGrados.Items.Add("Peonina");
            cbGrados.Items.Add("Bonifacio");
            cbGrados.Items.Add("Bonfil");
            cbGrados.Items.Add("Pedro");
            cbGrados.Items.Add("Anabella");
            cbGrados.Items.Add("Rey ESNAJ");
            cbGrados.SelectedIndex = 0;

            cbEscuelas.Items.Add("-----------------------------------");

            con = MainWindow.conectarBase();
            String query = "SELECT nombre FROM escuela";
            cmm = new SqlCommand(query, con);
            SqlDataReader lector = cmm.ExecuteReader();
            lector.Read();
            while (lector.Read())
            {
                cbEscuelas.Items.Add(lector.GetValue(0));
            }
            cbEscuelas.SelectedIndex = 0;

        }

        private void btRegresar_Click(object sender, RoutedEventArgs e)
        {
            ventanaAnt.Show();
            this.Close();
        }

        private void btAgregar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
