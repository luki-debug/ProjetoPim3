<%@ Page Title="About" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroDeAlgumaCoisa.aspx.vb" Inherits="CamadaWeb.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="Content" runat="server">
    <h2>Cadastro de Cliente</h2>
    <asp:Label ID="Label1" runat="server" Text="Nome:" AssociatedControlID="TextBox1" ></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

    <asp:Button ID="Button1" runat="server" Text="Button" CssClass="btn btn-primary"/>
</asp:Content>
