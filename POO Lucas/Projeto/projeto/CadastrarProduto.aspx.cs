using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto
{
    public partial class CadastrarProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Pesquisar_Click(object sender, EventArgs e)
        {

        }

        protected void Deletar_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Produto vend = new Class_Produto();
                vend.cb = txtcb.Text;

                vend.deletar();
                GDProduto.DataSource = vend.visualizar();
                GDProduto.DataBind();

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
                Class_Produto vend = new Class_Produto();
                vend.cb = txtcb.Text;
                vend.cb = txtcb.Text;
                vend.nomeprod = txtnomeprod.Text;
                vend.valorvenda = int.Parse(txtvalorvenda.Text);
                vend.qtdeprod = int.Parse(txtqtdeprod.Text);
                vend.qtdeminprod = int.Parse(txtqtdeminprod.Text);
                vend.datavalidade = DateTime.Parse(txtvalorvenda.Text);
                vend.prazogarantia = txtprazogarantia.Text;
                vend.lote = txtLote.Text;

                vend.alterar_dados();

                GDProduto.DataSource = vend.visualizar();
                GDProduto.DataBind();

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
                Class_Produto vend = new Class_Produto();
                GDProduto.DataSource = vend.visualizar();
                GDProduto.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Produto vend = new Class_Produto();               
                vend.cb = txtcb.Text;
                vend.nomeprod = txtnomeprod.Text;
                vend.valorvenda = decimal.Parse(txtvalorvenda.Text);
                vend.qtdeprod = decimal.Parse(txtqtdeprod.Text);
                vend.qtdeminprod = decimal.Parse(txtqtdeminprod.Text);
                vend.datavalidade = DateTime.Parse(txtDataValidade.Text);
                vend.prazogarantia = txtprazogarantia.Text;
                vend.lote = txtLote.Text;

                vend.cadastrar_novo();
           }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void GDProduto_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Class_Produto vend = new Class_Produto();
            GDProduto.EditIndex = -1;
            GDProduto.EditIndex = e.NewEditIndex;
            GDProduto.DataSource = vend.visualizar();
            GDProduto.DataBind();
        }

        protected void GDProduto_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Class_Produto vend = new Class_Produto();
            vend.cb = e.NewValues[0].ToString();
            vend.nomeprod = e.NewValues[1].ToString();
            vend.valorvenda = int.Parse(e.NewValues[2].ToString());
            vend.qtdeprod = int.Parse(e.NewValues[3].ToString());
            vend.qtdeminprod = int.Parse(e.NewValues[4].ToString());
            vend.datavalidade = DateTime.Parse(e.NewValues[5].ToString());
            vend.prazogarantia = e.NewValues[6].ToString();
            vend.lote = e.NewValues[7].ToString();
            
            vend.alterar_dados();

            GDProduto.EditIndex = -1;
            GDProduto.DataSource = vend.visualizar();
            GDProduto.DataBind();
        }

        protected void GDProduto_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Class_Produto vend = new Class_Produto();
            vend.cb = e.Values[0].ToString();
            vend.deletar();

            GDProduto.EditIndex = -1;
            GDProduto.DataSource = vend.visualizar();
            GDProduto.DataBind();
        }
    }
}