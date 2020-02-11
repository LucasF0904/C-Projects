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
                    //carrega o gridview
                    classCardapio card = new classCardapio();
                    card.id_usuario = usuario.id;
                    GridView1.DataSource = card.Visualizar_PorUsuario();
                    GridView1.DataBind();

                    //carrega o dropdowlist tipo de refeicao                    
                    txttipo.DataSource = card.PesquisarTipoRefeicao();
                    txttipo.DataTextField = "descricao";
                    txttipo.DataValueField = "id";
                    txttipo.DataBind();

                    //carrega o dropdowlist alimento
                    txtalimento.DataSource = card.PesquisarAlimento();
                    txtalimento.DataTextField = "nome";
                    txtalimento.DataValueField = "id";
                    txtalimento.DataBind();
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    classCardapio card = new classCardapio();
                    card.id_alimento = int.Parse(txtalimento.Text);
                    card.id_usuario = usuario.id ;
                    card.id_tipo_refeicao = int.Parse(txttipo.Text);
                    card.porcao = int.Parse(txtporcao.Text);
                    card.cadastra();


                    GridView1.DataSource = card.Visualizar_PorUsuario();
                    GridView1.DataBind();

                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
        }

        protected void btn_pesquisar_Click(object sender, EventArgs e)
        {
            try
            {                              
                    classCardapio card = new classCardapio();
                    card.id_usuario = usuario.id;
                    string condicao = "id_usuario = " + usuario.id + " and " + ddlCampo.Text + " like '%" + txtpesquisa.Text + "%' order by " + RadioButtonList1.SelectedValue;
                    GridView1.DataSource = card.Visualizar_PorCampos(condicao);
                    GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}