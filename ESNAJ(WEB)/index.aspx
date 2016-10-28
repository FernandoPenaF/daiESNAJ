<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="styles.css">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <header>
      <p>
        Bienvenido a la Escuela Nacional de Ajedrez
      </p>
        <nav>
          <a href="http://www.esnaj.com">ESNAJ.com</a>
          <a href="http://www.esnaj.com/?page_id=14">Convocatorias</a>
          <a href="http://www.esnaj.com/?page_id=103">Contacto</a>
        </nav>
    </header>
    <main>
      <section class = "reg">
        <form id="form1" runat="server">
            Correo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbCorreo" runat="server"></asp:TextBox>
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
      </section>
      <aside>
        <img src="logo.png" alt="ESNAJlogo.png" />
      </aside>
    </main>
</body>
</html>
