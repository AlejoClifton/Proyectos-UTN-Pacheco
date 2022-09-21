<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3.aspx.cs" Inherits="TP_4.Ejercicio3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSeleccionarTema" runat="server" Text="Seleccionar Tema:"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" style="margin-left: 59px" Width="243px">
                <asp:ListItem Value="1">Tema 1</asp:ListItem>
                <asp:ListItem Value="2">Tema 2</asp:ListItem>
                <asp:ListItem Value="3">Tema 3</asp:ListItem>
            </asp:DropDownList>
        </div>
        <p>
            <asp:LinkButton ID="lbVerLibros" runat="server" OnClick="lbVerLibros_Click1">Ver Libros</asp:LinkButton>
        </p>
    </form>
</body>
</html>
