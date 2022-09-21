<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarSucursales.aspx.cs" Inherits="Vista.AgregarSucursales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 124%;
        }
        .auto-style3 {
            width: 376px;
        }
        .auto-style4 {
            width: 376px;
            text-align: center;
            height: 30px;
        }
        .auto-style5 {
            width: 376px;
            text-align: left;
            height: 61px;
        }
        .auto-style6 {
            width: 169px;
            text-align: right;
        }
        .auto-style8 {
            width: 169px;
            text-align: right;
            height: 25px;
        }
        .auto-style9 {
            width: 376px;
            height: 25px;
        }
        .auto-style10 {
            height: 25px;
        }
        .auto-style11 {
            width: 169px;
        }
        .auto-style12 {
            width: 169px;
            text-align: center;
            height: 61px;
        }
        .auto-style13 {
            height: 61px;
        }
        .auto-style14 {
            width: 169px;
            height: 30px;
        }
        .auto-style15 {
            height: 30px;
        }
        .auto-style16 {
            width: 376px;
            margin-left: 40px;
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
                <tr>
                    <td class="auto-style11"><strong>
                        <br />
                        <br />
                        GRUPO N 2<br />
                        <br />
                        </strong></td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12"><strong>
                        <br />
                        Agregar sucursal<br />
                        </strong></td>
                    <td class="auto-style5"></td>
                    <td class="auto-style13"></td>
                </tr>
                <tr>
                    <td class="auto-style6">Nombre Sucursal:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txt_NombreSucursal" runat="server" Width="305px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">Descripcion:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txt_Descripcion" runat="server" Height="72px" Width="303px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">Provincia:</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="ddl_Provincias" runat="server" Height="17px" Width="309px" >
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">Direccion:</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="txt_Direccion" runat="server" Width="302px"></asp:TextBox>
                    </td>
                    <td class="auto-style10"></td>
                </tr>
                <tr>
                    <td class="auto-style14"></td>
                    <td class="auto-style4">
                        <asp:Button ID="btn_Aceptar" runat="server" Text="Aceptar" Width="164px" OnClick="btn_Aceptar_Click" />
                    </td>
                    <td class="auto-style15"></td>
                </tr>
            </table>
        </div>
        <br />
        <br />
        <asp:Label ID="lblAgregarSucursal" runat="server"></asp:Label>
    </form>
</body>
</html>
