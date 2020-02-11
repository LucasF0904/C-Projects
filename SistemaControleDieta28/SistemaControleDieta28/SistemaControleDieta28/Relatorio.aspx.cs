using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaControleDieta28
{
    public partial class Relatorio : System.Web.UI.Page
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
                    Class_alimento Ali = new Class_alimento();
                    Class_Meta meta = new Class_Meta();
                    Class_Meta_Usuario metaUsu = new Class_Meta_Usuario();
                    Class_Perfil_Alimentar Perfilali = new Class_Perfil_Alimentar();
                    Class_Perfil_Atividades PerfilAtiv = new Class_Perfil_Atividades();
                    Class_tipo_refeicao tiporefe = new Class_tipo_refeicao();
                    card.id_usuario = usuario.id;
                    GridView1.DataSource = card.FeedCaloriasTotais();
                    meta.id = int.Parse(meta.descricao);
                    GridView1.DataSource = meta.Visualizar();
                    metaUsu.id = metaUsu.id_meta;
                    GridView1.DataSource = metaUsu.visualizar();
                    Perfilali.id = Perfilali.qtde_refeicoes_dia;
                    GridView1.DataSource = Perfilali.Visualizar_porusuario();
                    PerfilAtiv.id = PerfilAtiv.media_queima_calorias_semana;
                    GridView1.DataSource = PerfilAtiv.visualizar();
                    tiporefe.id = int.Parse(tiporefe.descricao);
                    GridView1.DataSource = tiporefe.visualizar();
                    GridView1.DataBind();
                }
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
                try
                {
                    try
                    {
                        Class_cardapio card = new Class_cardapio();
                        card.id_usuario = usuario.id;
                        GridView1.DataSource = card.Visualizar_porusuario();
                        GridView1.DataBind();
                        Class_alimento Ali = new Class_alimento();
                        Ali.id = usuario.id;
                        GridView1.DataSource = Ali.visualizar();
                        GridView1.DataBind();
                    }
                    catch (Exception ex)
                    {
                        Response.Write(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}