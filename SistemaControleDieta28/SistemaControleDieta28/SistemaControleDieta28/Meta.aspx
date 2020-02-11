<%@ Page Title="" Language="C#" MasterPageFile="~/Prinipal.Master" AutoEventWireup="true" CodeBehind="Meta.aspx.cs" Inherits="SistemaControleDieta28.Meta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblNome" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="lblEmail" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="lblSenha" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="lblSexo" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="lblDtnasc" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="lblAltura" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="lblPeso" runat="server" Text=""></asp:Label><br />
    ID:
    <asp:TextBox ID="txtID" runat="server"></asp:TextBox><br />
    Descrição
    <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnSalvar" runat="server" Text="Salva ai Tio" OnClick="btnSalvar_Click" />
</asp:Content>
