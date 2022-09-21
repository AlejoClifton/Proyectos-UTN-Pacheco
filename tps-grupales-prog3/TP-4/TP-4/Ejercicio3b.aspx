<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3b.aspx.cs" Inherits="TP_4.Ejercicio3b" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Listado de Libros:<br />
            <br />
            <asp:GridView ID="grdLibros" runat="server">
            </asp:GridView>
            <asp:LinkButton ID="lbConsultarOtroTema" runat="server" OnClick="lbVerLibros_Click1">Consultar Otro Tema</asp:LinkButton>
        </div>
    </form>
</body>
</html>
