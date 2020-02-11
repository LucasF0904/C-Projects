using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaControleDieta28
{
    public partial class Nova_Meta : System.Web.UI.Page
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

                meta.cadastrar();

                txtDescricao.Text = "";

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Meta.aspx");
        }
    }
}