<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Projeto.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Usuário:
    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnLogar" runat="server" Text="Logar" OnClick="btnLogar_Click" />
    </div>
    </form>
    
</body>
</html>
