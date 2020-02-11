<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastrarItensVenda.aspx.cs" Inherits="Projeto.CadastrarItensVenda" %>

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
    <div>
    Código Laborátorio:
    <asp:textbox ID= "txtcodlab" runat="server"></asp:textbox>
    <br />
    Nome Laborátorio:
    <asp:textbox ID= "txtnomelab" runat="server"></asp:textbox>
    <br />
     Código Técinico Laborátorio:
    <asp:textbox ID= "txtcodteclab"  runat="server"></asp:textbox>
     <br />
             <br/>
        <asp:Button ID="Cadastrar" runat="server" Text="Cadastrar" OnClick="Cadastrar_Click" />
         
        <asp:Button ID="visualizar" runat="server" Text="Visualizar" OnClick="Visualizar_Click" />
         <br/>
        <asp:Button ID="Alterar" runat="server" Text="Alterar" OnClick="Alterar_Click" />
        
        <asp:Button ID="Deletar" runat="server" Text="Deletar" OnClick="Deletar_Click" />
        <asp:GridView ID="GDItemVenda" runat="server" OnRowDeleting="GDItemVenda_RowDeleting" OnRowEditing="GDItemVenda_RowEditing" OnRowUpdating="GDItemVenda_RowUpdating">
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
