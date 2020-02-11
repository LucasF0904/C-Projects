using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_Dieta
{
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["perfil"] == null)//logado
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    classUsuario usu = (classUsuario) Session["perfil"];
                    lblnome.Text = usu.altura.ToString();
                    lblemail.Text = usu.email;
                }

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

        }
    }
}