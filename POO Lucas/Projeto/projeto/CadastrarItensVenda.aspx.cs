using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto
{
    public partial class CadastrarItensVenda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Class_ItensVenda vend = new Class_ItensVenda();
                vend.cb = txtcb.Text;
                vend.codvenda = int.Parse(txtcodvenda.Text);
                vend.iditens = int.Parse(txtIDitem.Text);
                vend.qtdeitem = int.Parse(txtqtdeitem.Text);
                vend.valoritem = int.Parse(txtValorItem.Text);

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
                Class_ItensVenda vend = new Class_ItensVenda();
                vend.cb = txtcb.Text;
                vend.codvenda = int.Parse(txtcodvenda.Text);
                vend.iditens = int.Parse(txtIDitem.Text);
                vend.qtdeitem = int.Parse(txtqtdeitem.Text);
                vend.valoritem = int.Parse(txtValorItem.Text);

                vend.alterar_dados();

                GDItemVenda.DataSource = vend.visualizar();
                GDItemVenda.DataBind();

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
                Class_ItensVenda vend = new Class_ItensVenda();
                vend.cb = txtcb.Text;

                vend.deletar();
                GDItemVenda.DataSource = vend.visualizar();
                GDItemVenda.DataBind();

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
                Class_ItensVenda vend = new Class_ItensVenda();
                GDItemVenda.DataSource = vend.visualizar();
                GDItemVenda.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}