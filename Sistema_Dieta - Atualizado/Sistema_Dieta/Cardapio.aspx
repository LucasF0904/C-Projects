<%@ Page Title="" Language="C#" MasterPageFile="~/Dieta.Master" AutoEventWireup="true" CodeBehind="Cardapio.aspx.cs" Inherits="Sistema_Dieta.Cardapio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
	<div class="row" >
		<div class="col-md-2">	
                <h2> Cardapio</h2>		
				<div class="form-group">					 
					<asp:Label runat="server" >
						Tipo Refeição:
					</asp:Label>
					<asp:DropDownList CssClass="form-control" id="txttipo" runat="server"></asp:DropDownList>					
				</div>
            	<div class="form-group">					 
					<asp:Label runat="server" >
						Alimento:
					</asp:Label>
                    <asp:DropDownList CssClass="form-control" id="txtalimento" runat="server"></asp:DropDownList>					
				</div>
                <div class="form-group">					 
					<asp:Label runat="server" >
						Porções:
					</asp:Label>
					<asp:TextBox runat="server" TextMode="SingleLine" CssClass="form-control" id="txtporcao"  />
				</div>	
			
				<asp:Button runat="server" ID="btnCadastrar" CssClass="btn btn-default" Text="Registrar" OnClick="btnCadastrar_Click">					
				</asp:Button>
            </div>
        </div>                                    		
    
    <div class="row">
        <div >
            <asp:DropDownList ID="ddlCampo" runat="server">
                <asp:ListItem>id_tipo_refeicao</asp:ListItem>                
                <asp:ListItem>id_alimento</asp:ListItem>
                <asp:ListItem>porcao</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="txtpesquisa" runat="server"></asp:TextBox>
            <asp:Button ID="btn_pesquisar" runat="server" Text="Pesquisar" OnClick="btn_pesquisar_Click" />
        </div>        
        <table>
            <tr>
                <td>
                    <asp:GridView ID="GridView1" runat="server">
                        <Columns>
                            <asp:CommandField ShowEditButton="True" />
                        </Columns>
                    </asp:GridView>
                </td>                
                <td>
                    Ordenar Por
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                        <asp:ListItem Selected="True">id</asp:ListItem>
                        <asp:ListItem >id_tipo_refeicao</asp:ListItem>
                        <asp:ListItem>id_alimento</asp:ListItem>
                        <asp:ListItem>porcao</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
        </table>
    </div>
    
    </div>

</asp:Content>
