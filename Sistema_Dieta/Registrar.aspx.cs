using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_Dieta
{
    public partial class registrar : System.Web.UI.Page
    {
        classUsuario con = new classUsuario();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
                try{
                con.nome = txtnome.Text;
                con.email = txtemail.Text;
                con.senha = txtsenha.Text;
                if (rdb_Masc.Checked)
                    con.sexo = "M";
                else
                    con.sexo = "F";
                con.data_nascimento = DateTime.Parse(txtdatanasc.Text);
                con.altura = double.Parse(txtaltura.Text);
                con.peso = double.Parse(txtpeso.Text);

                con.cadastra();

                Response.Write("<script>alert('Cadastrado com Sucesso!')</script>");         

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}