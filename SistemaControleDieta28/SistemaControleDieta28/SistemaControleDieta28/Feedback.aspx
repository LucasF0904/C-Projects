<%@ Page Title="" Language="C#" MasterPageFile="~/Prinipal.Master" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="SistemaControleDieta28.Feedback" %>
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
