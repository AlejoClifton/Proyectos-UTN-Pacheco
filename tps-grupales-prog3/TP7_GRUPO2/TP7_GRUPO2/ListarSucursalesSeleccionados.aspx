<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarSucursalesSeleccionados.aspx.cs" Inherits="TP7_GRUPO2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Grupo 2: Hector S. Coco Alexander Popp Nahuel Godoy Emiliano Del Pino Alejo Clifton</div>
        <asp:HyperLink ID="hpListarSucursales" runat="server" NavigateUrl="~/SeleccionarSucursales.aspx">Listado de Sucursales</asp:HyperLink>
        <asp:HyperLink ID="hpSucursalesSeleccionados" runat="server" NavigateUrl="~/ListarSucursalesSeleccionados.aspx">Mostrar Sucursales Seleccionadas</asp:HyperLink>
        <asp:GridView ID="gvSucursalesSeleccionadas" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
