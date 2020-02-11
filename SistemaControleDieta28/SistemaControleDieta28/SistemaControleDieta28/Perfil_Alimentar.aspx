<%@ Page Title="" Language="C#" MasterPageFile="~/Prinipal.Master" AutoEventWireup="true" CodeBehind="Perfil_Alimentar.aspx.cs" Inherits="SistemaControleDieta28.Perfil_Alimentar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblID" runat="server" Text="ID:"></asp:Label><br />
    <asp:TextBox ID="txtID" runat="server" CssClass="form-control"></asp:TextBox><br />
    <asp:Label ID="lblIDUsuario" runat="server" Text="ID Usuario:"></asp:Label><br />
    <asp:TextBox ID="txtIdusuario" runat="server" CssClass="form-control"></asp:TextBox><br />
    <asp:Label ID="lblqtde_refeicoes_dia" runat="server" Text="Quantidade de Refeições por Dia"></asp:Label><br />
    <asp:TextBox ID="txtqtde_refeicoes_dia" runat="server" CssClass="form-control"></asp:TextBox><br />
    <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" />
</asp:Content>
