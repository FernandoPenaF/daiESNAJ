using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PerfilM : System.Web.UI.Page
{
    

    private void llenaConABC(DropDownList drop)
    {
        drop.Items.Clear();
        ArrayList letras = new ArrayList();
        letras.Add("-"); letras.Add("A");
        letras.Add("B"); letras.Add("C");
        letras.Add("D"); letras.Add("E");
        letras.Add("F"); letras.Add("G");
        letras.Add("H"); letras.Add("I");
        letras.Add("J"); letras.Add("K");
        letras.Add("L"); letras.Add("M");
        letras.Add("N"); letras.Add("Ñ");
        letras.Add("O"); letras.Add("P");
        letras.Add("Q"); letras.Add("R");
        letras.Add("S"); letras.Add("T");
        letras.Add("U"); letras.Add("V");
        letras.Add("W"); letras.Add("X");
        letras.Add("Y"); letras.Add("Z");
        for (int i = 0; i < letras.Count; i++)
        {
            drop.Items.Add(letras[i].ToString());
        }
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
    protected void btCerrarSesion_Click(object sender, EventArgs e)
    {
        Session["idMaestro"] = null;
        Session["contraseñaMaestro"] = null;
        Session["nombreMaestro"] = null;
        Session["idMaestro"] = null;
        Response.Redirect("index.aspx");
    }
    private void llenaTorneos(DropDownList torneo)
    {
        torneo.Items.Clear();
        OdbcConnection conexion = conectarDB();
        String query = "SELECT nombre FROM torneo";
        OdbcCommand sql = new OdbcCommand(query, conexion);
        OdbcDataReader lector = sql.ExecuteReader();
        while (lector.Read())
            torneo.Items.Add(lector.GetString(0));
        lector.Close();
        conexion.Close();
    }
    private void llenaTodosAlumnos(DropDownList alum) {
        OdbcConnection conexion = conectarDB();
        String query = "SELECT nombre FROM alumno ORDER BY alumno.nombre";
        OdbcCommand sql = new OdbcCommand(query, conexion);
        OdbcDataReader lector = sql.ExecuteReader();
        while (lector.Read())
            alum.Items.Add(lector.GetString(0));
        lector.Close();
        conexion.Close();
    }
    private void llenaAlumnos(DropDownList alum,String inicio)
    {
        OdbcConnection conexion = conectarDB();
        String query = "SELECT nombre FROM alumno WHERE nombre LIKE '"+inicio+"%' ORDER BY alumno.nombre";
        OdbcCommand sql = new OdbcCommand(query, conexion);
        OdbcDataReader lector = sql.ExecuteReader();
        while (lector.Read())
            alum.Items.Add(lector.GetString(0));
        lector.Close();
        conexion.Close();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        bool controlador = (bool) Session["primera"];
        if (controlador)
        {
            this.llenaTorneos(dropTorneos);
            this.llenaConABC(dropLetras);
            this.llenaTodosAlumnos(dropAlumnos);
            this.lbBienvenido.Text = "¡Bienvenido nuevamente " + Session["nombreMaestro"] + "!";
        }
        lbAltas.Text = "";
        Session["primera"] = false;
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        if (dropLetras.Text.Equals("-"))
        {
            this.llenaTodosAlumnos(dropAlumnos);
        }
        else
        {
            dropAlumnos.Items.Clear();
            llenaAlumnos(dropAlumnos,dropLetras.Text);


        }
    
    }
    protected void btAltaAlumno_Click(object sender, EventArgs e)
    {
        if (!dropAlumnos.Text.Equals("") && !dropTorneos.Text.Equals(""))
        {
            OdbcConnection con = this.conectarDB();
            String query = "SELECT * FROM alumno WHERE nombre = '" + dropAlumnos.Text + "'";
            OdbcCommand cmm = new OdbcCommand(query, con);
            OdbcDataReader lector = cmm.ExecuteReader();
            lector.Read();
            int idAlum = lector.GetInt32(0);
            lector.Close();

            query = "SELECT idTorneo FROM torneo WHERE nombre = '" + dropTorneos.Text + "'";
            cmm = new OdbcCommand(query, con);
            lector = cmm.ExecuteReader();
            lector.Read();
            int idTorneo = lector.GetInt32(0);
            lector.Close();

            query = "INSERT INTO inscrito VALUES(" + idTorneo + "," + idAlum + ")";
            cmm = new OdbcCommand(query, con);
            lector = cmm.ExecuteReader();
            lector.Read();


            lbAltas.Text = "Alta del alumno al torneo exitosa";
        }
        else
        {
            if(dropAlumnos.Text.Equals(""))
                lbAltas.Text="Seleccione primero a un alumno";
            else
                lbAltas.Text = "No hay torneos disponibles";
        }
            


    }
    protected void btModificoInfo_Click(object sender, EventArgs e)
    {

        String correo = tbCorreo.Text;
        String contraseñaAntes = tbContraseñaAnt.Text;


        if (correo.Equals(""+Session["correoMaestro"]) && contraseñaAntes.Equals(""+Session["contraseñaMaestro"]))
        {
            if(!tbNuevoCorreo.Text.Equals("") && !tbNuevaContra.Text.Equals("") && !tbNuevaContraConfirm.Text.Equals("")){
                if(tbNuevaContra.Text.Equals(tbNuevaContraConfirm.Text)){
                    OdbcConnection con = this.conectarDB();
                    String query = "UPDATE maestro SET correo='"+tbNuevoCorreo.Text+"' WHERE idMaestro = "+Session["idMaestro"]+"";
                    OdbcCommand cmm = new OdbcCommand(query,con);
                    cmm.ExecuteNonQuery();

                    query = "UPDATE maestro SET contra='" + tbNuevaContra.Text + "' WHERE idMaestro = " + Session["idMaestro"] + "";
                    cmm = new OdbcCommand(query, con);

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