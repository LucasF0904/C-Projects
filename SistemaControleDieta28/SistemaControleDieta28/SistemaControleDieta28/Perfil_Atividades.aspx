<%@ Page Title="" Language="C#" MasterPageFile="~/Prinipal.Master" AutoEventWireup="true" CodeBehind="Perfil_Atividades.aspx.cs" Inherits="SistemaControleDieta28.Perfil_Atividades" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblID" runat="server" Text="ID:"></asp:Label><br />
    <asp:TextBox ID="txtID" runat="server" CssClass="form-control"></asp:TextBox><br />
    <asp:Label ID="lblIDUsuario" runat="server" Text="ID Usuario:"></asp:Label><br />
    <asp:TextBox ID="txtIdusuario" runat="server" CssClass="form-control"></asp:TextBox><br />
    <asp:Label ID="lblfrequencia_semanal" runat="server" Text="Frequencia Semanal"></asp:Label><br />
    <asp:TextBox ID="txtfrequencia_semanal" runat="server" CssClass="form-control"></asp:TextBox><br />
    <asp:Label ID="lblIntensidade" runat="server" Text="Intensidade"></asp:Label><br />
    <asp:TextBox ID="txtintensidade" runat="server" CssClass="form-control"></asp:TextBox><br />
    <asp:Label ID="lblmediacaloriasemana" runat="server" Text="Media Queima Calorias por Semana"></asp:Label><br />
    <asp:TextBox ID="txtmedia_caloria_semana" runat="server" CssClass="form-control"></asp:TextBox><br />
    <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" />
</asp:Content>
