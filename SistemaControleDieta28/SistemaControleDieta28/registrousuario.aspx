<%@ Page Title="" Language="C#" MasterPageFile="~/Prinipal.Master" AutoEventWireup="true" CodeBehind="registrousuario.aspx.cs" Inherits="SistemaControleDieta28.registrousuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    ID:<asp:TextBox ID="txtID" runat="server"></asp:TextBox><br />
    Nome:<asp:TextBox ID="txtNome" runat="server"></asp:TextBox><br />
    EMail:<asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox><br />
    Senha:<asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox><br />
    Sexo:<asp:DropDownList ID="txtSexo" runat="server">
        <asp:ListItem Value="m">Masculino</asp:ListItem>
        <asp:ListItem Value="f"> Feminino</asp:ListItem>
         </asp:DropDownList>
    Data nascimento:<asp:TextBox ID="txtDTNasc" runat="server" TextMode="date" ></asp:TextBox><br />
    Altura:<asp:TextBox ID="txtAltura" runat="server"></asp:TextBox><br />
    Peso:<asp:TextBox ID="txtPeso" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" /><br />

</asp:Content>