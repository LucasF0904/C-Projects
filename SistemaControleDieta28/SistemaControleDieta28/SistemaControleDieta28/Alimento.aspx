<%@ Page Title="" Language="C#" MasterPageFile="~/Prinipal.Master" AutoEventWireup="true" CodeBehind="Alimento.aspx.cs" Inherits="SistemaControleDieta28.Alimento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
	<div class="row" >
		<div class="col-md-2">	
                <h2> Registrar Alimento</h2>		
				<div class="form-group">					 
					<asp:Label runat="server" >
						Nome:
					</asp:Label>
					<asp:TextBox runat="server" TextMode="SingleLine" CssClass="form-control" id="txtnome" placeholder="Nome completo" />
				</div>
            	<div class="form-group">					 
					<asp:Label runat="server" >
						Calorias:
					</asp:Label>
					<asp:TextBox runat="server" TextMode="Email" CssClass="form-control" id="txtcalorias" placeholder="Email" />
				</div>
            	<div class="form-group">					 
					<asp:Label runat="server" >
						Porção em Gramas:
					</asp:Label>
					<asp:TextBox runat="server" TextMode="Password" CssClass="form-control" id="txtporcaogramas"  />
				</div>
				<div class="form-group">					 
					<asp:Label runat="server" >
						ID:
					</asp:Label>
					<asp:TextBox runat="server" TextMode="Date" CssClass="form-control" id="txtid" />
				</div>
				
				
				<asp:Button runat="server" ID="btnCadastrar" CssClass="btn btn-default" Text="Registrar" OnClick="btnCadastrar_Click">					
				</asp:Button>                                		
		</div>
	</div>
</div>
</asp:Content>
