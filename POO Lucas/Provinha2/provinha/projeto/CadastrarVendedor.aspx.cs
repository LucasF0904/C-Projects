using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto
{
    public partial class CadastrarVendedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void Visualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Vendedor vend = new Class_Vendedor();
                GDVendedor.DataSource = vend.visualizar();
                GDVendedor.DataBind();
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Vendedor vend = new Class_Vendedor();
                vend.codigo = int.Parse(txtCodigo.Text);
                vend.nome = txtNome.Text;
                vend.rua = txtRua.Text;
                vend.numero = int.Parse(txtNumero.Text);
                vend.telefone = int.Parse(txtTelefone.Text);
                vend.bairro = txtBairro.Text;
                vend.logradouro = txtLogradouro.Text;
                vend.cidade = txtCidade.Text;
                vend.estado = txtEstado.Text;
                vend.datanasc = DateTime.Parse(txtdtnasc.Text);
                vend.comissao = decimal.Parse(txtComissao.Text);
                
                vend.cadastrar_novo();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void Alterar_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Vendedor vend = new Class_Vendedor();
                vend.codigo = int.Parse(txtCodigo.Text);
                vend.nome = txtNome.Text;
                vend.rua = txtRua.Text;
                vend.numero = int.Parse(txtNumero.Text);
                vend.telefone = int.Parse(txtTelefone.Text);
                vend.bairro = txtBairro.Text;
                vend.logradouro = txtLogradouro.Text;
                vend.cidade = txtCidade.Text;
                vend.estado = txtEstado.Text;
                vend.datanasc = DateTime.Parse(txtdtnasc.Text);
                vend.comissao = decimal.Parse(txtComissao.Text);
                
                    vend.alterar_dados();

                    GDVendedor.DataSource = vend.visualizar();
                
            }
            catch (Exception ex)
            {
                 Response.Write(ex.Message);
            }
        }

        protected void Deletar_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Vendedor vend = new Class_Vendedor();
                vend.codigo = int.Parse(txtCodigo.Text);
              
                    vend.deletar();
                    GDVendedor.DataSource = vend.visualizar();
                
            }
            catch (Exception ex)
            {
                 Response.Write(ex.Message);
            }
}



        

        protected void GDVendedor_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Class_Vendedor vend = new Class_Vendedor();
            GDVendedor.EditIndex = -1;
            GDVendedor.EditIndex = e.NewEditIndex;
            GDVendedor.DataSource = vend.visualizar();
            GDVendedor.DataBind();
        
        }

        protected void GDVendedor_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Class_Vendedor vend = new Class_Vendedor();
            vend.codigo = int.Parse(e.NewValues[0].ToString());
            vend.nome = e.NewValues[1].ToString();
            vend.rua = e.NewValues[2].ToString();
            vend.numero = int.Parse(e.NewValues[3].ToString());
            vend.telefone = int.Parse(e.NewValues[4].ToString());
            vend.bairro = e.NewValues[5].ToString();
            vend.cidade = e.NewValues[7].ToString();
            vend.estado = e.NewValues[8].ToString();
            vend.logradouro = e.NewValues[6].ToString();
            vend.datanasc = DateTime.Parse(e.NewValues[9].ToString());
            vend.comissao = decimal.Parse(e.NewValues[10].ToString());
            vend.alterar_dados();

            GDVendedor.EditIndex = -1;
            GDVendedor.DataSource = vend.visualizar();
            GDVendedor.DataBind();
        }

             


        protected void Pesquisar_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GDVendedor_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Class_Vendedor vend = new Class_Vendedor();
            vend.codigo = int.Parse(e.Values[0].ToString());
            vend.deletar();

            GDVendedor.EditIndex = -1;
            GDVendedor.DataSource = vend.visualizar();
            GDVendedor.DataBind();
        }

     

       
    }
}
