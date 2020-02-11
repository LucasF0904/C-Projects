﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Cotemig")
            {
                Session["usuario"] = txtUsuario.Text;
                Response.Redirect("Principal.aspx");
            }
            else if (txtSenha.Text != "Cotemig")
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}