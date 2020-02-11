using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace Projeto
{
    public class Class_Venda
    {

        public int codvenda { get; set; }
        public DateTime datavenda { get; set; }
        public DateTime dataintrega { get; set; }
        public decimal total { get; set; }
        public string status { get; set; }
        public string endereco { get; set; }
        public List<Class_ItensVenda> itens = new List<Class_ItensVenda>();

        private Class_DAL_SQL dao = new Class_DAL_SQL("Projeto1.mdf");


        public Class_Venda(int codigo)
        {
            try
            {
                string condicao = string.Format("codvenda = '{0}'", codigo);
                DataTable dt = dao.Pesquisar_Registro("Venda", condicao);
                codvenda = Convert.ToInt32(dt.Rows[0][0]);
                datavenda = Convert.ToDateTime(dt.Rows[0][2]);
                dataintrega = Convert.ToDateTime(dt.Rows[0][3]);
                total = Convert.ToDecimal(dt.Rows[0][4]);
                status = dt.Rows[0][5].ToString();
                endereco = dt.Rows[0][6].ToString();               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Class_Venda()
        {
            try
            {
                itens = new List<Class_ItensVenda>();
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
                return dao.Visualizar_Registro("Venda");
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
                return dao.Pesquisar_Registro("Venda", condicao);
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
                string valores = string.Format("'{0}','{1}','{2}','{3}','{4}','{5}'", codvenda, datavenda.ToString("yyyy/MM/dd"), dataintrega.ToString("yyyy/MM/dd"), total.ToString().Replace(',', '.'),status, endereco);
                dao.Inserir_Registro("Venda", valores);
                codvenda = Convert.ToInt32(dao.ExecutaQuerySQL_ComRetorno("Venda", " max(CodigoVenda) "));
                
               
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
                string valores = string.Format("CodigoVenda = '{0}', datavenda = '{1}', dataintrega = '{2}', total = '{3}', status = '{4}', endereco = '{5}'", codvenda, datavenda.ToString("yyyy/MM/dd"), dataintrega.ToString("yyyy/MM/dd"), total.ToString().Replace(',', '.'), status, endereco);
                string condicao = string.Format("CodigoVenda = '{0}'", codvenda);
                dao.Alterar_Registro("Venda", valores, condicao);
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
                string condicao = string.Format("CodigoVenda = '{0}'", codvenda);
                dao.Deletar_Registro("Venda", condicao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }

}
    

