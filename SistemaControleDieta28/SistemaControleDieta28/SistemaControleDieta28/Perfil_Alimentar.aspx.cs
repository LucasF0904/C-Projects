using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaControleDieta28
{
    public partial class Perfil_Alimentar : System.Web.UI.Page
    {
        private Class_usuario user = new Class_usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["perfil"] != null) //valida de o usuario logou
                {
                    user = (Class_usuario)Session["perfil"]; //caso sim carrega os dados da sessão
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
                Class_Perfil_Alimentar perfilAli = new Class_Perfil_Alimentar();
                perfilAli.id = int.Parse(txtID.Text);
                perfilAli.id_usuario = int.Parse(txtIdusuario.Text);
                perfilAli.qtde_refeicoes_dia = int.Parse(txtqtde_refeicoes_dia.Text);
                perfilAli.cadastrar();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}