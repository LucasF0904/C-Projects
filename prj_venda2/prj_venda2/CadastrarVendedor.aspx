<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastrarVendedor.aspx.cs" Inherits="prj_venda2.CadastrarVendedor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Matricula
        <asp:TextBox ID="txtMatricula" runat="server"></asp:TextBox>
        <br />
       Nome <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        <br />
        sexo <asp:TextBox ID="txtSexo" runat="server"></asp:TextBox>
        <br />
         Telefone: <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
        <br />
       Data Nascimento <asp:TextBox ID="txtDatanasc" runat="server"></asp:TextBox>
        <br />
         Logradouro: <asp:TextBox ID="txtRua" runat="server"></asp:TextBox>
        <br />
         Bairro:<asp:TextBox ID="txtBairro" runat="server"></asp:TextBox>
        <br />
         cep: <asp:TextBox ID="txtCep" runat="server"></asp:TextBox>
        <br />
         Cidade: <asp:TextBox ID="txtCidade" runat="server"></asp:TextBox>
        <br />
         Complemento: <asp:TextBox ID="txtComplemento" runat="server"></asp:TextBox>
        <br />
        Numero da casa: <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
        <br />
        Comissao<asp:TextBox ID="txtComissao" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btn_Inserir" runat="server" Text="Cadastrar" OnClick="btn_Inserir_Click1" />
        <asp:Button ID="btn_Pesquisa" runat="server" Text="Pesquisar" OnClick="btn_Pesquisa_Click" />
        <asp:Button ID="btn_Alterar" runat="server" Text="Alterar" OnClick="btn_Alterar_Click" />
        <asp:Button ID="btn_Excluir" runat="server" Text="Excluir" OnClick="btn_Excluir_Click" />

    </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
