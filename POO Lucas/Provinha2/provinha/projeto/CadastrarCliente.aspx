<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastrarCliente.aspx.cs" Inherits="Projeto.CadastrarCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    ID Cliente:
    <asp:textbox ID= "txtID" runat="server"></asp:textbox>
    <br />
    Nome:
    <asp:textbox ID= "txtNome" runat="server"></asp:textbox>
    <br />
    Identidade:
    <asp:textbox ID= "txtIdentidade" runat="server"></asp:textbox>
    <br />
    CPF:
    <asp:textbox ID= "txtCPF" runat="server"></asp:textbox>
    <br />
     Rua:
    <asp:textbox ID= "txtRua"  runat="server"></asp:textbox>
     <br />
    Número:
    <asp:textbox ID= "txtNumero" runat="server"></asp:textbox>
    <br />
    Bairro:
    <asp:textbox ID= "txtBairro" runat="server"></asp:textbox>
    <br />
    Cidade:
    <asp:textbox ID= "txtCidade" runat="server"></asp:textbox>
    <br />
    Estado:
    <asp:textbox ID= "txtEstado" runat="server"></asp:textbox>
    <br />
    Telefone:
    <asp:textbox ID= "txtTelefone" runat="server"></asp:textbox>
    <br />
             <br/>
        <asp:Button ID="Cadastrar" runat="server" Text="Cadastrar" OnClick="Cadastrar_Click" />
         
        <asp:Button ID="visualizar" runat="server" Text="Visualizar" OnClick="visualizar_Click1" />
         <br/>
        <asp:Button ID="Alterar" runat="server" Text="Alterar" />
        
        <asp:Button ID="Deletar" runat="server" Text="Deletar" />
        <asp:GridView ID="GDItemVenda" runat="server" OnSelectedIndexChanged="GDItemVenda_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        <asp:Button ID="Pesquisar" runat="server" Text="Pesquisar" />
    
    </div>
    </form>
</body>
</html>
