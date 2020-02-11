<%@ Page Title="" Language="C#" MasterPageFile="~/Dieta.Master" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="Sistema_Dieta.registrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
	<div class="row" >
		<div class="col-md-2">	
                <h2> Registre-se</h2>		
				<div class="form-group">					 
					<asp:Label runat="server" >
						Nome:
					</asp:Label>
					<asp:TextBox runat="server" TextMode="SingleLine" CssClass="form-control" id="txtnome" placeholder="Nome completo" />
				</div>
            	<div class="form-group">					 
					<asp:Label runat="server" >
						Email:
					</asp:Label>
					<asp:TextBox runat="server" TextMode="Email" CssClass="form-control" id="txtemail" placeholder="Email" />
				</div>
            	<div class="form-group">					 
					<asp:Label runat="server" >
						Senha:
					</asp:Label>
					<asp:TextBox runat="server" TextMode="Password" CssClass="form-control" id="txtsenha"  />
				</div>
				<div class="form-group">					 
					<asp:Label runat="server" >
						Confirme a senha:
					</asp:Label>
					<asp:TextBox runat="server" TextMode="Password" CssClass="form-control" id="txtsenha2"  />
				</div>
				<div class="form-group">					 
					<asp:Label runat="server" >
						Sexo:
					</asp:Label>
                    <asp:RadioButton ID="rdb_Masc" Text="Masculino" GroupName="sexo" runat="server" />
                    <asp:RadioButton ID="rdb_Fem" Text="Feminio" GroupName="sexo" runat="server" />
				</div>
				<div class="form-group">					 
					<asp:Label runat="server" >
						Data Nascimento:
					</asp:Label>
					<asp:TextBox runat="server" TextMode="Date" CssClass="form-control" id="txtdatanasc" />
				</div>
				<div class="form-group">					 
					<asp:Label runat="server" >
						Altura:
					</asp:Label>
					<asp:TextBox runat="server" CssClass="form-control" id="txtaltura" />
				</div>
            	<div class="form-group">					 
					<asp:Label runat="server" >
						Peso:
					</asp:Label>
					<asp:TextBox runat="server" CssClass="form-control" id="txtpeso" />
				</div>
				
				<asp:Button runat="server" ID="btnCadastrar" CssClass="btn btn-default" Text="Registrar" OnClick="btnCadastrar_Click">					
				</asp:Button>                                		
		</div>
	</div>
</div>
</asp:Content>
