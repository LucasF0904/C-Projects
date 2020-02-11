<%@ Page Title="" Language="C#" MasterPageFile="~/Dieta.Master" AutoEventWireup="true" CodeBehind="FeedBack.aspx.cs" Inherits="Sistema_Dieta.FeedBack" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
	<div class="row" >
		<div class="col-md-2">	
                <h2> FeedBack</h2>		
				    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
         </div>
    </div>
    </div>
</asp:Content>
