using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected OdbcConnection conectarDB()
    {
        OdbcConnection conexion = null;
        try
        {
            String conectar = "Data Source=112SALAS31;Initial Catalog=ESNAJ;User ID=sa;Password=sqladmin";
            conexion = new OdbcConnection(conectar);
            conexion.Open();
        }
        catch (Exception e)
        {
            Console.Write(e.ToString());
        }

        return conexion;
    }



    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            String query = "SELECT idAlumno, alumno.nombre, correo, puntosTotales, categoria, escuela.nombre as 'Escuela' FROM alumno INNER JOIN escuela ON alumno.idEscuela = escuela.idEscuela WHERE correo LIKE '" + tbCorreo.Text + "' AND contra = '" + tbPass.Text + "'";
            OdbcConnection con = conectarDB();
            OdbcCommand sql = new OdbcCommand(query, con);
            OdbcDataReader lector = sql.ExecuteReader();
            if (lector.HasRows)
            {
                lector.Read();
                Session["Nombre"] = lector.GetString(1);
                Session["Correo"] = lector.GetString(2);
                Session["Puntos"] = lector.GetInt32(3);
                Session["Categoria"] = lector.GetString(4);
                Session["Escuela"] = lector.GetString(5);
            }
            else
                Label1.Text = "Usuario/Contraseña incorrectos";
            con.Close();
            lector.Close();

            Response.Redirect("PerfilA.aspx");
        }
        catch (Exception ex) {
            Label1.Text = "Error interno";
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("PerfilM.aspx");
    }
}