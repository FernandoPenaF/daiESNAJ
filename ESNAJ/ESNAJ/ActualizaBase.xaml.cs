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

        private void setInitial()
        {
            tbBase.Text = "Base de datos";
            tbEscuela.Text = "Escuela";
            tbCat1.Text = "Categoría 1";
            tbCat2.Text = "Categoría 2";
            tbCat3.Text = "Categoría 3";
            tbCat4.Text = "Categoría 4";

            tbBase.Opacity = .65;
            tbEscuela.Opacity = .65;
            tbCat1.Opacity = .65;
            tbCat2.Opacity = .65;
            tbCat3.Opacity = .65;
            tbCat4.Opacity = .65;
        }

        private void btCargaEscuela_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                List<Escuela> lista = new List<Escuela>();
                int cont = 0;

                if (tbEscuela.Opacity == 100)
                {
                    String path = tbEscuela.Text;
                    lista = Excel.getEscuelas(path);
                    for (int i = 0; i < lista.Count; i++)
                    {
                        ManejadorAlumnoN.altaEscuela(lista[i]);
                    }
                    cont += lista.Count;
                    MessageBox.Show("Se añadieron " + cont + " escuelas a la base de datos");
                    setInitial();
                }
                else
                    MessageBox.Show("No se ha indicado la ruta del archivo");
            }catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }


        private void btCargaBase_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                List<Jugador> lista = new List<Jugador>();
                int cont = 0;

                if (tbBase.Opacity == 100)
                {
                    String path = tbBase.Text;
                    lista = Excel.altaInicial(path);
                    for (int i = 0; i < lista.Count; i++)
                    {
                        ManejadorAlumnoN.altaJugador(lista[i]);
                    }
                    cont += lista.Count;
                    MessageBox.Show("Se añadieron " + cont + " jugadores a la base de datos");
                    setInitial();
                }
                else
                    MessageBox.Show("No se ha indicado la ruta del archivo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void btActualiza_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                List<Jugador> lista = new List<Jugador>();
                int cont = 0;

                if (tbCat1.Opacity == 100)
                {
                    String path = tbCat1.Text;
                    lista = Excel.infoActualizar(path);
                    for (int i = 0; i < lista.Count; i++)
                    {
                        ManejadorAlumnoN.actualizaBase(lista[i]);
                    }
                    cont += lista.Count;
                }

                if (tbCat2.Opacity == 100)
                {
                    String path = tbCat2.Text;
                    lista = Excel.infoActualizar(path);
                    for (int i = 0; i < lista.Count; i++)
                    {
                        ManejadorAlumnoN.actualizaBase(lista[i]);
                    }
                    cont += lista.Count;
                }

                if (tbCat3.Opacity == 100)
                {
                    String path = tbCat3.Text;
                    lista = Excel.infoActualizar(path);
                    for (int i = 0; i < lista.Count; i++)
                    {
                        ManejadorAlumnoN.actualizaBase(lista[i]);
                    }
                    cont += lista.Count;
                }

                if (tbCat4.Opacity == 100)
                {
                    String path = tbCat4.Text;
                    lista = Excel.infoActualizar(path);
                    for (int i = 0; i < lista.Count; i++)
                    {
                        ManejadorAlumnoN.actualizaBase(lista[i]);
                    }
                    cont += lista.Count;
                }
                setInitial();
                MessageBox.Show("Se actualizó la información de " + cont + " jugadores");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void getPathDB(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Excel files (*.xls)|*.xls";
            if (openFileDialog1.ShowDialog() == true)
            {
                tbBase.Text = openFileDialog1.FileNames[0].ToString();
                tbBase.Opacity = 100;
            }
        }

        private void getPathEsc(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Excel files (*.xls)|*.xls";
            if (openFileDialog1.ShowDialog() == true)
            {
                tbEscuela.Text = openFileDialog1.FileNames[0].ToString();
                tbEscuela.Opacity = 100;
            }
        }

        private void getPath1(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Excel files (*.xls)|*.xls";
            if (openFileDialog1.ShowDialog() == true)
            {
                tbCat1.Text = openFileDialog1.FileNames[0].ToString();
                tbCat1.Opacity = 100;
            }
        }

        private void getPath2(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Excel files (*.xls)|*.xls";
            if (openFileDialog1.ShowDialog() == true)
            {
                tbCat2.Text = openFileDialog1.FileNames[0].ToString();
                tbCat2.Opacity = 100;
            }
        }

        private void getPath3(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Excel files (*.xls)|*.xls";
            if (openFileDialog1.ShowDialog() == true)
            {
                tbCat3.Text = openFileDialog1.FileNames[0].ToString();
                tbCat3.Opacity = 100;
            }
        }

        private void getPath4(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Excel files (*.xls)|*.xls";
            if (openFileDialog1.ShowDialog() == true)
            {
                tbCat4.Text = openFileDialog1.FileNames[0].ToString();
                tbCat4.Opacity = 100;
            }
        }

        private void btLimpia_Click(object sender, RoutedEventArgs e)
        {
            setInitial();
        }

        private void btRegresar_Click(object sender, RoutedEventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            Close();
        }
    }
}
