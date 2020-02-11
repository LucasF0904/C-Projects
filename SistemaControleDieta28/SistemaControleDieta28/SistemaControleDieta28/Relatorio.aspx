<%@ Page Title="" Language="C#" MasterPageFile="~/Prinipal.Master" AutoEventWireup="true" CodeBehind="Relatorio.aspx.cs" Inherits="SistemaControleDieta28.Relatorio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="container-fluid">
	<div class="row" >
		<div class="col-md-2">	
                <h2> Relatorio</h2>		
            
              <div class="row">
              <div >
                <asp:DropDownList ID="ddlrela" runat="server">
                <asp:ListItem>Cardapio</asp:ListItem>                
                <asp:ListItem>Alimento</asp:ListItem>
                <asp:ListItem>Meta</asp:ListItem>
                <asp:ListItem>Meta Usuario</asp:ListItem>
                <asp:ListItem>Perfil Alimentar</asp:ListItem>
                <asp:ListItem>Perfil Atividades</asp:ListItem>
                <asp:ListItem>Tipo Refeicao</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="btn_pesquisar" runat="server" Text="Pesquisar" OnClick="btn_pesquisar_Click" />
        </div>    
				    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
         </div>
    </div>
    </div>
</asp:Content>
