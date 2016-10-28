using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PerfilA : System.Web.UI.Page
{

    protected OdbcConnection conectarDB()
    {
        OdbcConnection conexion = null;
        try
        {
            String conectar = "Driver={SQL Server Native Client 11.0};Server=112SALAS07;Uid=sa;Pwd=sqladmin;Database=ESNAJ;";
            conexion = new OdbcConnection(conectar);
            conexion.Open();
        }
        catch (Exception e)
        {
            Console.Write(e.ToString());
        }

        return conexion;
    }

    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["idAlumno"] != null)
        {
            String query = "SELECT idAlumno,nombre,correo,puntosTotales, categoria FROM alumno WHERE idAlumno ="+(int)Session["idAlumno"];
            OdbcConnection con = conectarDB();
            OdbcCommand cmm = new OdbcCommand(query,con);
            OdbcDataReader lec = cmm.ExecuteReader();
            lec.Read();

            ArrayList lista = new ArrayList();
            lista.Add("idAlumno: " + lec.GetInt32(0));
            lista.Add("Nombre: " + lec.GetString(1));
            lista.Add("Correo: " + lec.GetString(2));
            lista.Add("Puntos: " + lec.GetInt32(3));
            lista.Add("Categoría: " + lec.GetString(4));

            GridView1.ShowHeader = false;
            GridView1.DataSource = lista;
            GridView1.DataBind();
        }
        else
            lbNoticias.Text = "Información no encontrada, regrese a la página de inicio y vuelva a iniciar sesión";

    }

    protected void btCerrarSesion_Click(object sender, EventArgs e)
    {
        Session["idAlumno"] = null;
        Session["Nombre"] = null;
        Session["Correo"] = null;
        Session["Puntos"] = null;
        Session["Categoria"] = null;
        Session["Escuela"] = null;
        Session["Contra"] = null;
        Response.Redirect("index.aspx");
    }

    protected void btModificoInfo_Click(object sender, EventArgs e)
    {
        String correo = tbCorreo.Text;
        String contraseñaAntes = tbContraseñaAnt.Text;

        if (correo.Equals(""+Session["Correo"]) && contraseñaAntes.Equals(""+Session["Contra"]))
        {
            if(!tbNuevoCorreo.Text.Equals("") && !tbNuevaContra.Text.Equals("") && !tbNuevaContraConfirm.Text.Equals("")){
                if(tbNuevaContra.Text.Equals(tbNuevaContraConfirm.Text)){
                    OdbcConnection con = this.conectarDB();
                    String query = "UPDATE alumno SET correo='"+tbNuevoCorreo.Text+"' WHERE idAlumno = "+Session["idAlumno"]+"";
                    OdbcCommand cmm = new OdbcCommand(query,con);
                    cmm.ExecuteNonQuery();

                    query = "UPDATE alumno SET contra='" + tbNuevaContra.Text + "' WHERE idAlumno = " + Session["idAlumno"] + "";
                    cmm = new OdbcCommand(query, con);
                    cmm.ExecuteNonQuery();
                    lbCambios.Text = "Cambio exitoso de correo y contraseñas";
                }else
                    lbCambios.Text = "Las nuevas contraseñas no coinciden";
            }else
                lbCambios.Text = "Complete todos los campos antes de cambiar la información(si no va a cambiar el correo copielo en el nuevo correo)";
        }
        else
        {
            lbCambios.Text = "Correo o contraseña anterior distintos";
        }
    }
}