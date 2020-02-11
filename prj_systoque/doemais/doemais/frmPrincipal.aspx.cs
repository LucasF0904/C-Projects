using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace doemais
{
    public partial class frmPrincipal : System.Web.UI.Page
    {
        Class_Usuario usuario = new Class_Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["id"] != null)
                {
                    if (!IsPostBack)
                    {
                        string condicao = string.Format("id = {0}", Session["id"].ToString());
                        DataTable dt = usuario.Buscausuariopor(condicao);
                        switch (dt.Rows[0]["tipo_usuario"].ToString())
                        {
                            case "1":
                                lblvoce.Text = "Doador";
                                break;
                            case "0":
                                lblvoce.Text = "Receptor";
                                break;
                        }
                        lblsanguineo.Text = dt.Rows[0]["tipo_Sangue"].ToString() + " " + dt.Rows[0]["rh"];
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}