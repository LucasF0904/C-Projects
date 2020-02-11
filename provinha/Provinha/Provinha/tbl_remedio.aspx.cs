using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Provinha
{
    public partial class tbl_remedio : System.Web.UI.Page
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
                   tblNome_remedio.Text = Session["usuario"].ToString();
                }
                if (!IsPostBack)
                {
               
                    Class_Remedio remedio = new Class_Remedio();  // cria o objeto vendedor                  
                    txtprincipioativo.DataSource = remedio.visualizar(); // carrega os vendedores
                    txtprincipioativo.DataTextField = "cod_remedio"; //associa o campo nome do banco de dados ao dropdown
                    txtprincipioativo.DataValueField = "cod_remedio"; //associa o campo Matricula do banco de dados ao dropdown
                    txtprincipioativo.DataBind(); //constroi os dados na tela

                    Class_Remedio venda = new Class_Remedio(); // cria o objeto venda
                    GridView1.DataSource = venda.visualizar(); //carrega todos as venda
                    GridView1.DataBind();//constroi os dados na tela
                
        }
                         }

            
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }


        protected void btn_inserir_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Remedio remedio = new Class_Remedio();
                remedio.cod_remedio = int.Parse(tbl_codRemedio.Text);
                remedio.nome_remedio = tblNome_remedio.Text;
                remedio.descricao_remedio = tblNome_remedio.Text;
                remedio.principioativo_remedio = txtprincipioativo.Text;
                remedio.cod_laboratorio =int.Parse(tblCod_laboratorio.Text);
                remedio.quantidade_remedio = int.Parse(tblQuantidade_remedio.Text);
                remedio.valor_remedio = double.Parse(tblValor_remedio.Text);

                remedio.cadastrar();

                GridView1.DataSource = remedio.visualizar();
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Remedio remedio = new Class_Remedio();
                remedio.cod_remedio = int.Parse(tbl_codRemedio.Text);
                remedio.nome_remedio = tblNome_remedio.Text;
                remedio.descricao_remedio = tblNome_remedio.Text;
                remedio.principioativo_remedio = txtprincipioativo.Text;
                remedio.cod_laboratorio = int.Parse(tblCod_laboratorio.Text);
                remedio.quantidade_remedio = int.Parse(tblQuantidade_remedio.Text);
                remedio.valor_remedio = double.Parse(tblValor_remedio.Text);

                remedio.alterar();

                GridView1.DataSource = remedio.visualizar();
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Remedio remedio = new Class_Remedio();
                remedio.cod_remedio = int.Parse(tbl_codRemedio.Text);

                remedio.excluir();

                GridView1.DataSource = remedio.visualizar();
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

                Class_Remedio remedio = new Class_Remedio();
                GridView1.DataSource = remedio.visualizar();
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

                Class_Remedio remedio = new Class_Remedio();
               remedio.cod_remedio = Convert.ToInt32(e.Values[0]);

                remedio.excluir();

                GridView1.EditIndex = -1;


                GridView1.DataSource = remedio.visualizar();
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
                Class_Remedio remedio = new Class_Remedio();
                GridView1.EditIndex = e.NewEditIndex;

                GridView1.DataSource = remedio.visualizar();
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

                Class_Remedio remedio = new Class_Remedio();

                remedio.cod_remedio = Convert.ToInt32(e.NewValues[0]);
                remedio.nome_remedio = tblNome_remedio.Text;
                remedio.descricao_remedio = tblNome_remedio.Text;
                remedio.principioativo_remedio = txtprincipioativo.Text;
                remedio.cod_laboratorio = Convert.ToInt32(e.NewValues[4]);
                remedio.quantidade_remedio = Convert.ToInt32(e.NewValues[5]);
                remedio.valor_remedio = Convert.ToDouble(e.NewValues[6]);

               

                remedio.alterar();

                GridView1.EditIndex = -1;


                GridView1.DataSource = remedio.visualizar();
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }


    }
}