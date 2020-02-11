<%@ Page Title="Detalhes Produto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalhesProduto.aspx.cs" Inherits="ECommerce.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <asp:FormView ID="produtoDetalhes" runat="server">
        <EmptyDataTemplate>
            <h1>Produto não encontrado</h1>
        </EmptyDataTemplate>
        <ItemTemplate>
            <div>
                <h1><%#:Eval("Titulo") %></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>
                        <img src="/Catalog_Images/<%#:Eval("Url_Imagem")%>" style="border:solid; height:300px" alt="<%#:Eval("Titulo") %>"/>
                    </td>
                    <td>&nbsp;</td>  
                    <td style="vertical-align: top; text-align:left;">
                        <b>Descrição:</b><br /><%#:Eval("Descricao") %>
                        <br />
                        <span><b>Preço Unitário:</b>&nbsp;<%#: String.Format("{0:c}", Eval("Preco")) %></span>
                        <br />
                        <span><b>Codigo de Barra:</b>&nbsp;<%#:Eval("Cod_Barra")%></span>                            
                        <br />
                        <span><b>Quantidade:</b>&nbsp;
                            <asp:TextBox ID="txtQuantidade" runat="server" CssClass="from-control">1</asp:TextBox>
                        </span>
                        <br />
                        <asp:Button ID="btnAddItemCarrinho" runat="server" Text="Adicionar ao Carrinho"
                             CssClass="btn btn-success"  CommandName="select" OnClick="btnAddItemCarrinho_Click"/>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
