<%@ Page Title="" Language="C#" MasterPageFile="~/Dieta.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="Sistema_Dieta.Perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container-fluid">
	<div class="row" >
		<div class="col-md-2">	
                <h2> Bem vindo</h2>	
            	<div class="form-group">					 
					<asp:Label runat="server" ID="lblid" >						
					</asp:Label>					
				</div>	
				<div class="form-group">					 
					<asp:Label runat="server" ID="lblnome" >						
					</asp:Label>					
				</div>
				<div class="form-group">
					 <asp:Label runat="server" ID="lblemail">						
					</asp:Label>	
				</div>			
		</div>
	</div>
</div>
</asp:Content>
