using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prj_3C1
{
    public partial class Venda : System.Web.UI.Page
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
                    Class_Vendedor vend = new Class_Vendedor();  // cria o objeto vendedor                  
                    DropDownList1.DataSource = vend.visualizar(); // carrega os vendedores
                    DropDownList1.DataTextField = "nome"; //associa o campo nome do banco de dados ao dropdown
                    DropDownList1.DataValueField = "matricula"; //associa o campo Matricula do banco de dados ao dropdown
                    DropDownList1.DataBind(); //constroi os dados na tela

                    Class_Venda venda = new Class_Venda(); // cria o objeto venda
                    GridView1.DataSource = venda.visualizar(); //carrega todos as venda
                    GridView1.DataBind();//constroi os dados na tela
                }

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
                Class_Venda venda = new Class_Venda(); // cria o objeto venda
                venda.codvenda = int.Parse(txtcod_venda.Text); //Carrega os atributos do textbox
                venda.matricula = DropDownList1.SelectedValue;
                venda.datavenda = DateTime.Parse(txtdatavenda.Text);
                venda.datapreventrega = DateTime.Parse(txtdatapreventrega.Text);
                venda.totalvenda = decimal.Parse(txttotal.Text);
                venda.statusvenda = txtstatus.Text;
                venda.enderecoEntrega = txtendereco.Text;
                venda.cartaoCredito = int.Parse(txtcartao.Text);

                venda.cadastrar_novo(); //executa o cadastro
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
                Class_Venda venda = new Class_Venda();
                venda.codvenda = int.Parse(txtcod_venda.Text);
                venda.matricula = DropDownList1.SelectedValue;
                venda.datavenda = DateTime.Parse(txtdatavenda.Text);
                venda.datapreventrega = DateTime.Parse(txtdatapreventrega.Text);
                venda.totalvenda = decimal.Parse(txttotal.Text);
                venda.statusvenda = txtstatus.Text;
                venda.enderecoEntrega = txtendereco.Text;
                venda.cartaoCredito = int.Parse(txtcartao.Text);

                venda.alterar_dados();
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
                Class_Venda venda = new Class_Venda();
                venda.codvenda = int.Parse(txtcod_venda.Text);
      
                venda.deletar();
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
                Class_Venda venda = new Class_Venda();
                GridView1.DataSource = venda.visualizar();
                GridView1.DataBind();
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
                GridView1.EditIndex = e.NewEditIndex; //ativa a edição da linha selecionada
                Class_Venda venda = new Class_Venda();
                GridView1.DataSource = venda.visualizar();
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
                GridView1.EditIndex = -1; //cancela a edição da linha
                Class_Venda venda = new Class_Venda();
                GridView1.DataSource = venda.visualizar();
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
                Class_Venda venda = new Class_Venda();
                venda.codvenda = int.Parse(txtcod_venda.Text); //carrega os dados do gridview
                venda.matricula = DropDownList1.SelectedValue;
                venda.datavenda = DateTime.Parse(txtdatavenda.Text);
                venda.datapreventrega = DateTime.Parse(txtdatapreventrega.Text);
                venda.totalvenda = decimal.Parse(txttotal.Text);
                venda.statusvenda = txtstatus.Text;
                venda.enderecoEntrega = txtendereco.Text;
                venda.cartaoCredito = int.Parse(txtcartao.Text);

                venda.alterar_dados();

                GridView1.EditIndex = -1;

                GridView1.DataSource = venda.visualizar();
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
                Class_Venda venda = new Class_Venda();
                venda.codvenda = int.Parse(e.Values[0].ToString());
                venda.deletar();

                GridView1.EditIndex = -1;
                GridView1.DataSource = venda.visualizar();
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

        protected void btn_logout_Click(object sender, EventArgs e)
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
    }
}