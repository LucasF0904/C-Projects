using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace revisao3B1
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_armazenarSession_Click(object sender, EventArgs e)
        {
            try
            {
                Session["nomeUsuario"] = txtvalor.Text;
                Session["senhaUsuario"] = txtsenha.Text;
                Response.Redirect("crudcurso.aspx");
            }
            catch (Exception ex)
            {                
                Response.Write(ex.Message);
            }
        }
    }
}