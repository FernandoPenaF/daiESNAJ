<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificarInfoMaestro.aspx.cs" Inherits="ModificarInfoMaestro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:CheckBox ID="cbCorreo" runat="server" Text="Correo" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="cbContraseña" runat="server" Text="Contraseña" />
        <br />
        <br />
        <asp:Button ID="btActualizar" runat="server" OnClick="btActualizar_Click" Text="Actualizar" />
    
    </div>
    </form>
</body>
</html>
