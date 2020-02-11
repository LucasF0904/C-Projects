<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastrarVendedor.aspx.cs" Inherits="Projeto.CadastrarVendedor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Código:<asp:TextBox ID="txtCodigo" runat="server" Width="143px"></asp:TextBox>
        <br />
        Nome:<asp:TextBox ID="txtNome" runat="server" Width="148px"></asp:TextBox>
        <br />
        Rua:<asp:TextBox ID="txtRua" runat="server" Width="161px"></asp:TextBox>
        <br />
        Número:<asp:TextBox ID="txtNumero" runat="server" Width="135px"></asp:TextBox>
        <br />
        Telefone:<asp:TextBox ID="txtTelefone" runat="server" Width="133px"></asp:TextBox>
        <br />
        Bairro:<asp:TextBox ID="txtBairro" runat="server" Width="147px"></asp:TextBox>
        <br />
        Logradouro:<asp:TextBox ID="txtLogradouro" runat="server" Width="112px"></asp:TextBox>
        <br />
        Cidade:<asp:TextBox ID="txtCidade" runat="server" Width="140px"></asp:TextBox>
        <br />
        Estado:<asp:TextBox ID="txtEstado" runat="server" Width="141px"></asp:TextBox>
        <br />
        Data de Nascimento:<asp:TextBox ID="txtdtnasc" runat="server" TextMode="Date"></asp:TextBox>
        <br />
        Comissão:<asp:TextBox ID="txtComissao" runat="server" Width="123px"></asp:TextBox>
        <br />
        <asp:Button ID="Cadastrar" runat="server" Text="Cadastrar" OnClick="Cadastrar_Click" />
        
        <asp:Button ID="visualizar" runat="server" Text="Visualizar" OnClick="Visualizar_Click" />
        
        <asp:Button ID="Alterar" runat="server" Text="Alterar" OnClick="Alterar_Click" />
        
        <asp:Button ID="Deletar" runat="server" Text="Deletar" OnClick="Deletar_Click" />
        <asp:Button ID="Pesquisar" runat="server" Text="Pesquisar" OnClick="Pesquisar_Click" />
        <asp:GridView ID="GDVendedor" runat="server" OnRowDeleting="GDVendedor_RowDeleting" OnRowEditing="GDVendedor_RowEditing" OnRowUpdating="GDVendedor_RowUpdating">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
