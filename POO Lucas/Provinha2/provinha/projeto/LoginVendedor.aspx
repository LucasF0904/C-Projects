<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginVendedor.aspx.cs" Inherits="Projeto.LoginVendedor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:Label ID="lblVendedor" runat="server" Text="Código Vendedor:"></asp:Label>
        <asp:TextBox ID="txtVendedor" runat="server"></asp:TextBox>
        <asp:Button ID="btnVendedor" runat="server" Text="Logar" OnClick="btnVendedor_Click" />
    </div>
    </form>
</body>
</html>
