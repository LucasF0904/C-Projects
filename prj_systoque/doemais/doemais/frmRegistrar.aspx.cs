using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace doemais
{
    public partial class frmRegistrar : System.Web.UI.Page
    {
        Class_Usuario usuario = new Class_Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListItem l = new ListItem("Doador", "doador", true); l.Selected = true;
                ListItem l1 = new ListItem("Receptor", "receptor",true); l1.Selected = false;
                ddlTipo.Items.Add(l);
                ddlTipo.Items.Add(l1);
                ListItem i = new ListItem("A", "A", true);
                ListItem i1 = new ListItem("B", "B", true);
                ListItem i2 = new ListItem("AB", "AB", true);
                ListItem i3 = new ListItem("O", "O", true);
                ddlSangue.Items.Add(i2);
                ddlSangue.Items.Add(i);
                ddlSangue.Items.Add(i1);
                ddlSangue.Items.Add(i3);
                ListItem s = new ListItem("Positivo", "Positivo", true);
                ListItem s1 = new ListItem("Negativo", "Negativo", true);
                ddlTipoSangue.Items.Add(s);
                ddlTipoSangue.Items.Add(s1);
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            DataTable dt = usuario.Buscausuariopor("email = '" + txtemail.Text+"'");
            if (dt.Rows.Count > 0)
            {
                Response.Write("<script>alert('Email já cadastrado!')</script>");
                txtemail.Text = "";
                txtemail.Focus();
            }
            else
            {
                switch (ddlTipo.SelectedValue.ToString())
                {
                    case "doador":
                        usuario.nome = txtNome.Text;
                        usuario.email = txtemail.Text;
                        usuario.senha = txtSenha.Text;
                        usuario.tipo_usuario = 1;
                        usuario.tipo_sangue = ddlSangue.SelectedValue.ToString();
                        usuario.rh = ddlTipoSangue.SelectedValue.ToString();
                        usuario.data_nasc = Convert.ToDateTime(txtDataNascimento.Text);
                        usuario.ultima_doacao = Convert.ToDateTime(txtultimadoacao.Text);
                        usuario.Inserir();
                        break;
                    case "receptor":
                        usuario.nome = txtNome.Text;
                        usuario.email = txtemail.Text;
                        usuario.senha = txtSenha.Text;
                        usuario.tipo_usuario = 0;
                        usuario.tipo_sangue = ddlSangue.SelectedValue.ToString();
                        usuario.rh = ddlTipoSangue.SelectedValue.ToString();
                        usuario.data_nasc = Convert.ToDateTime(txtDataNascimento.Text);
                        usuario.ultima_doacao = Convert.ToDateTime(txtultimadoacao.Text);
                        usuario.Inserir();
                        break;
                }
                Response.Redirect("frmLogin.aspx");
            }
        }
    }
}