<%@ Page Title="Logar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ECommerce.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
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
                <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtEmail"
                    CssClass="text-danger" ErrorMessage="Email Obrigatorio." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtSenha" CssClass="col-md-2 control-label">Senha</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtSenha" CssClass="form-control" />
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
