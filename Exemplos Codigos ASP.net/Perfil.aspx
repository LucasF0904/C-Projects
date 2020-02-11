<%@ Page Title="Perfil" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="ECommerce.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <div class="form-horizontal">
        <h4>Perfil.</h4>
        <hr />
        <asp:GridView ID="GridUsuario" runat="server" CssClass="table" OnRowCancelingEdit="GridUsuario_RowCancelingEdit" OnRowEditing="GridUsuario_RowEditing" OnRowUpdating="GridUsuario_RowUpdating">
            <EmptyDataTemplate>
                Você não Está Logado. <a href="Registrar.aspx">Registrar-se</a> ou <a href="Login.aspx">Logar</a>
            </EmptyDataTemplate>
            <Columns>
                <asp:CommandField ShowEditButton="True" />
            </Columns>
        </asp:GridView>
     </div>
</asp:Content>
