<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalMaster.Master" AutoEventWireup="true" CodeBehind="frmDisponiveis.aspx.cs" Inherits="doemais.frmDisponiveis" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Doe + | Doações disponíveis</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="corpo" runat="server">
    <div class="content-wrapper">
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <h4 class="page-head-line">Doações disponiveis</h4>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        Doações disponiveis
                    </div>
                    <div class="panel-body">
                        <div class="table-responsive">
                            <asp:GridView OnRowCommand="grdPesquisar_RowCommand" CssClass="table table-striped table-bordered table-hover" ID="grdPesquisar" runat="server">
                                <Columns>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:Button ID="Doar" runat="server" 
                                                CssClass="btn btn-info"
                                                  CommandName="Doar" 
                                            CommandArgument="<%# ((GridViewRow) Container).RowIndex %>"
                                                  Text="Doar" />
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
