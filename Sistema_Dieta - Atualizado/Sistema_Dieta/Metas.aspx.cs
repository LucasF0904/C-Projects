using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_Dieta
{
    public partial class Metas : System.Web.UI.Page
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
                    Class_Meta meta = new Class_Meta();
                    Class_Meta_Usuario meta_usuario = new Class_Meta_Usuario();
                    ddlMetas.DataSource = meta.Visualizar_Meta();
                    ddlMetas.DataTextField = "descricao";
                    ddlMetas.DataValueField = "id";
                    ddlMetas.DataBind();

                    meta_usuario.id_usuario = usuario.id;
                    GVMetas.DataSource = meta_usuario.Visualizar_Meta_Usuario();
                    GVMetas.DataBind();
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnNovaMeta_Click(object sender, EventArgs e)
        {
            Response.Redirect("Nova_Meta.aspx");
        }

        protected void GVMetas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {

                Class_Meta_Usuario meta_usuario = new Class_Meta_Usuario();
                meta_usuario.id = Convert.ToInt32(e.Values[0]);

                meta_usuario.Excluir_Meta_Usuario();

                GVMetas.EditIndex = -1;

                meta_usuario.id_usuario = usuario.id;
                GVMetas.DataSource = meta_usuario.Visualizar_Meta_Usuario();
                GVMetas.DataBind();

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
                Class_Meta_Usuario meta_usuario = new Class_Meta_Usuario();
                meta_usuario.id_usuario = usuario.id;
                meta_usuario.id_meta = int.Parse(ddlMetas.SelectedValue);

                meta_usuario.Inserir_Meta_Usuario();

                meta_usuario.id_usuario = usuario.id;
                GVMetas.DataSource = meta_usuario.Visualizar_Meta_Usuario();
                GVMetas.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}