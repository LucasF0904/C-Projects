using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaControleDieta28
{
    public partial class Tipo_Refeicao : System.Web.UI.Page
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

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Class_tipo_refeicao tipoRef = new Class_tipo_refeicao();
                tipoRef.id = int.Parse(txtID.Text);
                tipoRef.descricao = txtDescricao.Text;
                tipoRef.cadastrar();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}