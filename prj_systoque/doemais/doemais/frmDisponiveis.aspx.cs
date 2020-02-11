using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace doemais
{
    public partial class frmDisponiveis : System.Web.UI.Page
    {
        Class_Usuario usuario = new Class_Usuario();
        Class_Doacao doacao = new Class_Doacao();
        void gerar()
        {
            string condicao = string.Format("id = '{0}'", Session["id"].ToString());
            DataTable dt = usuario.Buscausuariopor(condicao);
            switch (dt.Rows[0]["tipo_sangue"].ToString())
            {
                case "AB":
                    if (dt.Rows[0]["rh"].ToString() == "Positivo")
                    {
                        grdPesquisar.DataSource = doacao.Buscadoacoes("r.tipo_sangue = 'AB' AND r.rh = 'Positivo' AND d.status = 2");
                        grdPesquisar.DataBind();
                    }
                    else
                    {
                        grdPesquisar.DataSource = doacao.Buscadoacoes("r.tipo_sangue = 'AB' AND d.status = 2");
                        grdPesquisar.DataBind();
                    }
                    break;
                case "A":
                    if (dt.Rows[0]["rh"].ToString() == "Positivo")
                    {
                        grdPesquisar.DataSource = doacao.Buscadoacoes("r.tipo_sangue = 'A' OR r.tipo_sangue = 'AB' AND r.rh = 'Positivo' AND d.status = 2");
                        grdPesquisar.DataBind();
                    }
                    else
                    {
                        grdPesquisar.DataSource = doacao.Buscadoacoes("r.tipo_sangue = 'A' OR r.tipo_sangue = 'AB' AND d.status = 2");
                        grdPesquisar.DataBind();
                    }
                    break;
                case "B":
                    if (dt.Rows[0]["rh"].ToString() == "Positivo")
                    {
                        grdPesquisar.DataSource = doacao.Buscadoacoes("r.tipo_sangue = 'B' OR r.tipo_sangue = 'AB' AND r.rh = 'Positivo' AND d.status = 2");
                        grdPesquisar.DataBind();
                    }
                    else
                    {
                        grdPesquisar.DataSource = doacao.Buscadoacoes("r.tipo_sangue = 'B' OR r.tipo_sangue = 'AB' AND d.status = 2");
                        grdPesquisar.DataBind();
                    }
                    break;
                case "O":
                    if (dt.Rows[0]["rh"].ToString() == "Positivo")
                    {
                        grdPesquisar.DataSource = doacao.Buscadoacoes("r.rh = 'Positivo' AND d.status = 2");
                        grdPesquisar.DataBind();
                    }
                    else
                    {
                        grdPesquisar.DataSource = doacao.Buscadoacoes("r.tipo_sangue = 'AB' OR r.tipo_sangue = 'A' OR r.tipo_sangue = 'B' OR r.tipo_sangue = 'O' AND d.status = 2");
                        grdPesquisar.DataBind();
                    }
                    break;
            }
    
        }

        
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    if (Session["tipo"].ToString() == "0")
                    {
                        Response.Redirect("frmPrincipal.aspx");
                    }
                    else
                    {
                        gerar();
                    }
                }
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }

        }
        protected void grdPesquisar_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Doar")
            {
                try
                {
                    int index = Convert.ToInt32(e.CommandArgument);
                    GridViewRow row = grdPesquisar.Rows[index];
                    doacao.doador = int.Parse(Session["id"].ToString());
                    doacao.codigo = int.Parse(row.Cells[1].Text);
                    doacao.Doar();
                    gerar();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
        }
    }
}