<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ECommerce._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Meu Comercio Eletronico</h1>
        <p class="lead">Site desenvolvido com base no modelo 3 camadas. Estamos utilizando o modelo asp.net webform para facilitar o processo de desenvolvimento</p>        
    </div>
    <div class="row">
        <nav class="navbar navbar-inverse" role="navigation">	
            <div class="navbar-form">
                <asp:TextBox ID="txtpesquisa" runat="server" CssClass="form-control"></asp:TextBox>						
                <asp:Button ID="btnPesquisar" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="btnPesquisar_Click"/>				
             </div>					    
        </nav>
    </div>

    <div class="row">
         <asp:ListView ID="produtoLista" runat="server"  DataKeyNames="cod_barra" GroupItemCount="5">
             <EmptyDataTemplate>      
                 <h3>Produto não encontrado.</h3>        
             </EmptyDataTemplate>  
             <GroupTemplate>
                 <tr ID="itemPlaceholderContainer" runat="server">      
                    <td ID="itemPlaceholder" runat="server"></td>    
                 </tr>  
             </GroupTemplate>  
             <ItemTemplate>    
                 <td id="Td1" runat="server">      
                    <table>        
                        <tr>          
                            <td>&nbsp;</td>          
                            <td>
                                <img src="/Catalog_Images/<%#:Eval("Url_Imagem")%>" width="100" height="75"/></a> 
                            </td>
                            <td>
                                <a href="DetalhesProduto.aspx?produtoCodBarra=<%#:Eval("Cod_Barra")%>">
                                <span class="ProdutoNome">
                                    <%#:Eval("Titulo")%>
                                </span></a><br />
                                <span class="PrecoUnitario">           
                                    <b>Preço : </b><%#:String.Format("{0:c}", Eval("Preco"))%>
                                </span>
                            </td>
                        </tr>      
                    </table>    
                 </td>  
             </ItemTemplate>  
             <LayoutTemplate>    
                <table id="tabelaProdutos" runat="server"> 
                    <tr id="Tr1" runat="server">        
                        <td id="Td3" runat="server">          
                            <table ID="groupPlaceholderContainer" runat="server">            
                                <tr ID="groupPlaceholder" runat="server"></tr>          
                            </table>        
                        </td>      
                    </tr>           
                    <tr id="Tr2" runat="server">
                        <td id="Td4" runat="server"></td>
                    </tr>    
                </table>  
             </LayoutTemplate>
         </asp:ListView>
    </div>

</asp:Content>
