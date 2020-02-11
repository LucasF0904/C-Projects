<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tbl_remedio.aspx.cs" Inherits="Provinha.tbl_remedio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="cod_remedio:"></asp:Label><asp:TextBox ID="tbl_codRemedio" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="nome_remedio:"></asp:Label><asp:TextBox ID="tblNome_remedio" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label3" runat="server" Text="descricao_remedio:"></asp:Label><asp:TextBox ID="tblDescricao_remedio" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label4" runat="server" Text="principioativo remedio:"></asp:Label>
        <asp:DropDownList ID="txtprincipioativo" runat="server" Width="127px">
            <asp:ListItem>Generico</asp:ListItem>
            <asp:ListItem>Derivados</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label5" runat="server" Text="cod_laboratorio:"></asp:Label><asp:TextBox ID="tblCod_laboratorio" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label6" runat="server" Text="quantidade_remedio:"></asp:Label><asp:TextBox ID="tblQuantidade_remedio" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label7" runat="server" Text="valor_remedio:"></asp:Label><asp:TextBox ID="tblValor_remedio" runat="server"></asp:TextBox><br /><br />

                <asp:Button ID="btn_inserir" runat="server" Text="inserir" OnClick="btn_inserir_Click" />
        <asp:Button ID="btn_alterar" runat="server" Text="alterar" OnClick="btn_alterar_Click" />
        <asp:Button ID="btn_excluir" runat="server" Text="excluir" OnClick="btn_excluir_Click" />
        
        

        <asp:GridView ID="GridView1" runat="server" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView> 
        <br />
   
    </div>
    </form>
</body>
</html>
