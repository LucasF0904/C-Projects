using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaControleDieta28
{
    public partial class Cardapio : System.Web.UI.Page
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
                    Class_cardapio cardapio = new Class_cardapio();
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
                Class_cardapio cardapio = new Class_cardapio();

                cardapio.id_tipo_refeicao = int.Parse(DropDownList1.Text);
                cardapio.id_usuario = usuario.id;
                cardapio.porcao = int.Parse(txtporcao.Text);

                cardapio.cadastrar();

                cardapio.id_usuario = usuario.id;
                GridView1.DataSource = cardapio.Visualizar_porusuario();
                GridView1.DataBind();


            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnVisu_Click(object sender, EventArgs e)
        {
            try
            {
                Class_cardapio card = new Class_cardapio();
                GridView1.DataSource = card.Visualizar();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btn_pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                Class_cardapio card = new Class_cardapio();
                GridView1.DataSource = card.VisualizarCardapioCompleto();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }
    }
}