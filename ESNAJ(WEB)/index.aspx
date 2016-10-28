<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="styles.css">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: "Segoe UI";
        }
        .auto-style2 {
            color: #FFFFFF;
            font-weight: 700;
        }
        .auto-style3 {
            width: 131px;
            height: 170px;
            z-index: 1;
            left: 1047px;
            top: 62px;
            position: absolute;
        }
        #form1 {
            width: 1181px;
        }
    </style>
</head>
<body style="font-family: 'Segoe UI'; color: #FFFFFF; background-color: #822C32">
    <header>
      <p style="background-color: #822C32; font-weight: 700;">
        Bienvenido a la Escuela Nacional de Ajedrez
      </p>
        <form id="form1" runat="server">
            Correo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbCorreo" runat="server" OnTextChanged="tbCorreo_TextChanged"></asp:TextBox>
            <br />
            <br />
            Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbPass" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Login Maestros" OnClick="Button1_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Login Alumnos" OnClick="Button2_Click" />
            <br />
        </form>
        <nav style="width: 314px; z-index: 1; left: 870px; top: 18px; position: absolute; height: 21px">
            <span class="auto-style1">
          <a href="http://www.esnaj.com"><span class="auto-style2">ESNAJ.com</span></a>&nbsp;&nbsp;&nbsp;&nbsp;
          <a href="http://www.esnaj.com/?page_id=14"><span class="auto-style2">Convocatorias</span></a>&nbsp;&nbsp;&nbsp;&nbsp;
          <a href="http://www.esnaj.com/?page_id=103"><span class="auto-style2">Contacto</span></a></span>
        </nav>
    </header>
    <img alt="logo" class="auto-style3" src="logo.png" />
</body>
</html>
