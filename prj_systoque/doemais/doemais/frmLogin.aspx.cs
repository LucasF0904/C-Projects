using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace doemais
{
    public partial class frmLogin : System.Web.UI.Page
    {
        Class_Usuario usuario = new Class_Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                string condicao = string.Format("email = '{0}' AND senha = '{1}'", txtEmail.Text, txtSenha.Text);
                DataTable dt = usuario.Buscausuariopor(condicao);
                if (dt.Rows.Count == 1)
                {
                    Session["id"] = dt.Rows[0]["id"].ToString();
                    Session["tipo"] = dt.Rows[0]["tipo_usuario"].ToString();
                    Response.Redirect("frmPrincipal.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Usuário e/ou senha incorretos!')");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}