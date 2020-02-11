<%@ Page Title="" Language="C#" MasterPageFile="~/Dieta.Master" AutoEventWireup="true" CodeBehind="Metas.aspx.cs" Inherits="Sistema_Dieta.Metas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="container-fluid">
	<div class="row" >
		<div class="col-md-2">	
                <h2> Minhas metas</h2>
                    <asp:GridView ID="GVMetas" runat="server" OnRowDeleting="GVMetas_RowDeleting">
                        <Columns>
                            <asp:CommandField ShowDeleteButton="True" />
                        </Columns>
                    </asp:GridView>

                <div class="form-group">
                    <asp:DropDownList ID="ddlMetas" runat="server" CssClass="form-control">
                    </asp:DropDownList>    
                    <asp:Button ID="btnInserir" runat="server" Text="Inserir Nova Meta" OnClick="btnInserir_Click" CssClass="btn btn-default" />
                </div>
    
        Sua meta não esta disponivel cadastre uma nova meta:
            <br />    
        <asp:Button ID="btnNovaMeta" runat="server" Text="Cadastrar Nova Meta" OnClick="btnNovaMeta_Click" CssClass="btn btn-default" />
        </div>
    </div>
</div>    
</asp:Content>
