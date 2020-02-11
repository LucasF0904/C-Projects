<%@ Page Title="" Language="C#" MasterPageFile="~/Dieta.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Sistema_Dieta.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
	<div class="row" >
		<div class="col-md-2">	
                <h2> Bem vindo</h2>		
				<div class="form-group">					 
					<asp:Label runat="server" >
						Email address
					</asp:Label>
					<asp:TextBox runat="server" TextMode="email" CssClass="form-control" id="txtemail" placeholder="Email" />
				</div>
				<div class="form-group">
					 <asp:Label runat="server">
						Password
					</asp:Label>
					<asp:TextBox runat="server" TextMode="password" CssClass="form-control" id="txtsenha" />
				</div>
				
				<asp:Button runat="server" ID="btnLogin" CssClass="btn btn-default" Text="Logar" OnClick="btnLogin_Click">					
				</asp:Button>
                <br />
                <a href="Registrar.aspx">Não possui cadastro? Clique aqui</a>			
		</div>
	</div>
</div>

</asp:Content>
