using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECommerce
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataTable dtUser = new System.Data.DataTable();

                Usuario user = new Usuario();                
                string condicao = string.Format("Email='{0}' and Cod_Autenticacao='{1}'", txtEmail.Text, txtSenha.Text); //cria o filtro de usuario e senha

                dtUser = user.Pesquisar_Usuario_por(condicao); //preenche o datatable com os dados do usuario digitado
               
                if (dtUser.Rows.Count == 1) //verifica se foi encontrado algum informação do usuario digitado
                {
                    user.Id = int.Parse(dtUser.Rows[0][0].ToString()); //se sim carrega os dados do usario no objeto usuario
                    user.Nome_Completo = dtUser.Rows[0][1].ToString();
                    user.Email = dtUser.Rows[0][2].ToString();
                    user.Tipo_Usuario = int.Parse(dtUser.Rows[0][4].ToString());

                    Session["perfil"] = user; //armazena o objeto usuario na sessão
                    
                    Response.Write("<script>alert('Bem vindo!');window.location.href= 'menPrincipal.aspx'</script>");                   
                }
                else
                {
                    Session["perfil"] = null; //caso não deixa a sessão vazia
                    Response.Write("<script>alert('Erro')</script>");
                }                
            }
            catch (Exception ex)
            {
                Response.Write(ex.message);
            }

        }
    }
}