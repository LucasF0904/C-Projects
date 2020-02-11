<%@ Page Title="" Language="C#" MasterPageFile="~/Prinipal.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="SistemaControleDieta28.Perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2><%: Title %>.</h2>
    <div class="form-horizontal">
        <h4>Perfil.</h4>
        ID:<asp:TextBox ID="txtID" runat="server" CssClass=" control-label col-md-pull-12"></asp:TextBox><br />
        Nome:<asp:TextBox ID="txtNome" runat="server"></asp:TextBox><br />
        Email:<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br />
        Senha:<asp:TextBox ID="txtSenha" runat="server"></asp:TextBox><br />
        Sexo:<asp:RadioButton ID="rdb_Masc" Text="Masculino" GroupName="sexo" runat="server" />
             <asp:RadioButton ID="rdb_Fem" Text="Feminio" GroupName="sexo" runat="server" /></div><br />
        Data Nascimento:<asp:TextBox ID="txtdtnasc" runat="server"></asp:TextBox><br />
        Altura:<asp:TextBox ID="txtAltura" runat="server"></asp:TextBox><br />
        Peso:<asp:TextBox ID="txtPeso" runat="server"></asp:TextBox><br />
        <asp:Button ID="BtnAlterar" runat="server" Text="Alterar" OnClick="BtnAlterar_Click" /><br />

     
</asp:Content>
