<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastraVenda.aspx.cs" Inherits="Projeto.CadastraVenda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        
    <div>Bem Vindo,
        <asp:Label ID="lblusuario" runat="server" Text="Label"><br/></asp:Label><asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList><br/>
        Código Remédio:<asp:TextBox ID="txtcodremedio" runat="server"></asp:TextBox>
         <br/>
        Nome Remédio:<asp:TextBox ID="txtnomeremedio" runat="server" TextMode="Date"></asp:TextBox> 
        <br/>
        Descrição Remédio:<asp:TextBox ID="txtdescremedio" runat="server" TextMode="Date"></asp:TextBox>
         <br/>
        Principio ativo Remédio:<asp:TextBox ID="txtprinatvremedio" runat="server"></asp:TextBox>
         <br/>
        Código Laborátorio:<asp:TextBox ID="txtcodlab" runat="server"></asp:TextBox>
         <br/>
        Quantidade de Remédio:<asp:TextBox ID="txtqtdremedio" runat="server"></asp:TextBox>
         <br/>
        Valor de Remédio:<asp:TextBox ID="txtvalorremedio" runat="server"></asp:TextBox>
         <br/>
        <asp:Button ID="Cadastrar" runat="server" Text="Cadastrar" OnClick="Cadastrar_Click" />
         
        <asp:Button ID="visualizar" runat="server" Text="Visualizar" OnClick="Visualizar_Click" />
         <br/>
        <asp:Button ID="Alterar" runat="server" Text="Alterar" OnClick="Alterar_Click" />
        
        <asp:Button ID="Deletar" runat="server" Text="Deletar" OnClick="Deletar_Click" />
       
        <asp:Button ID="Pesquisar" runat="server" Text="Pesquisar" OnClick="Pesquisar_Click" />
    </div>
        <asp:GridView ID="GDVenda" runat="server" OnRowUpdating="GridView1_RowUpdating" Width="397px" OnRowDeleting="GDVenda_RowDeleting" OnRowEditing="GDVenda_RowEditing">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
            
        </asp:GridView>
        <asp:Button runat="server" Text="Logout" OnClick="Unnamed1_Click" style="height: 26px" />
    </form>
</body>
</html>
