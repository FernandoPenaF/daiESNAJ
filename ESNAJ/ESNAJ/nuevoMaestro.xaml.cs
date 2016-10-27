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
<<<<<<< HEAD
            cmm = new SqlCommand("SELECT MAX(idMaestro) FROM maestro", con);
            SqlDataReader lector = cmm.ExecuteReader();
            int nvoID = lector.GetInt32(0) + 1;
            String query = "INSERT INTO maestro VALUES (" + nvoID + ",'" + tbNombre + "')";
=======
            String query = "INSERT INTO maestro VALUES ('"+ tbNombre.Text +"')";
>>>>>>> e88b13edc4a103020a8c972d9f179bfa43ae9784
            cmm = new SqlCommand(query, con);
            bool resp = false;
            if (cmm.ExecuteNonQuery() > 0)
                resp = true;
<<<<<<< HEAD
            con.Close();
=======
>>>>>>> e88b13edc4a103020a8c972d9f179bfa43ae9784
            if (resp)
                MessageBox.Show("Se agregó correctamente");
            else
                MessageBox.Show("No se pudo agregar");
            con.Close();
        }
    }

    }
}