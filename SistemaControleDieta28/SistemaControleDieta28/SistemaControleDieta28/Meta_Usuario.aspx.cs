using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DAL;

namespace SistemaControleDieta28
{   
    
    public partial class Meta_Usuario : System.Web.UI.Page
    {
        private Class_Meta_Usuario Met = new Class_Meta_Usuario();
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
                        Met.id_usuario = user.id;
                        lblNome.Text = user.nome;
                        lblEmail.Text = user.email;
                        lblSenha.Text = user.senha;
                        lblSexo.Text = user.sexo;
                        lblDtnasc.Text = user.data_nascimento.ToString();
                        lblAltura.Text = user.altura.ToString();
                        lblPeso.Text = user.peso.ToString();
                        GridVerMet.DataSource = Met.visualizar();
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

        protected void GridVerMet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}