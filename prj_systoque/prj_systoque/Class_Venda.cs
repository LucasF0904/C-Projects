using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace prj_systoque
{
    public class Class_Venda
    {
        public int codvenda { get; set; }
        public string matricula { get; set; }
        public DateTime datavenda { get; set; }
        public DateTime datapreventrega { get; set; }
        public decimal totalvenda { get; set; }
        public string statusvenda { get; set; }
        public string enderecoEntrega { get; set; }
        public int cartaoCredito { get; set; }

        public List<Class_ItensVenda> itens {get;set;}

        private Class_DAL_SQL dao = new Class_DAL_SQL("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=bd_systoque;Integrated Security=True;");

        public Class_Venda()
        {
            itens = new List<Class_ItensVenda>(); 
        }

        public Class_Venda(int codigo)
        {
            try
            {
                itens = new List<Class_ItensVenda>(); 
                string condicao = string.Format("codvenda = '{0}'", codigo);                
                DataTable dt = dao.Pesquisar_Registro("tbl_venda", condicao);
                codvenda = Convert.ToInt32(dt.Rows[0][0]);
                matricula = dt.Rows[0][1].ToString();
                datavenda = Convert.ToDateTime(dt.Rows[0][2]);
                datapreventrega = Convert.ToDateTime(dt.Rows[0][3]);
                totalvenda = Convert.ToDecimal(dt.Rows[0][4]);
                statusvenda = dt.Rows[0][5].ToString();
                enderecoEntrega = dt.Rows[0][6].ToString();
                cartaoCredito = Convert.ToInt32(dt.Rows[0][7]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable visualizar()
        {
            try
            {
                return dao.Visualizar_Registro("tbl_venda");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Pesquisar_data_venda()
        {
            try
            {
                string condicao = string.Format("datavenda = '{0}'", datavenda.ToString("yyyy/MM/dd"));
                return dao.Pesquisar_Registro("tbl_venda", condicao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void cadastrar_novo()
        {
            try
            {
                string valores = string.Format("'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'", codvenda, matricula ,datavenda.ToString("yyyy/MM/dd") , datapreventrega.ToString("yyyy/MM/dd") , totalvenda.ToString().Replace(',', '.') ,statusvenda , enderecoEntrega, cartaoCredito);
                dao.Inserir_Registro("tbl_venda", valores);
                codvenda = Convert.ToInt32( dao.ExecutaQuerySQL_ComRetorno("tbl_venda", "max(codvenda)") );
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void alterar_dados()
        {
            try
            {
                string valores = string.Format("matricula = '{0}', datavenda = '{1}', datapreventrega = '{2}', totalvenda = '{3}', statusvenda = '{4}', enderecoEntrega = '{5}', cartaoCredito='{6}'", matricula, datavenda.ToString("yyyy/MM/dd"), datapreventrega.ToString("yyyy/MM/dd"), totalvenda.ToString().Replace(',', '.'), statusvenda, enderecoEntrega, cartaoCredito);
                string condicao = string.Format("codvenda = '{0}'", codvenda);
                dao.Alterar_Registro("tbl_venda", valores, condicao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void deletar()
        {
            try
            {
                string condicao = string.Format("codvenda = '{0}'", codvenda);
                dao.Deletar_Registro("tbl_venda", condicao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
