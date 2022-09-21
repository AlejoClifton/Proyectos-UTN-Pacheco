<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio-1.aspx.cs" Inherits="TP_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="lblProducto" runat="server" Text="Ingrese nombre producto:    "></asp:Label>
            <asp:TextBox ID="tbxProducto" runat="server"></asp:TextBox>
            <asp:Label ID="lblCantidad" runat="server" Text="Cantidad:    "></asp:Label>
            <asp:TextBox ID="tbxCantidad" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblProducto2" runat="server" Text="Ingrese nombre producto:    "></asp:Label>
        <asp:TextBox ID="tbxProducto2" runat="server"></asp:TextBox>
        <asp:Label ID="lblCantidad2" runat="server" Text="Cantidad:    "></asp:Label>
        <asp:TextBox ID="tbxCantidad2" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnGenerar" runat="server" Height="29px" OnClick="btnGenerar_Click" Text="Generar Tabla" Width="134px" />
        </p>
        <asp:Label ID="lblTabla" runat="server" Text=" "></asp:Label>
    </form>
</body>
</html>
