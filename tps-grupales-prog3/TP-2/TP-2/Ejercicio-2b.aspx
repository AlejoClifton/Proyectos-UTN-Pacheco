<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio-2b.aspx.cs" Inherits="TP_2.Ejercicio_2b" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblResumen" runat="server" Text="Resumen"></asp:Label>
        </div>
        <p>
            <asp:Label ID="lblForName" runat="server" Text="Nombre: "></asp:Label>
            <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:Label ID="lblForLastName" runat="server" Text="Apellido: "></asp:Label>
        <asp:Label ID="lblLastName" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:Label ID="LblForZone" runat="server" Text="Zona: "></asp:Label>
            <asp:Label ID="lblZone" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblForTemas" runat="server" Text="Los temas elegidos son:"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblTemas" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
