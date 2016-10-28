using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ConectarDropDownAAlumnos : System.Web.UI.Page
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
        OdbcConnection conexion = conectarBD();
        String query = "SELECT nombre FROM alumno";
        OdbcCommand sql = new OdbcCommand(query, conexion);
        OdbcDataReader lector = sql.ExecuteReader();
        while (lector.Read())
            DropDownList1.Items.Add(lector.GetString(0));
        lector.Close();
        conexion.Close();
    }
}