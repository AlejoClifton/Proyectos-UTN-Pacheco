<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="TP_4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Id Producto:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlProducto" runat="server" Font-Names="Arial" Height="28px" Width="91px">
                <asp:ListItem Value="=">Igual a:</asp:ListItem>

                <asp:ListItem Value=">">Mayor a:</asp:ListItem>

                <asp:ListItem Value="<">Menor a:</asp:ListItem>

            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtProducto" runat="server"></asp:TextBox>
        </div>
        <p>
            Id Categoria:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlCategoria" runat="server" Height="28px" Width="91px">
                <asp:ListItem Value="=">Igual a:</asp:ListItem>

                <asp:ListItem Value=">">Mayor a:</asp:ListItem>

                <asp:ListItem Value="<">Menor a:</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCategoria" runat="server"></asp:TextBox>
        </p>
        <div style="margin-left: 360px">
            <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btonQuitarFiltro" runat="server" Text="Quitar Filtro" OnClick="btonQuitarFiltro_Click" />
            <br />
        </div>
        <asp:GridView ID="grdProductos" runat="server" Width="282px">
        </asp:GridView>
    </form>
</body>
</html>
