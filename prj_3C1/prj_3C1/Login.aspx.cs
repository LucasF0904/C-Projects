using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prj_3C1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Logar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "thiago")
                Session["usuario"] = txtusuario.Text;            
        }
    }
}