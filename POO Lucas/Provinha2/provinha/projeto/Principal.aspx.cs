using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCliente_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastrarCliente.aspx");
        }

        protected void btnItemVenda_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastrarItensVenda.aspx");
        }

        protected void btnProduto_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastrarProduto.aspx");
        }

        protected void btnVendedor_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastrarVendedor.aspx");
        }

        protected void btnVenda_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginVendedor.aspx");
        }
    }
}