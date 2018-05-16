﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/LoginCSS.css" rel="stylesheet" />
</head>
<body>
<div class="pen-title">
  <h1>Bienvenido</h1>
</div>
<!-- Form Module-->
<div class="module form-module">
  <div class="toggle">
  </div>
  <div class="form">
    <h2>Ingrese a su cuenta</h2>
    <form  runat="server">
      <asp:TextBox ID="txtUser" placeholder="Usuario" runat="server"></asp:TextBox>
      <asp:TextBox ID="txtPass" placeholder="Contraseña" runat="server" TextMode="Password"></asp:TextBox>
      <asp:Button ID="btnEnter" runat="server" Text="Ingresar" BackColor="#33b5e5" ForeColor="White" OnClick="btnEnter_Click" />
       <asp:Label ID="lblMensaje" runat="server" Text="" ForeColor="Red" Font-Bold="true"></asp:Label>
    </form>
  </div>
</div>
</body>
</html>

