using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace Projeto_01
{
    public class Class_ItensVenda
    {
        public int iditens { get; set; }
        public string cb { get; set; }
        public int codvenda { get; set; }
        public decimal valoritem { get; set; }
        public decimal qtdeitem { get; set; }


        private Class_DAL_SQL dao = new Class_DAL_SQL("Projeto1.mdf");

        public Class_ItensVenda()
        {
        }

        public DataTable visualizar()
        {
            try
            {
                return dao.Visualizar_Registro("ItensVenda");
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
                return dao.Pesquisar_Registro("ItensVenda", condicao);
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
                dao.Inserir_Registro("ItensVenda", valores);
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
                string valores = string.Format("cb = '{0}', cod_venda = '{1}', iditens = '{2}', qtdeitem = '{3}', valoritem = '{4}'", cb, codvenda , iditens, valoritem.ToString().Replace(',', '.'), qtdeitem.ToString().Replace(',', '.'));
                string condicao = string.Format("iditens = '{0}'", iditens);
                dao.Alterar_Registro("ItensVenda", valores, condicao);
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
                dao.Deletar_Registro("ItensVenda", condicao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
