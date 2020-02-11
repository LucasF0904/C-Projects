using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaControleDieta28
{
    public partial class Alimento : System.Web.UI.Page
    {
        private Class_usuario user = new Class_usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["perfil"] != null)
                {
                    user = (Class_usuario)Session["perfil"]; 
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
                Class_alimento ali = new Class_alimento();
                ali.id = int.Parse(txtid.Text);
                ali.nome = txtnome.Text;
                ali.calorias = double.Parse(txtcalorias.Text);
                ali.porcao_gramas = int.Parse(txtporcaogramas.Text);
                ali.cadastrar();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}