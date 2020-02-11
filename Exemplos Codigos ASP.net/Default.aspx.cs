using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECommerce
{
    public partial class _Default : Page
    {
        private Produto prod = new Produto();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    produtoLista.DataSource = prod.Visualizar_todos_Produto();
                    produtoLista.DataBind();
                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string condicao = string.Format("titulo like '%{0}%'", txtpesquisa.Text); //pesquisa os produtos por titulo
                produtoLista.DataSource = prod.Pesquisar_Produto_por(condicao);
                produtoLista.DataBind();
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
        }
    }
}