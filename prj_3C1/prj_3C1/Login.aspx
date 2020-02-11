<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="prj_3C1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Usuario
        <asp:TextBox ID="txtusuario" runat="server"></asp:TextBox>
        <asp:Button ID="btn_Logar" runat="server" Text="Logar" OnClick="btn_Logar_Click" />
    
    </div>
    </form>
</body>
</html>
