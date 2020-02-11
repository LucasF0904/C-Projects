<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroVendedor.aspx.cs" Inherits="SystoqueWEB.CadastroVendedor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Matricula<asp:TextBox ID="txtmatricula" runat="server"></asp:TextBox>
        <br />
        Nome:<asp:TextBox ID="txtnome" runat="server"></asp:TextBox>
        <br />
        Data Nascimento:<asp:TextBox ID="txtdatanasc" runat="server"></asp:TextBox>
        <br />
        Comissao:<asp:TextBox ID="txtcomissao" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btn_Inserir" runat="server" Text="Cadastrar" />
        <asp:Button ID="btn_Alterar" runat="server" Text="Alterar" />
        <asp:Button ID="btn_Excluir" runat="server" Text="Excluir" />
        <asp:Button ID="btn_Visualizar" runat="server" Text="Visualizar Todos" />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
