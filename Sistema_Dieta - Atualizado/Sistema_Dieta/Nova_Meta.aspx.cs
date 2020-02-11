using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_Dieta
{
    public partial class Nova_Meta : System.Web.UI.Page
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
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Meta meta = new Class_Meta();
                meta.descricao = txtDescricao.Text;

                meta.Inserir_Meta();

                txtDescricao.Text = "";

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Metas.aspx");
        }
    }
}