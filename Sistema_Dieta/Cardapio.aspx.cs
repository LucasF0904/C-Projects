using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_Dieta
{
    public partial class Cardapio : System.Web.UI.Page
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
                    classCardapio cardapio = new classCardapio();
                    cardapio.id_usuario = usuario.id;
                    GridView1.DataSource = cardapio.Visualizar_porusuario();
                    GridView1.DataBind();
                }

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                classCardapio cardapio = new classCardapio();
                cardapio.id_alimento = int.Parse(txtalimento.Text);
                cardapio.id_tipo_refeicao = int.Parse(txttipo.Text);
                cardapio.id_usuario = usuario.id;
                cardapio.porcao = int.Parse(txtporcao.Text);

                cardapio.cadastra();

                cardapio.id_usuario = usuario.id;
                GridView1.DataSource = cardapio.Visualizar_porusuario();
                GridView1.DataBind();


            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}