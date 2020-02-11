<%@ Page Title="" Language="C#" MasterPageFile="~/Prinipal.Master" AutoEventWireup="true" CodeBehind="Cardapio.aspx.cs" Inherits="SistemaControleDieta28.Cardapio" %>
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
                    <asp:TextBox  runat="server" TextMode="SingleLine" CssClass="form-control" id="txttipo"  />
				</div>
            	<div class="form-group">					 
					<asp:Label runat="server" >
						Usuario:
					</asp:Label>
                        <asp:TextBox runat="server" TextMode="SingleLine" CssClass="form-control" id="txtusuario" />
				</div>
            	<div class="form-group">					 
					<asp:Label runat="server" >
						Alimento:
					</asp:Label>
					<asp:TextBox runat="server" TextMode="SingleLine" CssClass="form-control" id="txtalimento"  />
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
        <br />
    <div class="row">
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>
    </div>
    
    </div>

</asp:Content>
