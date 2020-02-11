<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="revisao3B1.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
    <div>
        
    </div>
        <asp:TextBox ID="txtvalor" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtsenha" runat="server"></asp:TextBox>
        <asp:Button ID="btn_armazenarSession" runat="server" Text="Armazenar Session" OnClick="btn_armazenarSession_Click" />
    </form>
</body>
</html>
