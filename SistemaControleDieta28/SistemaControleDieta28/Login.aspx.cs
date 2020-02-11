using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SistemaControleDieta28
{
    public partial class Login : System.Web.UI.Page
    {
        Class_usuario usu = new Class_usuario();
        DataTable dtusu = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                // atribui valor ao email e senha e pesquisa os mesmos
                usu.email = txtEmail.Text;
                usu.senha = txtSenha.Text;
                dtusu = usu.pesquisar();

                if (dtusu.Rows.Count == 1) //verifica se algum registro foi encontrado
                {
                    //caso sim armazena os dados no objeto
                    usu.id = int.Parse(dtusu.Rows[0][0].ToString());
                    usu.nome = dtusu.Rows[0][1].ToString();
                    usu.email = dtusu.Rows[0][2].ToString();
                    usu.senha = dtusu.Rows[0][3].ToString();
                    usu.sexo = dtusu.Rows[0][4].ToString();
                    usu.data_nascimento = Convert.ToDateTime(dtusu.Rows[0][5]);
                    usu.altura = double.Parse(dtusu.Rows[0][6].ToString());
                    usu.peso = double.Parse(dtusu.Rows[0][7].ToString());

                    


                    Session["perfil"] = usu; //armazena o objeto na session

                    Response.Write("<script>alert('Bem vindo!')</script>");
                    Response.Redirect("Perfil.aspx");

                }
                else
                {
                    Session["perfil"] = null; //caso nao encontre nenhum registro deixa a session com null
                    Response.Write("<script>alert('Login ou Senha não correspondem!')</script>");
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Login ou "+ex.Message+ "!')</script>");
                Response.Write(ex.Message);
            }
        }
    }
}