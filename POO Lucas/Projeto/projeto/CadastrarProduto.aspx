<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastrarProduto.aspx.cs" Inherits="Projeto.CadastrarProduto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Código de Barra:
    <asp:textbox ID= "txtcb" runat="server"></asp:textbox>
    <br />
    Nome do Produto:
    <asp:textbox ID= "txtnomeprod" runat="server"></asp:textbox>
    <br />
     Valor da Venda:
    <asp:textbox ID= "txtvalorvenda"  runat="server"></asp:textbox>
     <br />
    Quantidade de Produto:
    <asp:textbox ID= "txtqtdeprod" runat="server"></asp:textbox>
    <br />
    Quantidade Minima de Produto:
    <asp:textbox ID= "txtqtdeminprod" runat="server"></asp:textbox>
    <br />
    Data de Validade:
    <asp:textbox ID= "txtDataValidade" runat="server" TextMode="Date"></asp:textbox>
    <br />
    Prazo de Garantia:
    <asp:textbox ID= "txtprazogarantia" runat="server"></asp:textbox>
    <br />
    Lote:
    <asp:textbox ID= "txtLote" runat="server"></asp:textbox>
    <br />
             <br/>
        <asp:Button ID="Cadastrar" runat="server" Text="Cadastrar" OnClick="Cadastrar_Click" />
         
        <asp:Button ID="visualizar" runat="server" Text="Visualizar" OnClick="Visualizar_Click" />
         <br/>
        <asp:Button ID="Alterar" runat="server" Text="Alterar" OnClick="Alterar_Click" />
        
        <asp:Button ID="Deletar" runat="server" Text="Deletar" OnClick="Deletar_Click" />
        <asp:Button ID="Pesquisar" runat="server" Text="Pesquisar" OnClick="Pesquisar_Click" />
        <asp:GridView ID="GDProduto" runat="server" OnRowDeleting="GDProduto_RowDeleting" OnRowEditing="GDProduto_RowEditing" OnRowUpdating="GDProduto_RowUpdating">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>

