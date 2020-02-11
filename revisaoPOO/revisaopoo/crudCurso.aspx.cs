using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace revisaoPOO
{
    public partial class crudCurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    ClassConteudo conteudo = new ClassConteudo();
                    cod_conteudo.DataSource = conteudo.Visualizarcurso();
                    cod_conteudo.DataTextField = "descricao_cont";
                    cod_conteudo.DataValueField = "cod_cont";
                    cod_conteudo.DataBind();

                    class_curso curso = new class_curso();
                    GridView1.DataSource = curso.Visualizarcurso();
                    GridView1.DataBind();
                }
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
                class_curso curso = new class_curso();
                curso.cod_curso = int.Parse(cod_curso.Text);
                curso.cod_conteudo = int.Parse(cod_conteudo.Text);
                curso.dataInicio_curso = DateTime.Parse(dataInicio_curso.Text);
                curso.duracao_curso = double.Parse(duracao_curso.Text);
                curso.valor_curso = decimal.Parse(valor_curso.Text);

                curso.AlterarCurso();

                GridView1.DataSource = curso.Visualizarcurso();
                GridView1.DataBind();
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }

        }

        protected void Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                class_curso curso = new class_curso();
                curso.cod_curso = int.Parse(cod_curso.Text);

                curso.Excluircurso();

                GridView1.DataSource = curso.Visualizarcurso();
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            
        }

        protected void Inserir_Click(object sender, EventArgs e)
        {
            try
            {
                class_curso curso = new class_curso();
                curso.cod_curso = int.Parse(cod_curso.Text);
                curso.cod_conteudo = int.Parse(cod_conteudo.Text);
                curso.dataInicio_curso = DateTime.Parse(dataInicio_curso.Text);
                curso.duracao_curso = double.Parse(duracao_curso.Text);
                curso.valor_curso = decimal.Parse(valor_curso.Text);

                curso.cadastrarcurso();

                GridView1.DataSource = curso.Visualizarcurso();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}