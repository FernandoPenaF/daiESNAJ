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
            String conectar = "Driver={SQL Server Native Client 11.0};Server=112SALAS06;Uid=sa;Pwd=sqladmin;Database=ESNAJ;";
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
            String query = "SELECT idAlumno, alumno.nombre, correo, puntosTotales, categoria, escuela.nombre as 'Escuela', contra FROM alumno INNER JOIN escuela ON alumno.idEscuela = escuela.idEscuela WHERE correo LIKE '" + tbCorreo.Text + "' AND contra = '" + tbPass.Text + "'";
            OdbcConnection con = conectarDB();
            OdbcCommand sql = new OdbcCommand(query, con);
            OdbcDataReader lector = sql.ExecuteReader();
            if (lector.HasRows)
            {
                lector.Read();
                Session["idAlumno"] = lector.GetInt32(0);
                Session["Nombre"] = lector.GetString(1);
                Session["Correo"] = lector.GetString(2);
                Session["Puntos"] = lector.GetInt32(3);
                Session["Categoria"] = lector.GetString(4);
                Session["Escuela"] = lector.GetString(5);
                Session["Contra"] = lector.GetString(6);

                Response.Redirect("PerfilA.aspx");
            }
            else
                Label1.Text = "Usuario/Contraseña incorrectos";
            con.Close();
            lector.Close();
        }
        catch (Exception ex) {
            Label1.Text = "Error interno"+ex;
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["primera"] = true;
        Session["correoMaestro"] = tbCorreo.Text;
        Session["contraseñaMaestro"] = tbPass.Text;

        OdbcConnection conexion = conectarDB();
        String query = "SELECT nombre, idMaestro FROM maestro WHERE correo = '"+tbCorreo.Text+"' AND contra = '"+tbPass.Text+"'";
        OdbcCommand sql = new OdbcCommand(query, conexion);
        OdbcDataReader lector = sql.ExecuteReader();

        if (lector.HasRows)
        {
            lector.Read();
            Session["nombreMaestro"]=lector.GetString(0);
            Session["idMaestro"] = lector.GetInt32(1);
            Response.Redirect("PerfilM.aspx");
        }
        else
            this.Label1.Text = "Usuario o contraseña incorrectos";

        
    }
}