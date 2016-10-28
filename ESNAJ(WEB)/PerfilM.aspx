<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PerfilM.aspx.cs" Inherits="PerfilM" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            color: #FFFFFF;
            font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
            background-color: #822C32;
        }
    </style>
</head>
<body style="background-color: #822C32">
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>
        <asp:Button ID="btCerrarSesion" runat="server" OnClick="btCerrarSesion_Click" Text="Cerra Sesión" />
        <br />
        <br />
        <asp:Label ID="lbBienvenido" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Alta de alumnos a torneos" style="font-weight: 700"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="Torneo:"></asp:Label>
&nbsp;<asp:DropDownList ID="dropTorneos" runat="server">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="Alumno:"></asp:Label>
&nbsp;<asp:DropDownList ID="dropAlumnos" runat="server">
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label10" runat="server" Text="Apellido empieza con:" style="z-index: 1; left: 25px; top: 214px; position: absolute"></asp:Label>
&nbsp;<asp:DropDownList ID="dropLetras" runat="server" style="z-index: 1; left: 201px; top: 215px; position: absolute">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Filtrar" style="z-index: 1; left: 303px; top: 212px; position: absolute" />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Button ID="btAltaAlumno" runat="server" Text="Dar de alta" OnClick="btAltaAlumno_Click" style="z-index: 1; left: 138px; top: 260px; position: absolute" />
        <br />
        <br />
        <asp:Label ID="lbAltas" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Cambiar información" style="font-weight: 700"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label6" runat="server" Text="Correo:" style="z-index: 1; left: 103px; top: 408px; position: absolute"></asp:Label>
        <asp:TextBox ID="tbCorreo" runat="server" Width="218px" style="z-index: 1; left: 341px; top: 410px; position: absolute"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbNuevoCorreo" runat="server" Text="Nuevo correo:" style="z-index: 1; left: 103px; top: 455px; position: absolute"></asp:Label>
&nbsp;<asp:TextBox ID="tbNuevoCorreo" runat="server" style="z-index: 1; left: 342px; top: 452px; position: absolute; width: 216px"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" Text="Contraseña anterior:" style="z-index: 1; left: 101px; top: 496px; position: absolute; right: 958px"></asp:Label>
        <asp:TextBox ID="tbContraseñaAnt" runat="server" Width="215px" style="z-index: 1; left: 341px; top: 495px; position: absolute" TextMode="Password"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label8" runat="server" Text="Nueva contraseña:" style="z-index: 1; left: 100px; top: 539px; position: absolute"></asp:Label>
        <asp:TextBox ID="tbNuevaContra" runat="server" Width="214px" style="z-index: 1; left: 342px; top: 536px; position: absolute" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label9" runat="server" Text="Confirmar nueva contraseña:" style="z-index: 1; left: 101px; top: 581px; position: absolute"></asp:Label>
        <asp:TextBox ID="tbNuevaContraConfirm" runat="server" Width="211px" style="z-index: 1; left: 343px; top: 579px; position: absolute; bottom: 232px;" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btModificoInfo" runat="server" Text="Modificar información" OnClick="btModificoInfo_Click" style="z-index: 1; left: 243px; top: 642px; position: absolute" />
        <br />
        <br />
        <br />
        <asp:Label ID="lbCambios" runat="server"></asp:Label>
        <br />
    </form>
</body>
</html>
