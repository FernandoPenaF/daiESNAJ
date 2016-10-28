using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ModificarInfoMaestro : System.Web.UI.Page
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

    }
    protected void btActualizar_Click(object sender, EventArgs e)
    {
        //Se puede ver que información va a actualizar por medio de dos checkBox que uno diga "Correo" y otro
        //"Contraseña", para así identificar cuales son los datos que quiere cambiar
        //El correo y la contraseña son obtenidos por textbox
        if (cbContraseña.Enabled)
        {
            OdbcConnection con = new OdbcConnection();
            String query = "UPDATE maestro SET contra='" + contraseña+"'";
            OdbcCommand cmm = new OdbcCommand(query, con);
            int var = cmm.ExecuteNonQuery();
            con.Close();
        }
        if (cbCorreo.Enabled)
        {
            OdbcConnection con = new OdbcConnection();
            String query = "UPDATE maestro SET correo='" + correo + "'";
            OdbcCommand cmm = new OdbcCommand(query, con);
            int var = cmm.ExecuteNonQuery();
            con.Close();
        }
    }
}