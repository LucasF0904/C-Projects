<%@ Page Title="" Language="C#" MasterPageFile="~/Prinipal.Master" AutoEventWireup="true" CodeBehind="Pagina.aspx.cs" Inherits="SistemaControleDieta28.Pagina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblUsu" runat="server" Text=""></asp:Label><br />

    <asp:Button runat="server" ID="btnPerfilAli" CssClass="btn btn-default" Text="Perfil Alimentar" OnClick="btnPerfilAli_Click" ></asp:Button>&nbsp
    <asp:Button runat="server" ID="btnMeta_usu" CssClass="btn btn-default" Text="Meta Usuário" OnClick="btnMeta_usu_Click" ></asp:Button> &nbsp
    <asp:Button runat="server" ID="btnPerfil" CssClass="btn btn-default" Text="Perfil" OnClick="btnPerfil_Click" ></asp:Button>&nbsp
    <asp:Button runat="server" ID="btnPerfilAtivUsu" CssClass="btn btn-default" Text="Perfil de Atividades" OnClick="btnPerfilAtivUsu_Click" ></asp:Button>&nbsp
    <asp:Button runat="server" ID="btnAlimento" CssClass="btn btn-default" Text="Alimentos" OnClick="btnAlimento_Click" ></asp:Button>&nbsp
    <asp:Button runat="server" ID="btnNovaMeta" CssClass="btn btn-default" Text="Nova Meta" OnClick="btnNovaMeta_Click" ></asp:Button>&nbsp
    <asp:Button runat="server" ID="btnFeedBack" CssClass="btn btn-default" Text="FeedBack" OnClick="btnFeedBack_Click" ></asp:Button>&nbsp
</asp:Content>

