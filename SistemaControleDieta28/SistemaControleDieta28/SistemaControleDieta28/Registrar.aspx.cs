using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaControleDieta28
{
    public partial class Registrar : System.Web.UI.Page
    {
        Class_usuario con = new Class_usuario();

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

                con.cadastrar();

                Response.Write("<script>alert('Cadastrado com Sucesso!')</script>");         

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                Response.Write("<script>alert('Falha ao cadastrar VIADO!')</script>");      
            }
        }
    }
    }
