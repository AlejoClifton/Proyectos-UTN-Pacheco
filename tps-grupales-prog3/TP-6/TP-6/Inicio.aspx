<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="TP_6.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitulo" runat="server" Text="Grupo N 2"></asp:Label>
        </div>
        <asp:HyperLink ID="hlEjercicio1" runat="server" NavigateUrl="~/Ejercicio1.aspx">Ejercicio 1</asp:HyperLink>
        <p>
            <asp:HyperLink ID="hlEjercicio2" runat="server" NavigateUrl="~/Ejercicio2.aspx">Ejercicio2</asp:HyperLink>
        </p>
    </form>
</body>
</html>
