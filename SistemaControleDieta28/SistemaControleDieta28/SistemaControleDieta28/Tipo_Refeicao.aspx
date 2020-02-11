<%@ Page Title="" Language="C#" MasterPageFile="~/Prinipal.Master" AutoEventWireup="true" CodeBehind="Tipo_Refeicao.aspx.cs" Inherits="SistemaControleDieta28.Tipo_Refeicao" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblID" runat="server" Text="ID"></asp:Label><br />
    <asp:TextBox ID="txtID" runat="server" CssClass="form-control" ></asp:TextBox><br />
    <asp:Label ID="lblDescricao" runat="server" Text="Descricao"></asp:Label><br />
    <asp:TextBox ID="txtDescricao" runat="server" CssClass="form-control" placeholder="Descricao"></asp:TextBox><br />
    <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" />

</asp:Content>
