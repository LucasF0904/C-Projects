<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalMaster.Master" AutoEventWireup="true" CodeBehind="frmDoacao.aspx.cs" Inherits="doemais.frmDoacao" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Doe + | Página de doações</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="corpo" runat="server">
<div class="content-wrapper">
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <h4 class="page-head-line">Pedido de doação</h4>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            Adicionar pedido de doação
                        </div>
                        <div class="panel-body">
                            <label>Informações sobre a doação</label>
                            <textarea id="txtinfo" class="form-control" rows="3" placeholder="Informações sobre o hospital, tais como endereço" runat="server"></textarea><br/>
                            <asp:Button ID="btnSalvar" Text="Fazer Pedido" OnClick="btnSalvar_Click" CssClass="col-md-offset-9 col-md-3 btn btn-info" runat="server" />
                        </div>
                    </div>
                </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        Meus pedidos de doação
                    </div>
                    <div class="panel-body">
                        <div class="table-responsive">
                            <asp:GridView OnRowCommand="grdPesquisar_RowCommand" CssClass="table table-striped table-bordered table-hover" ID="grdPesquisar" runat="server">
                                <Columns>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:Button ID="Excluir" runat="server" 
                                                CssClass="btn btn-info"
                                                  CommandName="Excluir" 
                                            CommandArgument="<%# ((GridViewRow) Container).RowIndex %>"
                                                  Text="Excluir" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
</asp:Content>
