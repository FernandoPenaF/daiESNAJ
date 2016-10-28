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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ESNAJ
{
    public partial class MainWindow : Window
    {
        SqlConnection con;
        SqlCommand cmm;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!tbUsu.Text.Equals("") && !tbContra.SecurePassword.Equals(""))
            {
                //Se busca en la base de datos al usuario
                con = Conexion.conectar();
                String query = "SELECT contraseña FROM usuariosGenerales WHERE  idUsuario = '" + tbUsu.Text + "'";
                cmm = new SqlCommand(query, con);
                SqlDataReader lect = cmm.ExecuteReader();
                lect.Read();
                try
                {
                    String clav = lect.GetString(0);
                    if (clav != tbContra.Password)
                        MessageBox.Show("Contraseña incorrecta");
                    else
                    {
                        Menu ventanaMenu = new Menu();
                        this.Close();
                        ventanaMenu.Show();
                        con.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Usuario no valido");
                }
            }
            else
                MessageBox.Show("Antes de iniciar complete los datos");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Close();
        }
    }
}
