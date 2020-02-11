using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaControleDieta28
{
    public partial class Pagina : System.Web.UI.Page
    {
        private Class_usuario user = new Class_usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["perfil"] != null) //valida de o usuario logou
                {
                    user = (Class_usuario)Session["perfil"]; //caso sim carrega os dados da sessão
                    // txtNome.Text = user.nome;
                    lblUsu.Text = user.nome;
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnPerfilAli_Click(object sender, EventArgs e)
        {
            Response.Redirect("Perfil_Alimentar.aspx");
        }

        protected void btnMeta_usu_Click(object sender, EventArgs e)
        {
            Response.Redirect("Meta_Usuario.aspx");
        }

        protected void btnPerfil_Click(object sender, EventArgs e)
        {
            Response.Redirect("Perfil.aspx");
        }

        protected void btnPerfilAtivUsu_Click(object sender, EventArgs e)
        {
            Response.Redirect("Perfil_Atividades.aspx");
        }

        protected void btnAlimento_Click(object sender, EventArgs e)
        {
            Response.Redirect("Alimento.aspx");
        }


        protected void btnNovaMeta_Click(object sender, EventArgs e)
        {
            Response.Redirect("Nova_Meta.aspx");
        }

        protected void btnFeedBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Feedback.aspx");
        }

    }
}