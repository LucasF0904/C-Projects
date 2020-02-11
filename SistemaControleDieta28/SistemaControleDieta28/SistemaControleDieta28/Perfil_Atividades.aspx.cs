using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaControleDieta28
{
    public partial class Perfil_Atividades : System.Web.UI.Page
    {
        private Class_usuario user = new Class_usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["perfil"] != null) //valida de o usuario logou
                {
                    user = (Class_usuario)Session["perfil"]; //caso sim carrega os dados da sessão
                    user.id = int.Parse(txtID.Text);                
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
                Class_Perfil_Atividades perfilAti = new Class_Perfil_Atividades();
                perfilAti.id = int.Parse(txtID.Text);
                perfilAti.id_usuario = int.Parse(txtIdusuario.Text);
                perfilAti.frequencia_semanal = int.Parse(txtfrequencia_semanal.Text);
                perfilAti.intensidade = int.Parse(txtintensidade.Text);
                perfilAti.media_queima_calorias_semana = int.Parse(txtmedia_caloria_semana.Text);
                perfilAti.cadastrar();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}