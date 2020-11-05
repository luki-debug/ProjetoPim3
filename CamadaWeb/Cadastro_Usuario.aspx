<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Cadastro_Usuario.aspx.vb" Inherits="CamadaWeb.Cadastro_Usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style3 {
            height: 21px;
            text-align: center;
        }
    </style>
</head>
<body style="height: 422px">
    <form id="form1" runat="server">
       <h2 class="auto-style1"> Cadastro</h2>
        <p class="auto-style3">
            Nome:<asp:TextBox ID="TextBox1" runat="server" Width="208px"></asp:TextBox>
       
        <p class="auto-style3">
            CPF:<asp:TextBox ID="TextBox2" runat="server" Width="208px"></asp:TextBox>
       
        </form>
</body>
</html>
