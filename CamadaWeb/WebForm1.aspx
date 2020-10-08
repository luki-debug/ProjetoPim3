<%@ Page Title="" Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="CamadaWeb.WebForm1" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title><%: Page.Title %> - My ASP.NET Application</title>

    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>

    <webopt:bundlereference runat="server" path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <link rel="stylesheet" href="fonts/font-awesome-4.7.0/css/font-awesome.min.css">

    <link href="Content/signin.css" rel="stylesheet" />
</head>
<body class="text-center">
    <form runat="server" class="form-signin" action="Default" >
        <asp:ScriptManager runat="server">
            <Scripts>
                <%--To learn more about bundling scripts in ScriptManager see https://go.microsoft.com/fwlink/?LinkID=301884 --%>
                <%--Framework Scripts--%>
                <asp:ScriptReference Name="MsAjaxBundle" />
                <asp:ScriptReference Name="jquery" />
                <asp:ScriptReference Name="bootstrap" />
                <asp:ScriptReference Name="WebForms.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebForms.js" />
                <asp:ScriptReference Name="WebUIValidation.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebUIValidation.js" />
                <asp:ScriptReference Name="MenuStandards.js" Assembly="System.Web" Path="~/Scripts/WebForms/MenuStandards.js" />
                <asp:ScriptReference Name="GridView.js" Assembly="System.Web" Path="~/Scripts/WebForms/GridView.js" />
                <asp:ScriptReference Name="DetailsView.js" Assembly="System.Web" Path="~/Scripts/WebForms/DetailsView.js" />
                <asp:ScriptReference Name="TreeView.js" Assembly="System.Web" Path="~/Scripts/WebForms/TreeView.js" />
                <asp:ScriptReference Name="WebParts.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebParts.js" />
                <asp:ScriptReference Name="Focus.js" Assembly="System.Web" Path="~/Scripts/WebForms/Focus.js" />
                <asp:ScriptReference Name="WebFormsBundle" />
                <%--Site Scripts--%>
            </Scripts>
        </asp:ScriptManager>

        <img class="mb-4" src="https://getbootstrap.com.br/docs/4.1/assets/brand/bootstrap-solid.svg" alt="" width="72" height="72"/>
        <h1 class="h3 mb-3 font-weight-normal">Faça login</h1>
        <label for="inputEmail" class="sr-only">Endereço de email</label>
        <input type="email" id="inputEmail" class="form-control" placeholder="Seu email" required="" autofocus=""/>
        <label for="inputPassword" class="sr-only">Senha</label>
        <input type="password" id="inputPassword" class="form-control" placeholder="Senha" required=""/>
        <div class="checkbox mb-3">
            <label>
                <input type="checkbox" value="remember-me"/>
                Manter conectado!
            </label>
            <br />
            <a href="#">Esqueci minha senha</a>
        </div>
        <button class="btn btn-lg btn-primary btn-block" type="submit">Entrar</button>
          <br />
            Ainda não tem uma conta?
                <br />
            <a href="#">
                Cadastra-se!
            </a>
    </form>
</body>
</html>