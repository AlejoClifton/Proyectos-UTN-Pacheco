<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="TP_6.Ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p style="margin-left: 40px">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/SeleccionarProductos.aspx">Selecionar productos</asp:HyperLink>
        </p>
        <div style="margin-left: 40px">
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Eliminar Productos selecionados</asp:LinkButton>
        </div>
        <p style="margin-left: 40px">
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/MostrarProductos.aspx">Mostrar productos</asp:HyperLink>
        </p>
    </form>
</body>
</html>
