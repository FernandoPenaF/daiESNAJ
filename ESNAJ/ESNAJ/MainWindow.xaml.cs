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
        public static SqlConnection conectarBase()
        {
            String deConexion = "Data Source=112SALAS31;Initial Catalog=ESNAJ; User ID=sa;Password=sqladmin"; //-----------------------------------------------------------------------------------------
            try
            {
                SqlConnection con = new SqlConnection(deConexion); con.Open(); return con;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No conectado" + ex.ToString());
            }
            return null;
        }       //C A M B I A R   S T R I N G    D E    C O N E X I O N     C O N F O R M E  
        // A      T U     M A Q U I N A
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!tbUsu.Text.Equals("") && !tbContra.SecurePassword.Equals(""))
            {
                //Se busca en la base de datos al usuario
                con = conectarBase();
                String query = "SELECT idUsuario,contraseña FROM usuariosGenerales WHERE  idUsuario = '" + tbUsu.Text + "' AND  contraseña = '" + tbContra.SecurePassword + "'";
                cmm = new SqlCommand(query, con);

                SqlDataReader lect = cmm.ExecuteReader();
                lect.Read();
                if (lect.Equals(null))
                    MessageBox.Show("No se encontró usuario en la base de datos");
                else
                {
                    lect.Close();
                    con.Close();

                    Menu ventanaMenu = new Menu();
                    ventanaMenu.Show(); this.Close();
                }
            }
            else
                MessageBox.Show("Antes de iniciar complete los datos");
        }
    }
}
