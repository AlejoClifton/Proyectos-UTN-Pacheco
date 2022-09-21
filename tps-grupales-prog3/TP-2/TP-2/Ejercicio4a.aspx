<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio4a.aspx.cs" Inherits="TP_2.Ejercicio4a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblUsuario" runat="server" Text="Usuario:"></asp:Label>
            <asp:TextBox ID="txtUsuario" runat="server" style="margin-left: 210px" Width="163px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblClave" runat="server" Text="Clave:"></asp:Label>
            <asp:TextBox ID="txtClave" runat="server" style="margin-left: 218px" Width="156px" OnTextChanged="txtClave_TextChanged" TextMode="Password"></asp:TextBox>
        </p>
        <asp:Button ID="btnAceptar" runat="server" style="margin-left: 295px; height: 26px;" Text="Aceptar" Width="92px" OnClick="btnAceptar_Click" />
    </form>
</body>
</html>
