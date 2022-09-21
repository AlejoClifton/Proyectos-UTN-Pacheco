<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio-2a.aspx.cs" Inherits="TP_2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-eOJMYsd53ii+scO/bJGFsiCZc+5NDVN2yr8+0RDqr0Ql0h+rP48ckxlpbzKgwra6" crossorigin="anonymous"/>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.bundle.min.js" integrity="sha384-JEW9xMcG8R+pH31jmWH6WWP0WintQrMb4s7ZOdauHnUtxwoG2vI5DkLtS3qm9Ekf" crossorigin="anonymous"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-4">
            <div class="row mt-2">
                <div class="col-2"><asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label></div>
                <div class="col-10"><asp:TextBox CssClass="form-control" ID="txtNombre" runat="server"></asp:TextBox></div>
                
                
            </div>
            <div class="row mt-2">
                <div class="col-2"><asp:Label ID="lblApellido" runat="server" Text="Apellido:"></asp:Label></div>
                <div class="col-10"><asp:TextBox CssClass="form-control" ID="txtApellido" runat="server"></asp:TextBox></div>
                
                
            </div>
            <div class="row mt-2">
                <div class="col-2"> <asp:Label ID="lblCiudad" runat="server" Text="Ciudad:"></asp:Label></div>
                <div class="col-10">
                    <asp:DropDownList CssClass="form-select" ID="DropDownList1" runat="server" >
                        <asp:ListItem Value="Norte">Gral. Pacheco</asp:ListItem>
                        <asp:ListItem Value="Oeste">San Miguel</asp:ListItem>
                        <asp:ListItem Value="Sur">Boedo</asp:ListItem>
                    </asp:DropDownList>
                </div>
               
                
            </div>
            <div class="mt-4">
                <asp:Label ID="lblTemas" runat="server" Text="Temas:"></asp:Label>
            </div>
            <asp:CheckBoxList ID="chbxTemas" runat="server" CssClass="position-relative start-50 translate-middle-x">
                <asp:ListItem>Ciencias</asp:ListItem>
                <asp:ListItem>Literatura</asp:ListItem>
                <asp:ListItem>Historia</asp:ListItem>
            </asp:CheckBoxList>
            <div class="mt-2">
                <asp:Button ID="btnVerResumen" CssClass="btn btn-primary position-relative start-50 translate-middle-x" runat="server" Text="Ver Resumen" OnClick="btnVerResumen_Click" />
            </div>
        </div>
        
    </form>
</body>
</html>
