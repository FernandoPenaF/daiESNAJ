<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PerfilA.aspx.cs" Inherits="PerfilA" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="background-color: #822C32">
    <form id="form1" runat="server">
    <div style="height: 663px; color: #FFFFFF; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; background-color: #822C32">
    
        <asp:Label ID="Label10" runat="server" Text="Mi perfil" style="font-weight: 700"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="lbNoticias" runat="server"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Cambiar información" style="font-weight: 700"></asp:Label>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Correo:" style="z-index: 1; left: 72px; top: 313px; position: absolute"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbCorreo" runat="server" style="z-index: 1; left: 287px; top: 311px; position: absolute; width: 213px"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbNuevoCorreo" runat="server" Text="Nuevo correo:" style="z-index: 1; left: 67px; top: 360px; position: absolute"></asp:Label>
&nbsp;<asp:TextBox ID="tbNuevoCorreo" runat="server" Width="213px" style="z-index: 1; left: 289px; top: 358px; position: absolute"></asp:TextBox>
        <br />
    
        <asp:Button ID="btCerrarSesion" runat="server" OnClick="btCerrarSesion_Click" Text="Cerrar Sesión" style="z-index: 1; left: 222px; top: 631px; position: absolute" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" Text="Contraseña anterior:" style="z-index: 1; left: 66px; top: 406px; position: absolute"></asp:Label>
        <asp:TextBox ID="tbContraseñaAnt" runat="server" Width="215px" style="z-index: 1; left: 287px; top: 404px; position: absolute" TextMode="Password"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label8" runat="server" Text="Nueva contraseña:" style="z-index: 1; left: 67px; top: 450px; position: absolute"></asp:Label>
        <asp:TextBox ID="tbNuevaContra" runat="server" Width="214px" style="z-index: 1; left: 289px; top: 450px; position: absolute" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label9" runat="server" Text="Confirmar nueva contraseña:" style="z-index: 1; left: 64px; top: 491px; position: absolute"></asp:Label>
        <asp:TextBox ID="tbNuevaContraConfirm" runat="server" Width="211px" style="z-index: 1; left: 291px; top: 493px; position: absolute" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="lbCambios" runat="server"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Button ID="btModificoInfo" runat="server" Text="Modificar información" OnClick="btModificoInfo_Click" style="z-index: 1; left: 191px; top: 546px; position: absolute" />
        <br />
        <br />

    
    </div>
    </form>
</body>
</html>
