using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaControleDieta28
{
    public partial class AlimentoRUD : System.Web.UI.Page
    {
        private Class_alimento Ali = new Class_alimento();
        private Class_usuario user = new Class_usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["perfil"] != null) //valida de o usuario logou
                {
                    user = (Class_usuario)Session["perfil"]; //caso sim carrega os dados da sessão

                    if (!IsPostBack)
                    {
                        Ali.id = user.id;
                        lblNome.Text = user.nome;
                        lblEmail.Text = user.email;
                        lblSenha.Text = user.senha;
                        lblSexo.Text = user.sexo;
                        lblDtnasc.Text = user.data_nascimento.ToString();
                        lblAltura.Text = user.altura.ToString();
                        lblPeso.Text = user.peso.ToString();
                        GridVerMet.DataSource = Ali.visualizar();
                        GridVerMet.DataBind();

                    }
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

        protected void GridVerMet_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {

                Class_alimento Ali = new Class_alimento();
                Ali.id = Convert.ToInt32(e.NewValues[0]);
                Ali.nome = e.NewValues[1].ToString();
                Ali.porcao_gramas = Convert.ToInt32(e.NewValues[2]);


                Ali.alterar_dados();

                GridVerMet.EditIndex = -1;


                GridVerMet.DataSource = Ali.visualizar();
                GridVerMet.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void GridVerMet_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                Class_alimento Ali = new Class_alimento();
                GridVerMet.EditIndex = e.NewEditIndex;

                GridVerMet.DataSource = Ali.visualizar();
                GridVerMet.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void GridVerMet_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {

                Class_alimento Ali = new Class_alimento();
                Ali.id = Convert.ToInt32(e.Values[0]);



                GridVerMet.EditIndex = -1;


                GridVerMet.DataSource = Ali.visualizar();
                GridVerMet.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}