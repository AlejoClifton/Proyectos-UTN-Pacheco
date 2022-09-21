<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoSucursales.aspx.cs" Inherits="Vista.ListadoSucursales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style11 {
            width: 169px;
        }
        .auto-style16 {
            width: 376px;
            margin-left: 40px;
        }
        .auto-style1 {
            width: 124%;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style11">
                        <br />
                        <br />
                        <asp:HyperLink ID="link_agregarSucursal" runat="server" NavigateUrl="~/AgregarSucursales.aspx">Agregar Sucursal</asp:HyperLink>
                        <br />
                        <br />
                    </td>
                    <td class="auto-style16">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:HyperLink ID="link_listarSucursales" runat="server" NavigateUrl="~/ListadoSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="link_EliminarSucursal" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </div>
        <p>
            <asp:GridView ID="gdSucursales" runat="server" OnSelectedIndexChanged="gdSucursales_SelectedIndexChanged">
            </asp:GridView>
        </p>
    </form>
</body>
</html>
