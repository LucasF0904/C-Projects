using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaControleDieta28
{
    public partial class Feedback : System.Web.UI.Page
    {
        Class_usuario usuario = new Class_usuario();

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
                    usuario = (Class_usuario)Session["perfil"];
                }

                if (!IsPostBack)
                {
                    //carrega o gridview
                    Class_cardapio card = new Class_cardapio();
                    card.id_usuario = usuario.id;
                    GridView1.DataSource = card.FeedCaloriasTotais();
                    GridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

        }
    }
}