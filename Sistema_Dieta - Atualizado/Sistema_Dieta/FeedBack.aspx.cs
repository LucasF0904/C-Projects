using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_Dieta
{
    public partial class FeedBack : System.Web.UI.Page
    {

        classUsuario usuario = new classUsuario();

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
                    usuario = (classUsuario)Session["perfil"];
                }

                if (!IsPostBack)
                {
                    //carrega o gridview
                    classCardapio card = new classCardapio();
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