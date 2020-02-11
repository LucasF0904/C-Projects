using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_Dieta
{
    public partial class Login : System.Web.UI.Page
    {
        classUsuario usu = new classUsuario();
        DataTable dtusu = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCriar_Click(object sender, EventArgs e)
        {
            Response.Redirect("cad_usu.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                    // atribui valor ao email e senha e pesquisa os mesmos
                    usu.email = txtemail.Text;
                    usu.senha = txtsenha.Text; 

                    dtusu = usu.pesquisar(); 

                    if (dtusu.Rows.Count == 1) //verifica se algum registro foi encontrado
                    {
                        //caso sim armazena os dados no objeto
                        usu.id = int.Parse(dtusu.Rows[0][0].ToString()); 
                        usu.nome = dtusu.Rows[0][1].ToString();
                        usu.email = dtusu.Rows[0][2].ToString();


                        Session["perfil"] = usu; //armazena o objeto na session

                        Response.Write("<script>alert('Bem vindo!')</script>");
                        
                    }
                    else
                    {
                        Session["perfil"] = null; //caso nao encontre nenhum registro deixa a session com null
                        Response.Write("<script>alert('Login ou Senha não correspondem!')</script>");
                    }                

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

    }
}