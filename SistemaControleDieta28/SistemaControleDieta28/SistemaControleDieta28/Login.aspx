<%@ Page Title="" Language="C#" MasterPageFile="~/Prinipal.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SistemaControleDieta28.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>&nbsp;</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>    

    <div class="form-horizontal">
        <h4>Autenticação Usuario</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtEmail" CssClass="col-md-2 control-label">Email</asp:Label>
            <div class="col-md-10">
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" size ="30"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtEmail"
                    CssClass="text-danger" ErrorMessage="Email Obrigatorio." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtSenha" CssClass="col-md-2 control-label">Senha</asp:Label>
            <div class="col-md-10">
                <asp:TextBox ID="txtSenha" runat="server" CssClass="form-control" size ="30" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtSenha"
                    CssClass="text-danger" ErrorMessage="senha Obrigatoria." />
            </div>
        </div>        
        </div>
            <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button ID="btnLogar" runat="server" Text="Logar" CssClass="btn btn-default" OnClick="btnLogar_Click"/>
            </div>
        </div>    
    </asp:Content>
