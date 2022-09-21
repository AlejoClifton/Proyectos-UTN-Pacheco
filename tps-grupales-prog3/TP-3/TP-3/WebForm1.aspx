<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TP_3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblLocalidad" runat="server" Font-Bold="True" Text="Localidad"></asp:Label>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Nombre de la localidad: "></asp:Label>
            <asp:TextBox ID="tbxLocalidad" runat="server" style="margin-left: 91px; margin-bottom: 0px" Width="148px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvLocalidad" runat="server" ControlToValidate="tbxLocalidad" ErrorMessage="Ingrese localidad" ValidationGroup="grupo1"></asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:Button ID="btnGuardarLocalidad" runat="server" style="margin-left: 242px; margin-bottom: 0px" Text="Guardar Localidad" Width="132px" OnClick="btnGuardarLocalidad_Click" ValidationGroup="grupo1" />
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Usuarios"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Nombre Usuario: "></asp:Label>
            <asp:TextBox ID="tbxNombreUsuario" runat="server" style="margin-left: 84px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="tbxNombreUsuario" ErrorMessage="Ingrese el nombre" ValidationGroup="grupo2"></asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Contraseña:"></asp:Label>
            <asp:TextBox ID="tbxContraseña" runat="server" style="margin-left: 120px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvPass" runat="server" ControlToValidate="tbxContraseña" ErrorMessage="Seleccione su password" ValidationGroup="grupo2"></asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Repetir Contraseña:"></asp:Label>
            <asp:TextBox ID="tbxRepetirContraseña" runat="server" style="margin-left: 74px"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="tbxContraseña" ControlToValidate="tbxRepetirContraseña" ErrorMessage="Las password no coinciden" ValidationGroup="grupo2"></asp:CompareValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbxRepetirContraseña" ErrorMessage="Campo Vacío" ValidationGroup="grupo2"></asp:RequiredFieldValidator>
        </p>
        <asp:Label ID="Label6" runat="server" Text="Correo Electronico:"></asp:Label>
        <asp:TextBox ID="txtCorreoElectronico" runat="server" style="margin-left: 74px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtCorreoElectronico" ErrorMessage="Mail no valido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="grupo2"></asp:RegularExpressionValidator>
        <p>
            <asp:Label ID="Label7" runat="server" Text="CP:"></asp:Label>
            <asp:TextBox ID="tbxCp" runat="server" style="margin-left: 167px" MaxLength="4"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCP" runat="server" ControlToValidate="tbxCp" ErrorMessage="Ingrese el codigo postal" ValidationGroup="grupo2"></asp:RequiredFieldValidator>
        </p>
        <asp:Label ID="Label8" runat="server" Text="Localidades:"></asp:Label>
        <asp:DropDownList ID="ddlLocalidades" runat="server" style="margin-left: 113px" Width="133px">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnGuardarUsuario" runat="server" style="margin-left: 185px" Text="Guardar Usuario" Width="148px" OnClick="btnGuardarUsuario_Click" ValidationGroup="grupo2" />
        <asp:Label ID="lblBienvenido" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnInicio" runat="server" Text="Ir a inicio.aspx" Width="103px" OnClick="btnInicio_Click" />
    </form>
</body>
</html>