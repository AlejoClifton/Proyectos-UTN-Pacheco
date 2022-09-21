<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio-1.aspx.cs" Inherits="TP_5.Ejercicio_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            width: 233px;
        }
        .auto-style4 {
            height: 23px;
            width: 233px;
        }
        .auto-style5 {
            width: 203px;
        }
        .auto-style6 {
            height: 23px;
            width: 203px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">
                        <asp:HyperLink ID="hlAgregarSucursal" runat="server" NavigateUrl="~/Ejercicio-1.aspx">Agregar Sucursal</asp:HyperLink>
                    </td>
                    <td class="auto-style5">
                        <asp:HyperLink ID="hlListadoDeSucursales" runat="server" NavigateUrl="~/ListarSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="hlEliminarSucursal" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="GRUPO Nº"></asp:Label>
                    </td>
                    <td class="auto-style6"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Agregar Sucursal"></asp:Label>
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label3" runat="server" Text="Nombre Sucursal:"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="tbxNombreSucursal" runat="server" Width="271px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label4" runat="server" Text="Descripcion:"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="tbxDescripcion" runat="server" Height="52px" Width="269px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label5" runat="server" Text="Provincia:"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="ddlProvincias" runat="server" Height="24px" Width="283px">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label6" runat="server" Text="Direccion:"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="tbxDireccion" runat="server" Width="275px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" style="margin-left: 64px" Text="Aceptar" Width="90px" />
                    </td>
                    <td>
                        <asp:Label ID="lblSucursalCargada" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
