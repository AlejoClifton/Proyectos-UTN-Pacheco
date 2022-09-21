<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio-5.aspx.cs" Inherits="TP_2.Ejercicio_5" %>

<!DOCTYPE html>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-eOJMYsd53ii+scO/bJGFsiCZc+5NDVN2yr8+0RDqr0Ql0h+rP48ckxlpbzKgwra6" crossorigin="anonymous"/>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.bundle.min.js" integrity="sha384-JEW9xMcG8R+pH31jmWH6WWP0WintQrMb4s7ZOdauHnUtxwoG2vI5DkLtS3qm9Ekf" crossorigin="anonymous"></script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
<asp:Label ID="Label1" runat="server" Text="Elija su configuracion:"></asp:Label>
        <div class="container sm">
            <div class="row">
                
                <div class="col">
                    <asp:Label ID="Label2" runat="server" Text="Seleccione cantidad de memoria"></asp:Label>
                    <asp:DropDownList ID="ddlMemoria" runat="server" OnSelectedIndexChanged="ddlMemoria_SelectedIndexChanged">
                        <asp:ListItem Value="200,00">2 GB</asp:ListItem>
                        <asp:ListItem Value="375,00">4 GB</asp:ListItem>
                        <asp:ListItem Value="500,00">6 GB</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col">
                    <asp:Label ID="Label3" runat="server" Text="Seleccione accesorios"></asp:Label>
                    <asp:CheckBoxList ID="cblComponentes" runat="server">
                        <asp:ListItem Value="2000,50">Monitor LCD</asp:ListItem>
                        <asp:ListItem Value="550,50">HD 500GB</asp:ListItem>
                        <asp:ListItem Value="1200,00">Grabador DVD</asp:ListItem>
                    </asp:CheckBoxList>
                </div>
                <div>
                    <asp:Button CssClass="btn btn-primary position-relative start-50 translate-middle-x" ID="Button1" runat="server" Text="Calcular precio" OnClick="Button1_Click" />
                </div>
            </div>
            
            
        </div>
        <asp:Label ID="Label4" runat="server" Text="El precio final es: "></asp:Label><asp:Label ID="lblPrecio" runat="server"></asp:Label>
    </form>
</body>
</html>
