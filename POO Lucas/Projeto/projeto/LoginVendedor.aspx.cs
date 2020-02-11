using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto
{
    public partial class LoginVendedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnVendedor_Click(object sender, EventArgs e)
        {
            if (txtVendedor.Text == "Lucas")
                Session["usuario"] = txtVendedor.Text;
            Response.Redirect("CadastraVenda.aspx");
        }
    }
}