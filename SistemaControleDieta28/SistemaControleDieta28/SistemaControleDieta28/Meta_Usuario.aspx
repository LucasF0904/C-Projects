<%@ Page Title="" Language="C#" MasterPageFile="~/Prinipal.Master" AutoEventWireup="true" CodeBehind="Meta_Usuario.aspx.cs" Inherits="SistemaControleDieta28.Meta_Usuario" %>
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
    <asp:GridView ID="GridVerMet" runat="server" OnSelectedIndexChanged="GridVerMet_SelectedIndexChanged" CssClass ="table table-responsive table-hover"></asp:GridView>

</asp:Content>
