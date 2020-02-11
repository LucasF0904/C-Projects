<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastroVendedor.aspx.cs" Inherits="prj_3C1.cadastroVendedor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Matricula <asp:TextBox ID="txtmatricula" runat="server"></asp:TextBox>
        <br />
        Nome <asp:TextBox ID="txtnome" runat="server"></asp:TextBox>
        <br />
        Data Nascimento<asp:TextBox ID="txtdatanasc" runat="server"></asp:TextBox>
        <br />
        Comissao<asp:TextBox ID="txtcomissao" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btn_Inserir" runat="server" Text="Inserir" OnClick="btn_Inserir_Click" />
        <asp:Button ID="btn_Alterar" runat="server" Text="Alterar" OnClick="btn_Alterar_Click" />
        <asp:Button ID="btn_Excluir" runat="server" Text="Excluir" OnClick="btn_Excluir_Click" />
        <asp:Button ID="btn_Visualizar" runat="server" Text="Visualizar Tudo" OnClick="btn_Visualizar_Click" />
        <asp:GridView ID="GridView1" runat="server" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowDeleting="GridView1_RowDeleting" OnRowUpdating="GridView1_RowUpdating" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
