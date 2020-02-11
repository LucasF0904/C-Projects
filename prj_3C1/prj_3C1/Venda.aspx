<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Venda.aspx.cs" Inherits="prj_3C1.Venda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Bem vindo <asp:Label ID="lblusuario" runat="server" Text="Label"></asp:Label>
        
            
        Codigo Venda <asp:TextBox ID="txtcod_venda" runat="server"></asp:TextBox>
        <br />
        Vendedores&nbsp;&nbsp; <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        <br />
        Data Venda <asp:TextBox ID="txtdatavenda" TextMode="Date" runat="server"></asp:TextBox>        
        <br />
        Data Previsao Entrega <asp:TextBox ID="txtdatapreventrega" TextMode="Date" runat="server"></asp:TextBox>        
        <br />
        Total <asp:TextBox ID="txttotal" runat="server"></asp:TextBox>
        <br />
        Status <asp:TextBox ID="txtstatus" runat="server"></asp:TextBox>
        <br />
        Endereco Entrega <asp:TextBox ID="txtendereco" runat="server"></asp:TextBox>
        <br />
        Numero Cartao<asp:TextBox ID="txtcartao" runat="server"></asp:TextBox>
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
        <br />
        <asp:Button ID="btn_logout" runat="server" OnClick="btn_logout_Click" Text="Logout" />
    </div>    
    </form>
</body>
</html>
