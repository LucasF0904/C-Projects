<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="doemais.frmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Doe + | Página de Login</title>
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
        <p class="login-box-msg">Inicie a sua sessão</p>
        <form runat="server">
          <div class="form-group has-feedback">
              <asp:TextBox ID="txtEmail" CssClass="form-control" placeholder="Email" runat="server" TextMode="Email"></asp:TextBox>
            <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
          </div>
          <div class="form-group has-feedback">
              <asp:TextBox ID="txtSenha" CssClass="form-control" placeholder="Senha" TextMode="Password" runat="server"></asp:TextBox>
            <span class="glyphicon glyphicon-lock form-control-feedback"></span>
          </div>
          <div class="row">
            <div class="col-xs-8">                          
            </div>
            <div class="col-xs-4">
                <asp:Button ID="btnEntrar" Text="Entrar" OnClick="btnEntrar_Click" CssClass="btn btn-primary btn-block btn-flat" runat="server"/>
            </div><!-- /.col -->
		    </div>
         </form>
        <a href="#">Esqueci a minha senha</a><br/>
        <a href="frmRegistrar.aspx" class="text-center">Registrar um novo usuário</a>

      </div>
    </div>
</body>
</html>
