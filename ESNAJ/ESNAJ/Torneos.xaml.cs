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
    /// Lógica de interacción para Torneos.xaml
    /// </summary>
    public partial class Torneos : Window
    {

        SqlConnection con;
        SqlCommand cmm;

        Menu ventanaAnt;

        public Torneos(Menu ventanaMenu)
        {
            ventanaAnt = ventanaMenu;

            InitializeComponent();

            con = Conexion.conectar();
            String query = "SELECT nombre FROM escuela";
            cmm = new SqlCommand(query, con);
            SqlDataReader lector = cmm.ExecuteReader();
            while (lector.Read())
            {
                cbEscuelas.Items.Add(lector.GetValue(0));
            }
            cbEscuelas.SelectedIndex = 0;
            lector.Close();
        }

        private void btAgregar_Click(object sender, RoutedEventArgs e)
        {

            con = Conexion.conectar();
            String query = "SELECT escuela.idEscuela FROM escuela WHERE nombre LIKE '" + cbEscuelas.Text + "'";
            cmm = new SqlCommand(query, con);
            SqlDataReader lector = cmm.ExecuteReader();
            lector.Read();
            int idEsc = lector.GetInt32(0);
            lector.Close();

            cmm = new SqlCommand("SELECT MAX(idTorneo) FROM torneo", con);
            lector = cmm.ExecuteReader();
            int nuevoId;
            if (lector.HasRows)
            {
                lector.Read();
                if (lector.IsDBNull(0))
                    nuevoId = 1;
                else
                    nuevoId = lector.GetInt32(0) + 1;
            }
            lector.Close();

            query = "INSERT INTO torneos VALUES (" + idEsc + ",'"+ tbNombre.Text + "','" + datepick.Text + "'," + idEsc + ")";
            cmm = new SqlCommand(query, con);
            bool resp = false;
            if (cmm.ExecuteNonQuery() > 0)
                resp = true;
            if (resp)
                MessageBox.Show("Alta exitosa");
            else
                MessageBox.Show("No se dió de alta");
            con.Close();
        }

        private void btRegresar_Click(object sender, RoutedEventArgs e)
        {
            ventanaAnt.Show();
            this.Close();
        }

    }
}
