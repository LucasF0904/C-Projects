using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace revisao3B1
{
    public partial class CRUDCurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    Class_Conteudo conteudo = new Class_Conteudo();
                    txtcod_conteudo.DataSource = conteudo.visualizar();
                    txtcod_conteudo.DataTextField = "descricao_cont";
                    txtcod_conteudo.DataValueField = "cod_cont";
                    txtcod_conteudo.DataBind();

                    ClassCurso curso = new ClassCurso();
                    GridView1.DataSource = curso.visualizar();
                    GridView1.DataBind();
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
                ClassCurso curso = new ClassCurso();
                curso.cod_curso = int.Parse(txtcod_curso.Text);
                curso.cod_conteudo = int.Parse(txtcod_conteudo.Text);
                curso.datainicio_curso = DateTime.Parse(txtdatainicio.Text);
                curso.duracao_curso = double.Parse(txtduracao.Text);
                curso.valor_curso = decimal.Parse(txtvalor.Text);

                curso.cadastrar();

                GridView1.DataSource = curso.visualizar();
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
                ClassCurso curso = new ClassCurso();
                curso.cod_curso = int.Parse(txtcod_curso.Text);
                curso.cod_conteudo = int.Parse(txtcod_conteudo.Text);
                curso.datainicio_curso = DateTime.Parse(txtdatainicio.Text);
                curso.duracao_curso = double.Parse(txtduracao.Text);
                curso.valor_curso = decimal.Parse(txtvalor.Text);

                curso.alterar();

                GridView1.DataSource = curso.visualizar();
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
                ClassCurso curso = new ClassCurso();
                curso.cod_curso = int.Parse(txtcod_curso.Text);

                curso.excluir();

                GridView1.DataSource = curso.visualizar();
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

                ClassCurso curso = new ClassCurso();
                GridView1.DataSource = curso.visualizar();
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

                ClassCurso curso = new ClassCurso();
                curso.cod_curso = Convert.ToInt32(e.Values[0]);

                curso.excluir();

                GridView1.EditIndex = -1;


                GridView1.DataSource = curso.visualizar();
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
                ClassCurso curso = new ClassCurso();
                GridView1.EditIndex = e.NewEditIndex;
                
                GridView1.DataSource = curso.visualizar();
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
             
                ClassCurso curso = new ClassCurso();
                curso.cod_curso = Convert.ToInt32(e.NewValues[0]);
                curso.cod_conteudo = Convert.ToInt32(e.NewValues[1]);
                curso.datainicio_curso = Convert.ToDateTime(e.NewValues[2]);
                curso.duracao_curso = Convert.ToDouble(e.NewValues[3]);
                curso.valor_curso = Convert.ToDecimal(e.NewValues[4]);

                curso.alterar();
                
                GridView1.EditIndex = -1;


                GridView1.DataSource = curso.visualizar();
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

    }
}