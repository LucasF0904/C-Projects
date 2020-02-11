using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto
{
    public partial class CadastraVenda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["usuario"] == null)
                {
                    Response.Redirect("login.aspx");
                }
                else
                {
                    lblusuario.Text = Session["usuario"].ToString();
                }
                if (!IsPostBack)
                {
                    Class_Venda vend = new Class_Venda();  // cria o objeto vendedor                  
                    DropDownList1.DataSource = vend.visualizar(); // carrega os vendedores
                    DropDownList1.DataTextField = "CodigoVenda"; //associa o campo nome do banco de dados ao dropdown
                    DropDownList1.DataValueField = "CodigoVenda"; //associa o campo Matricula do banco de dados ao dropdown
                    DropDownList1.DataBind(); //constroi os dados na tela

                    Class_Venda venda = new Class_Venda(); // cria o objeto venda
                    GDVenda.DataSource = venda.visualizar(); //carrega todos as venda
                    GDVenda.DataBind();//constroi os dados na tela
                }

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
                Class_Venda vend = new Class_Venda();
                vend.codvenda = int.Parse(txtCodigoVenda.Text);
                vend.dataintrega = DateTime.Parse(txtDataEntrega.Text);
                vend.datavenda = DateTime.Parse(txtDataVenda.Text);
                vend.total = int.Parse(txtTotal.Text);
                vend.status = txtStatus.Text;
                vend.endereco = txtEndereco.Text;
                GDVenda.DataSource = vend.visualizar();
                GDVenda.DataBind();
                vend.cadastrar_novo();
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
                Class_Venda vend = new Class_Venda();
                GDVenda.DataSource = vend.visualizar();
                GDVenda.DataBind();
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
                Class_Venda vend = new Class_Venda();
                vend.codvenda = int.Parse(txtCodigoVenda.Text);
                vend.dataintrega = DateTime.Parse(txtDataEntrega.Text);
                vend.datavenda = DateTime.Parse(txtDataVenda.Text);
                vend.total = int.Parse(txtTotal.Text);
                vend.status = txtStatus.Text;
                vend.endereco = txtEndereco.Text;
                GDVenda.DataSource = vend.visualizar();
                GDVenda.DataBind();
                vend.alterar_dados();

                GDVenda.DataSource = vend.visualizar();
                GDVenda.DataBind();

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
                Class_Venda vend = new Class_Venda();
                vend.codvenda = int.Parse(txtCodigoVenda.Text);

                vend.deletar();
                GDVenda.DataSource = vend.visualizar();
                GDVenda.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void Pesquisar_Click(object sender, EventArgs e)
        {

        }

        protected void GDVenda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Class_Venda vend = new Class_Venda();
            vend.codvenda = int.Parse(e.NewValues[0].ToString());
            vend.datavenda = DateTime.Parse(e.NewValues[1].ToString());
            vend.dataintrega = DateTime.Parse(e.NewValues[2].ToString());
            vend.total = int.Parse(e.NewValues[3].ToString());
            vend.status = e.NewValues[4].ToString();
            vend.endereco = e.NewValues[5].ToString();
            vend.alterar_dados();

            GDVenda.EditIndex = -1;
            GDVenda.DataSource = vend.visualizar();
            GDVenda.DataBind();
        }

        protected void GDVenda_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Class_Venda vend = new Class_Venda();
            GDVenda.EditIndex = -1;
            GDVenda.EditIndex = e.NewEditIndex;
            GDVenda.DataSource = vend.visualizar();
            GDVenda.DataBind();
        }

        protected void GDVenda_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Class_Venda vend = new Class_Venda();
            vend.codvenda = int.Parse(e.Values[0].ToString());
            vend.deletar();

            GDVenda.EditIndex = -1;
            GDVenda.DataSource = vend.visualizar();
            GDVenda.DataBind();
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
             try
            {
                Session["usuario"] = null;
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        }
    }
