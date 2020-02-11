using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prj_venda2
{
    public partial class CadastrarVendedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_Pesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                vendedor vend = new vendedor();
                GridView1.DataSource = vend.visualizar();
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btn_Inserir_Click1(object sender, EventArgs e)
        {
            try
            {
                vendedor vend = new vendedor();
                vend.matricula = txtMatricula.Text;
                vend.nome = txtNome.Text;
                vend.sexo = char.Parse(txtSexo.Text);
                vend.telefone = char.Parse(txtTelefone.Text);
                vend.datanasc = DateTime.Parse(txtDatanasc.Text);
                vend.bairro = txtBairro.Text;
                vend.cep = char.Parse(txtCep.Text);
                vend.cidade = txtCidade.Text;
                vend.complemento = char.Parse(txtComplemento.Text);
                vend.numero = int.Parse(txtNumero.Text); 
                vend.comissao = decimal.Parse(txtComissao.Text);
                


                vend.cadastrar_novo();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btn_Alterar_Click(object sender, EventArgs e)
        {
            try
            {
               vendedor vend = new vendedor();
               vend.matricula = txtMatricula.Text;
               vend.nome = txtNome.Text;
               vend.sexo = char.Parse(txtSexo.Text);
               vend.telefone = char.Parse(txtTelefone.Text);
               vend.datanasc = DateTime.Parse(txtDatanasc.Text);
               vend.bairro = txtBairro.Text;
               vend.cep = char.Parse(txtCep.Text);
               vend.cidade = txtCidade.Text;
               vend.complemento = char.Parse(txtComplemento.Text);
               vend.numero = int.Parse(txtNumero.Text);
               vend.comissao = decimal.Parse(txtComissao.Text);
                


                vend.alterar_dados();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btn_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                vendedor vend = new vendedor();
                vend.matricula = txtMatricula.Text;
                vend.deletar();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}