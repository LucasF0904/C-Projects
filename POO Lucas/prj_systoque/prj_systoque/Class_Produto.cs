using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace prj_systoque
{
    public class Class_Produto
    {
        public string cb {get;set;}
        public string nomeprod {get;set;}
        public decimal valorvenda {get;set;}
        public decimal qtdeprod {get;set;}
        public decimal qtdeminprod {get;set;}
        public DateTime datavalidade {get;set;}
        public string prazogarantia {get;set;}
        public string  lote {get;set;}

        private Class_DAL_SQL dao = new Class_DAL_SQL("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=bd_systoque;Integrated Security=True;");    
  
        public Class_Produto()
        {
        }

        public Class_Produto(string mat)
        {
            try
            {
                string condicao = string.Format("cb = '{0}'", cb);                
                DataTable dt = dao.Pesquisar_Registro("tbl_produto", condicao);
                cb = dt.Rows[0][0].ToString();
                nomeprod = dt.Rows[0][1].ToString();
                valorvenda = Convert.ToDecimal(dt.Rows[0][2]);
                qtdeprod = Convert.ToDecimal(dt.Rows[0][3]);
                qtdeminprod = Convert.ToDecimal(dt.Rows[0][4]);
                datavalidade = Convert.ToDateTime(dt.Rows[0][5]);
                prazogarantia = dt.Rows[0][6].ToString();
                lote = dt.Rows[0][7].ToString();
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
                return dao.Visualizar_Registro("tbl_produto");
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        public DataTable Pesquisar_CB_Produto()
        {
            try
            {
                string condicao = string.Format("cb = '{0}'", cb);
                return dao.Pesquisar_Registro("tbl_produto", condicao);
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
                string valores = string.Format("'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'", cb, nomeprod, valorvenda.ToString().Replace(',', '.'), qtdeprod.ToString().Replace(',', '.'), qtdeminprod.ToString().Replace(',', '.'), datavalidade.ToString("yyyy/MM/dd"), lote, prazogarantia);
                dao.Inserir_Registro("tbl_produto", valores);
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
                string valores = string.Format("nomeprod = '{0}', valorvenda = '{1}', qtdeprod = '{2}', qtdeminprod = '{3}', datavalidade = '{4}', lote = '{5}', prazogarantia='{6}'", nomeprod, valorvenda.ToString().Replace(',', '.'), qtdeprod.ToString().Replace(',', '.'), qtdeminprod.ToString().Replace(',', '.'), datavalidade.ToString("yyyy/MM/dd"), lote, prazogarantia);
                string condicao = string.Format("cb = '{0}'",cb);
                dao.Alterar_Registro("tbl_produto", valores, condicao);
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
                string condicao = string.Format("cb = '{0}'", cb);
                dao.Deletar_Registro("tbl_produto", condicao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
