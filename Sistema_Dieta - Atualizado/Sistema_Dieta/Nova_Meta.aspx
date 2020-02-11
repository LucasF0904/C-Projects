<%@ Page Title="" Language="C#" MasterPageFile="~/Dieta.Master" AutoEventWireup="true" CodeBehind="Nova_Meta.aspx.cs" Inherits="Sistema_Dieta.Nova_Meta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container-fluid">
	<div class="row" >
		<div class="col-md-2">	
             <div class="form-group"> 
                        Descrição da Meta
                        <asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                        <asp:Button ID="btnInserir" runat="server" Text="Inserir Meta" OnClick="btnInserir_Click" CssClass="btn btn-default"/>
                        <asp:Button ID="btnVoltar" runat="server" Text="Voltar" OnClick="btnVoltar_Click" CssClass="btn btn-default"/>
               </div>
         </div>
    </div>
</div>    
</asp:Content>
