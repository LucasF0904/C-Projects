<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="crudCurso.aspx.cs" Inherits="revisaoPOO.crudCurso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
    <div>
       cod_curso: <asp:TextBox ID="cod_curso" runat="server"></asp:TextBox><br/>
        cod_conteudo:<asp:DropDownList ID="cod_conteudo" runat="server">
        </asp:DropDownList>
        <br/>
        dataInicio_curso: <asp:TextBox ID="dataInicio_curso" runat="server"></asp:TextBox><br/>
        duracao do curso: <asp:TextBox ID="duracao_curso" runat="server"></asp:TextBox><br/>
        
        valor_curso:<asp:TextBox ID="valor_curso" runat="server"></asp:TextBox><br/>
        <asp:Button ID="Alterar" runat="server" Text="alterar" OnClick="Alterar_Click" />
        <asp:Button ID="Inserir" runat="server" Text="Inserir" OnClick="Inserir_Click" />
        <asp:Button ID="Excluir" runat="server" Text="Excluir" OnClick="Excluir_Click" />
        <asp:GridView ID="GridView1" runat="server" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    </div>
        
    </form>
</body>
</html>
