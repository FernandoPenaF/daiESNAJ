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

        private void btAgregar_Click(object sender, RoutedEventArgs e)
        {
            if(tbContraseña.Password == tbConfirmaContra.Password){
                con = MainWindow.conectarBase();
                cmm = new SqlCommand("SELECT MAX(idMaestro) FROM maestro", con);
                SqlDataReader lector = cmm.ExecuteReader();
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
                String query = "INSERT INTO maestro VALUES ('" + tbNombre.Text + "','" + tbCorreo.Text + "','" + tbContraseña.Password + "')";
                cmm = new SqlCommand(query, con);
                bool resp = false;
                if (cmm.ExecuteNonQuery() > 0)
                    resp = true;
                con.Close();
                if (resp)
                {
                    MessageBox.Show("Se agregó correctamente");
                    ventanaAnt.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("No se pudo agregar");
                con.Close();
            }else{
                MessageBox.Show("Las contraseñas deben coincidir");
                tbConfirmaContra.Clear();
                tbContraseña.Clear();
            }
        }

        private void btRegresar_Click(object sender, RoutedEventArgs e)
        {
            ventanaAnt.Show();
            this.Close();
        }


    }
}