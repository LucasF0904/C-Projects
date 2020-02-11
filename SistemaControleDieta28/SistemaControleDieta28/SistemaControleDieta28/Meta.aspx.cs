using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SistemaControleDieta28
{
    public partial class Meta : System.Web.UI.Page
    {
        private Class_usuario user = new Class_usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["perfil"] != null) //valida de o usuario logou
                {
                    user = (Class_usuario)Session["perfil"]; //caso sim carrega os dados da sessão
                    // txtNome.Text = user.nome;
                    lblNome.Text = user.nome;
                    lblEmail.Text = user.email;
                    lblSenha.Text = user.senha;
                    lblSexo.Text = user.sexo;
                    lblDtnasc.Text = user.data_nascimento.ToString();
                    lblAltura.Text = user.altura.ToString();
                    lblPeso.Text = user.peso.ToString();
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

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Meta met = new Class_Meta();
                met.id = int.Parse(txtID.Text);
                met.descricao = txtDescricao.Text;
                met.cadastrar();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}