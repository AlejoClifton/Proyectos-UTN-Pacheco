<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio-3.aspx.cs" Inherits="TP_2.Ejercicio_3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="lbRojo" runat="server" OnClick="lbRojo_Click">Rojo</asp:LinkButton> 
        </div>
        <div>
            <asp:LinkButton ID="lbVerde" runat="server" OnClick="lbVerde_Click">Verde</asp:LinkButton>
        </div>
        <div>
            <asp:LinkButton ID="lbAzul" runat="server" OnClick="lbAzul_Click">Azul</asp:LinkButton>
       </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lbColoreado" runat="server" Text="Texto Coloreado"></asp:Label>
        </p>
    </form>
</body>
</html>
