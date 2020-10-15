<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="RecuperarSenha.aspx.vb" Inherits="CamadaWeb.RecuperarSenha" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Recuperar Senha</title>

    <webopt:bundlereference runat="server" path="~/Content/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="content-sem-menu">
            <h2>Recuperar Senha</h2>
            <asp:Label ID="Label1" runat="server" Text="E-mail:" AssociatedControlID="email" ></asp:Label>
            <asp:TextBox ID="email" runat="server"></asp:TextBox>

            <asp:Button ID="Button1" runat="server" Text="Confirmar" CssClass="btn btn-primary" OnClick="Button1_Click"/>
        </div>
    </form>
</body>
</html>
