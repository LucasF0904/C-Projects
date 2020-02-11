using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace doemais
{
    public partial class frmDoacao : System.Web.UI.Page
    {
        Class_Doacao doacao = new Class_Doacao();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["tipo"].ToString() == "0")
                {
                    Response.Redirect("frmPrincipal.aspx");
                }
                else
                {
                    if (!IsPostBack)
                    {
                        doacao.receptor = int.Parse(Session["id"].ToString());
                        grdPesquisar.DataSource = doacao.BuscaMinhasDoacoes();
                        grdPesquisar.DataBind();
                    }

                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            
        }
        void Limpar()
        {
            txtinfo.InnerText = "";
            doacao.receptor = int.Parse(Session["id"].ToString());
            grdPesquisar.DataSource = doacao.BuscaMinhasDoacoes();
            grdPesquisar.DataBind();
        }
        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            doacao.status = 2;
            doacao.data = DateTime.Now;
            doacao.info = txtinfo.InnerText;
            doacao.receptor = int.Parse(Session["id"].ToString());
            doacao.Inserir();
            Limpar();
        }

        protected void grdPesquisar_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Excluir")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = grdPesquisar.Rows[index];
                doacao.codigo = int.Parse(row.Cells[1].Text);
                doacao.Excluir();
                Limpar();
            }
        }
    }
}