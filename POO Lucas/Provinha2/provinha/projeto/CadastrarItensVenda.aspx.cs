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
                vend.codlaboratorio = int.Parse(txtcodlab.Text);
                vend.nomelaboratorio = txtnomelab.Text;
                vend.codtecnicolaboratorio = int.Parse(txtcodteclab.Text);

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
                vend.codlaboratorio = int.Parse(txtcodlab.Text);
                vend.nomelaboratorio = txtnomelab.Text;
                vend.codtecnicolaboratorio = int.Parse(txtcodteclab.Text);

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
                vend.codlaboratorio = int.Parse(txtcodlab.Text);

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

        protected void GDItemVenda_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {

                Class_ItensVenda classe = new Class_ItensVenda();
                classe.codlaboratorio = Convert.ToInt32(e.Values[0]);

                classe.deletar();

                GDItemVenda.EditIndex = -1;


                GDItemVenda.DataSource = classe.visualizar();
                GDItemVenda.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void GDItemVenda_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {

                Class_ItensVenda classe = new Class_ItensVenda();
                classe.codlaboratorio = Convert.ToInt32(e.NewValues[0]);
                classe.nomelaboratorio = e.NewValues[1].ToString();
                classe.codtecnicolaboratorio = Convert.ToInt32(e.NewValues[2]);


                classe.deletar();

                GDItemVenda.EditIndex = -1;


                GDItemVenda.DataSource = classe.visualizar();
                GDItemVenda.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void GDItemVenda_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                Class_ItensVenda classe = new Class_ItensVenda();
                GDItemVenda.EditIndex = e.NewEditIndex;

                GDItemVenda.DataSource = classe.visualizar();
                GDItemVenda.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}