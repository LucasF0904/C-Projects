using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace VENDAS
{
    public class Class_ItensVenda
    {
        public int iditens {get;set;}
        public string cb {get;set;}
        public int codvenda {get;set;}
        public decimal valoritem {get;set;}
        public decimal qtdeitem { get; set; }


        Class_DAL_Mysql dao = new Class_DAL_Mysql("localhost", "root", "", "venda");
  
        public Class_ItensVenda()
        {            
        }

        public DataTable visualizar()
        {
            try
            {
                return dao.Visualizar_Registro("tbl_itens_Venda");
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        public DataTable Pesquisar_itens_Venda()
        {
            try
            {
                string condicao = string.Format("cb = '{0}'", cb);
                return dao.Pesquisar_Registro("tbl_itens_Venda", condicao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Calcular_valor_Item(decimal valorUnitario)
        {
            try
            {
                valoritem = qtdeitem * valorUnitario;
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
                string valores = string.Format("'{0}','{1}','{2}','{3}','{4}'", iditens, cb, codvenda, valoritem.ToString().Replace(',', '.'), qtdeitem.ToString().Replace(',', '.'));
                dao.Inserir_Registro("tbl_itens_Venda", valores);
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
                string valores = string.Format("cb = '{0}', codvenda = '{1}', valoritem = '{2}', qtdeitem = '{3}'", cb, codvenda, valoritem.ToString().Replace(',', '.'), qtdeitem.ToString().Replace(',', '.'));
                string condicao = string.Format("iditens = '{0}'", iditens);
                dao.Alterar_Registro("tbl_itens_Venda", valores, condicao);
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
                string condicao = string.Format("iditens = '{0}'", iditens);
                dao.Deletar_Registro("tbl_itens_Venda", condicao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
