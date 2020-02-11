<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmRegistrar.aspx.cs" Inherits="doemais.frmRegistrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Doe + | Registrar</title>
    <link rel="stylesheet" type="text/css" media="all" href="css/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" media="all" href="css/bootstrap.css" />
    <link rel="stylesheet" type="text/css" media="all" href="css/AdminLTE.css"/>
    <script type="text/javascript" src="js/bootstrap.min.js"></script>
    <script type="text/javascript" src="js/bootstrap.js"></script>
</head>
  <body class="login-page">
    <div class="login-box">
      <div class="login-logo">
        <a href="#">Doe<b> +</b></a>
      </div><!-- /.login-logo -->
      <div class="login-box-body">
        <p class="login-box-msg">Registre o seu usuário</p>
        <form runat="server">
          <div class="form-group has-feedback">
            <asp:TextBox ID="txtNome" CssClass="form-control" placeholder="Nome completo" maxlength="60" runat="server"></asp:TextBox>
            <span class="glyphicon glyphicon-user form-control-feedback"></span>
              <asp:RequiredFieldValidator ID="rqrNome" ControlToValidate="txtNome" runat="server" ErrorMessage="Preencha o seu nome!"></asp:RequiredFieldValidator>
          </div>
          <div class="form-group has-feedback">
              <asp:TextBox ID="txtemail" CssClass="form-control" TextMode="Email" runat="server" placeholder ="Email"></asp:TextBox>
            <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
              <asp:RegularExpressionValidator ID="rqrEmail" ControlToValidate="txtemail" ValidationExpression="^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$" runat="server" ErrorMessage="Email inválido!"></asp:RegularExpressionValidator>
          </div>
            <label>Tipo:</label>
          <div class="form-group has-feedback" >
              <asp:DropDownList ID="ddlTipo" CssClass="form-control" runat="server">
              </asp:DropDownList>
          </div>
            <label>Sangue:</label>
          <div class="form-group has-feedback" >
              <asp:DropDownList ID="ddlSangue" CssClass="form-control" runat="server">
              </asp:DropDownList>
          </div>
          <div class="form-group has-feedback" >
              <asp:DropDownList ID="ddlTipoSangue" CssClass="form-control" runat="server">
              </asp:DropDownList>
          </div>
            <label>Data de Nascimento</label>
          <div class="form-group" >
               <asp:TextBox ID="txtDataNascimento" CssClass="form-control" TextMode="Date" runat="server"></asp:TextBox>
          </div>
           <label>Última Doação</label>
          <div class="form-group" >
               <asp:TextBox ID="txtultimadoacao" CssClass="form-control" TextMode="Date" runat="server"></asp:TextBox>
          </div>
          <div class="form-group has-feedback">
               <asp:TextBox ID="txtSenha" CssClass="form-control" TextMode="Password" placeHolder="Senha" runat="server"></asp:TextBox>
            <span class="glyphicon glyphicon-lock form-control-feedback"></span>
          </div>
          <div class="form-group has-feedback">
            <asp:TextBox ID="txtRedigitarSenha" CssClass="form-control" TextMode="Password" placeHolder="Redigitar Senha" runat="server"></asp:TextBox>
            <span class="glyphicon glyphicon-lock form-control-feedback"></span>
            <asp:CompareValidator ID="rqrsenha" ControlToCompare="txtSenha" ControlToValidate="txtRedigitarSenha" runat="server" ErrorMessage="Senhas não conferem"></asp:CompareValidator>
          </div> 
            <div class="col-xs-8">    
            </div>
            <div class="col-xs-4">
                <asp:Button ID="btnRegistrar" CssClass="btn btn-primary btn-block btn-flat" runat="server" OnClick="btnRegistrar_Click" Text="Registrar" />
            </div><!-- /.col -->
            </form>
        
        <a href="frmLogin.aspx" class="text-center">Já possuo cadastro</a>
      </div>
        </div>
 
</body>
</html>
