using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HistorialAlumno : System.Web.UI.Page
{
    protected OdbcConnection conectarBD()
    {
        String stringDeConexion = "Driver={SQL Server Native Client 11.0};Server=PONER NOMBRE DEL SERVIDOR;Uid=sa;Pwd=sqladmin;Database=ESNAJ;";
        try
        {
            OdbcConnection conexion = new OdbcConnection(stringDeConexion);
            conexion.Open();
            return conexion;
        }
        catch (Exception ex)
        {
            Response.Write("No se pudo hacer la conexion" + ex.StackTrace.ToString());
            return null;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        //El grid se obtiene por una session, de un alumno que inició sesión
        //Voy a poner 2 grid, uno para los datos personales del alumno y otro para poner todos los concursos en
        //los que ha participado
        OdbcConnection con = conectarBD();
        String query = "SELECT alumno.* FROM alumno WHERE idAlumno="+Session["Inicio"];
        OdbcCommand sql = new OdbcCommand(query, con);
        OdbcDataReader lector = sql.ExecuteReader();
        GridView1.DataSource = lector;
        GridView1.DataBind();

        con = conectarBD();
        query = "SELECT participo.* FROM participo WHERE idAlumno=" + Session["Inicio"];
        sql = new OdbcCommand(query, con);
        lector = sql.ExecuteReader();
        GridView2.DataSource = lector;
        GridView2.DataBind();
        lector.Close();
        con.Close();
    }
}