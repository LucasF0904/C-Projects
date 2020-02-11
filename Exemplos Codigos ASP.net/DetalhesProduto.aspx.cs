using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECommerce
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        private Produto prod = new Produto(); //instancia o objeto do tipo produto
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack && Request.QueryString["produtoCodBarra"] != null) //verifica se não é postback e se foi passado o codigo do produto a ser visualizado
                {
                    string condicao = string.Format("cod_barra = {0}", Request.QueryString["produtoCodBarra"].ToString()); //busca o codigo de barra na Url get
                    produtoDetalhes.DataSource = prod.Pesquisar_Produto_por(condicao); //pesquisa o produto referente ao codigo de barra passado
                    produtoDetalhes.DataBind();
                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
        }

        protected void btnAddItemCarrinho_Click(object sender, EventArgs e)
        {
            try
            {
                Venda vend;
                if (Session["venda"] == null) //verifica se já esta ocorrendo uma venda 
                {
                    vend = new Venda(); //caso não inicia uma nova venda
                    vend.Valor_Total = 0; //zera o valor da compra
                }
                else
                {
                    vend = (Venda)Session["venda"]; //caso sim carrega os dados da venda armazendas na sessão
                }

                Itens_Venda item = new Itens_Venda();

                TextBox txtquant = (TextBox)produtoDetalhes.Row.FindControl("txtQuantidade"); //busca a quantidade digitada pelo usuario
                item.Quantidade = int.Parse(txtquant.Text);

                item.produto.Cod_Barra = Request.QueryString["produtoCodBarra"].ToString(); //busca o codigo de barra da url               

                string condicao = string.Format("cod_barra = {0}", item.produto.Cod_Barra);
                DataTable dt = prod.Pesquisar_Produto_por(condicao); //busca os dados do produto referente ao codigo de barra da url

                item.produto.Url_Imagem = dt.Rows[0][2].ToString(); //atribuindo os valores aos atributos do objeto
                item.produto.Descricao = dt.Rows[0][3].ToString();
                item.produto.Preco = float.Parse(dt.Rows[0][4].ToString());
                item.Valor_Total_Item = item.Quantidade * item.produto.Preco;

                vend.itens.Add(item); //adiciona um novo item ao carrinho de compra
                vend.Valor_Total += item.Valor_Total_Item; //atualiza o valor total da venda

                Session["venda"] = vend; //armazena a venda na sessão
                Response.Write("<script>alert('Adicionado ao Carrinho')</script>");                
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
        }
    }
}