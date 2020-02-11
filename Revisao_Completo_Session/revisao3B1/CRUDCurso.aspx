<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CRUDCurso.aspx.cs" Inherits="revisao3B1.CRUDCurso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Codigo <asp:TextBox ID="txtcod_curso" runat="server"></asp:TextBox>
        <br />
        Conteudo <asp:DropDownList ID="txtcod_conteudo" runat="server"></asp:DropDownList>
        <br />
        Data inicio <asp:TextBox ID="txtdatainicio" runat="server"></asp:TextBox>
        <br />
        Duração <asp:TextBox ID="txtduracao" runat="server"></asp:TextBox>
        <br />
        Valor <asp:TextBox ID="txtvalor" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btn_inserir" runat="server" Text="inserir" OnClick="btn_inserir_Click" />
        <asp:Button ID="btn_alterar" runat="server" Text="alterar" OnClick="btn_alterar_Click" />
        <asp:Button ID="btn_excluir" runat="server" Text="excluir" OnClick="btn_excluir_Click" />
        
        <asp:GridView ID="GridView1" runat="server" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating"  >
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>

        </asp:GridView>

    
    </div>
    </form>
</body>
</html>
