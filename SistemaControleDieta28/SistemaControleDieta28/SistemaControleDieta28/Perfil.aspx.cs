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
                    if (rdb_Masc.Checked)
                        user.sexo = "M";
                    else
                        user.sexo = "F";
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

            
        }

        protected void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                user.nome = txtNome.Text;
                user.email = txtEmail.Text;
                user.senha = txtSenha.Text;
                if (rdb_Masc.Checked)
                    user.sexo = "M";
                else
                    user.sexo = "F";
                user.data_nascimento = DateTime.Parse(txtdtnasc.Text);
                user.altura = double.Parse(txtAltura.Text);
                user.peso = double.Parse(txtPeso.Text);

                user.alterar_dados();

                Response.Write("<script>alert('Alterado com Sucesso!')</script>");

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                Response.Write("<script>alert('Falha ao Alterar VIADO!')</script>");
            }
        }

        
    }
}