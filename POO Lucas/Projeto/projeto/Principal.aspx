<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Projeto.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
    <div>
    <asp:Button ID="btnCliente" runat="server" Text="Cliente" OnClick="btnCliente_Click" />
    <asp:Button ID="btnItemVenda" runat="server" Text="Item Venda" OnClick="btnItemVenda_Click" Width="102px" />&nbsp&nbsp
    &nbsp&nbsp
    <asp:Button ID="btnProduto" runat="server" Text="Produto" OnClick="btnProduto_Click" />&nbsp&nbsp
    <asp:Button ID="btnVendedor" runat="server" Text="Vendedor" OnClick="btnVendedor_Click" />&nbsp&nbsp
    <asp:Button ID="btnVenda" runat="server" Text="Venda" OnClick="btnVenda_Click" />&nbsp&nbsp

    </div>
    </form>
</body>
</html>
