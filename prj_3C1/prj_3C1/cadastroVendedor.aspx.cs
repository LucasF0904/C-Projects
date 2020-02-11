using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prj_3C1
{
    public partial class cadastroVendedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    Class_Vendedor vend = new Class_Vendedor();
                    GridView1.DataSource = vend.visualizar();
                    GridView1.DataBind();
                }

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btn_Visualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Vendedor vend = new Class_Vendedor();
                GridView1.DataSource = vend.visualizar();
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btn_Inserir_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Vendedor vend = new Class_Vendedor();
                vend.matricula = txtmatricula.Text;
                vend.nome = txtnome.Text;
                vend.datanasc = DateTime.Parse(txtdatanasc.Text);
                vend.comissao = decimal.Parse(txtcomissao.Text);

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
                Class_Vendedor vend = new Class_Vendedor();
                vend.matricula = txtmatricula.Text;
                vend.nome = txtnome.Text;
                vend.datanasc = DateTime.Parse(txtdatanasc.Text);
                vend.comissao = decimal.Parse(txtcomissao.Text);

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
                Class_Vendedor vend = new Class_Vendedor();
                vend.matricula = txtmatricula.Text;
                vend.deletar();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                GridView1.EditIndex = e.NewEditIndex;
                Class_Vendedor vend = new Class_Vendedor();
                GridView1.DataSource = vend.visualizar();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            try
            {
                GridView1.EditIndex = -1;
                Class_Vendedor vend = new Class_Vendedor();
                GridView1.DataSource = vend.visualizar();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                Class_Vendedor vend = new Class_Vendedor();
                vend.matricula = e.NewValues[0].ToString();
                vend.nome = e.NewValues[1].ToString();
                vend.datanasc = DateTime.Parse(e.NewValues[2].ToString());
                vend.comissao = decimal.Parse(e.NewValues[3].ToString());

                vend.alterar_dados();

                GridView1.EditIndex = -1;

                GridView1.DataSource = vend.visualizar();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            try
            {
                Class_Vendedor vend = new Class_Vendedor();
                vend.matricula = e.Values[0].ToString();
                vend.deletar();

                GridView1.EditIndex = -1;
                GridView1.DataSource = vend.visualizar();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}