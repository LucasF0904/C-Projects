using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECommerce
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        private Usuario user = new Usuario(); //instancia o objeto do tipo usuario
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["perfil"] != null) //valida de o usuario logou
                {
                    user = (Usuario)Session["perfil"]; //caso sim carrega os dados da sessão
                }
                if (!IsPostBack) //verifica se nao é o evento PostBack
                {                    
                    GridUsuario.DataSource = user.Pesquisar_Perfil_por("id = " + user.Id); //busca somente os dados do perfil logado
                    GridUsuario.DataBind();                    
                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
        }

        protected void GridUsuario_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                GridUsuario.EditIndex = e.NewEditIndex; //Habilita a linha a ser editada em modo edição
                GridUsuario.DataSource = user.Pesquisar_Perfil_por("id = " + user.Id); //recarrega os dados para visualizar
                GridUsuario.DataBind();
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
        }

        protected void GridUsuario_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            try
            {
                GridUsuario.EditIndex = -1; //desabilita o modo de edição
                GridUsuario.DataSource = user.Pesquisar_Perfil_por("id = " + user.Id);
                GridUsuario.DataBind();
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
        }
                
        protected void GridUsuario_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                user.Nome_Completo = e.NewValues[0].ToString(); //atribuindo os novos valores aos atributos do objeto
                user.Email = e.NewValues[1].ToString();
                user.Cod_Autenticacao = e.NewValues[2].ToString();

                user.Alterar_Dados_Perfil(); //apos preenchido o usuario é alterado os novos dados no banco

                GridUsuario.EditIndex = -1; //desabilita o modo edição
                GridUsuario.DataSource = user.Pesquisar_Perfil_por("id = " + user.Id);
                GridUsuario.DataBind();
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
        }
    }
}