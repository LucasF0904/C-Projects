<%@ Page Title="" Language="C#" MasterPageFile="~/Prinipal.Master" AutoEventWireup="true" CodeBehind="AlimentoRUD.aspx.cs" Inherits="SistemaControleDieta28.AlimentoRUD" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:Label ID="lblNome" runat="server" Text=""></asp:Label>&nbsp
    <asp:Label ID="lblEmail" runat="server" TextMode="email"></asp:Label><br />
    <asp:Label ID="lblSenha" runat="server" TextMode="password"></asp:Label><br />
    <asp:Label ID="lblSexo" runat="server" Text=""></asp:Label>&nbsp
    <asp:Label ID="lblDtnasc" runat="server" TextMode="date"></asp:Label><br />
    <asp:Label ID="lblAltura" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="lblPeso" runat="server" Text=""></asp:Label><br />
    
    <asp:GridView ID="GridVerMet" runat="server" OnRowEditing="GridVerMet_RowEditing" OnRowUpdating="GridVerMet_RowUpdating">
        <Columns>
            <asp:CommandField ShowEditButton="True" />
        </Columns>
     </asp:GridView>
</asp:Content>
