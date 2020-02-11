using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace doemais
{
    public partial class PrincipalMaster : System.Web.UI.MasterPage
    {
        Class_Usuario usuario = new Class_Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Session["id"] == null)
                {
                    Response.Redirect("frmLogin.aspx");
                }
                else
                {
                    if (Session["tipo"].ToString() == "1")
                    {
                        menudoacoes.Visible = false;
                        menudisponiveis.Visible = true;
                    }
                    else if (Session["tipo"].ToString() == "0")
                    {
                        menudoacoes.Visible = true;
                        menudisponiveis.Visible = false;
                    }
                }
            }
        }

        protected void btnSair_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("frmLogin.aspx");
        }
    }
}