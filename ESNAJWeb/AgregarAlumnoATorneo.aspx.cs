using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AgregarAlumnoATorneo : System.Web.UI.Page
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
    protected void btAgrega_Click(object sender, EventArgs e)
    {
        //Categoria puede ser puesta por un textbox
        //idAlumno se puede buscar por un DropDownList
        //Lo mismo para idTorneo

        OdbcConnection con = conectarBD();
        String query = "SELECT MAX(idParticipo) FROM participo";
        OdbcCommand cmm = new OdbcCommand(query, con);
        Object o = cmm.ExecuteScalar();
        if (DBNull.Value.Equals(o))
        {
            //Es el primer dato y la llave primaria debe ser 1
            query = "INSERT INTO participo VALUES(1,'"+categoria+","+null+","+null+","+idAlumno+","+idTorneo+")";
            cmm = new OdbcCommand(query, con);
            int var = cmm.ExecuteNonQuery();
            con.Close();
        }
        else
        {
            int llaveprimaria = (int)o;
            llaveprimaria++;
            query = "INSERT INTO participo VALUES(" + llaveprimaria + ",'" + categoria + "'," + null + "," + null + "," idAlumno+","+idTorneo + "')";
            cmm = new OdbcCommand(query, con);
            int var = cmm.ExecuteNonQuery();
            con.Close();
        }
    }
}