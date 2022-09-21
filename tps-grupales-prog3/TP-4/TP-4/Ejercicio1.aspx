<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP_4.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Destino Inicio"></asp:Label>
        <p>
        <asp:Label ID="lblProvinciaInicio" runat="server" Text="Provincia"></asp:Label>
            <asp:DropDownList ID="ddlProvinciaInicio" runat="server" style="margin-left: 11px" AutoPostBack="True" OnSelectedIndexChanged="ddlProvinciaInicio_SelectedIndexChanged">
            </asp:DropDownList>
        </p>
        <p>
        <asp:Label ID="lblLocalidadInicio" runat="server" Text="Localidad"></asp:Label>
            <asp:DropDownList ID="ddlLocalidadInicio" runat="server">
            </asp:DropDownList>
        </p>
        <p>
        <asp:Label ID="Label5" runat="server" Text="Destino Final"></asp:Label>
        </p>
        <p>
        <asp:Label ID="lblProviciaFinal" runat="server" Text="Provincia"></asp:Label>
            <asp:DropDownList ID="ddlProvinciaFinal" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProvinciaFinal_SelectedIndexChanged">
            </asp:DropDownList>
        </p>
        <p>
        <asp:Label ID="lblLocalidadFinal" runat="server" Text="Localidad"></asp:Label>
            <asp:DropDownList ID="ddlLocalidadFinal" runat="server">
            </asp:DropDownList>
        </p>
    </form>
</body>
</html>
