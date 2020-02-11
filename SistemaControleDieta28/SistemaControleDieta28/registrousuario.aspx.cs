using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaControleDieta28
{
    public partial class registrousuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Class_usuario usu = new Class_usuario();
                usu.id = int.Parse(txtID.Text);
                usu.nome = txtNome.Text;
                usu.email = txtEmail.Text;
                usu.senha = txtSenha.Text;
                usu.sexo = txtSexo.SelectedValue;
                usu.data_nascimento = DateTime.Parse(txtDTNasc.Text);
                usu.altura = double.Parse(txtAltura.Text);
                usu.peso = double.Parse(txtPeso.Text);




                usu.cadastrar();

            

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}