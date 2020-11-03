<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CadastroUsuario.aspx.vb" Inherits="CamadaWeb.CadastroUsuario" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        </title>
    <style type="text/css">
        input { 
    text-align: right; 
}
                       
        .auto-style3 {
            text-align: center;
            width: 963px;
            border-radius: 5px;
            background-color: #f2f2f2;
            padding: 10px;
        }


        .auto-style4 {
            text-align: center;
            width: 953px;
            border-radius: 5px;
            background-color: #f2f2f2;
            padding: 10px;
        }
         div{
            width: 100px;
            height: 50px;
            align-self:center
            }

        
    </style>
</head>
<body style="height: 49px; width: 1005px; margin-left: 154px;">
    <form id="form1" runat="server">
        <div class="auto-style3">
            <h2>Cadastro </h2>
            <p>Seja Bem-vindo!</p>
            <div class="auto-style4">
        <asp:Label ID="Label1" runat="server" Text="Nome:"></asp:Label>
        <asp:TextBox ID="Textnome" runat="server" Width="172px"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Cpf:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" Width="155px"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Rg:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Nascimento:"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="E-mail:"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Senha:"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
            </div>
            <h2> Endereço:</h2>
            <div class="auto-style4">
        <asp:Label ID="Label7" runat="server" Text="Logradouro:"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label8" runat="server" Text="Bairro:"></asp:Label>
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label9" runat="server" Text="Numero:"></asp:Label>
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label10" runat="server" Text="Cep:"></asp:Label>
        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label11" runat="server" Text="Cidade:"></asp:Label>
        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label12" runat="server" Text="Estado:"></asp:Label>
        <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Cadastrar" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="Ja tenho Cadastro" />
            </div>
        </div>
    </form>
</body>
</html>
