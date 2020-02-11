using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SistemaControleDieta28
{
    public partial class Perfil : System.Web.UI.Page
    {
        private Class_usuario user = new Class_usuario(); //instancia o objeto do tipo usuario
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["perfil"] != null) //valida de o usuario logou
                {
                    user = (Class_usuario)Session["perfil"]; //caso sim carrega os dados da sessão
                    // txtNome.Text = user.nome;
                    txtNome.Text = user.nome;
                    txtEmail.Text = user.email;
                    txtSenha.Text = user.senha;
                    txtSexo.Text = user.sexo;
                    txtdtnasc.Text = user.data_nascimento.ToString();
                    txtAltura.Text = user.altura.ToString();
                    txtPeso.Text = user.peso.ToString();
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

        protected void btnCardapio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cardapio.aspx");
            
        }

        
    }
}