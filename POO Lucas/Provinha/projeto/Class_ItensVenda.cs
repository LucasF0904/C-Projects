using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace Projeto
{
    public class Class_ItensVenda
    {
        public int codlaboratorio { get; set; }
        public string nomelaboratorio { get; set; }
        public int codtecnicolaboratorio { get; set; }



        public Class_DAL_Mysql dao = new Class_DAL_Mysql("localhost", "root", "", "bd_farmacia");

        public Class_ItensVenda()
        {
        }

        public DataTable visualizar()
        {
            try
            {
                return dao.Visualizar_Registro("tbl_laboratorio");
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
                string condicao = string.Format("cod_laboratorio = '{0}'", codlaboratorio);
                return dao.Pesquisar_Registro("tbl_laboratorio", condicao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Calcular_valor_Item(decimal valorUnitario)
        {

        }

        public void cadastrar_novo()
        {
            try
            {
                string valores = string.Format("'{0}','{1}','{2}'", codlaboratorio, nomelaboratorio, codtecnicolaboratorio);
                dao.Inserir_Registro("tbl_laboratorio", valores);
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
                string valores = string.Format("cod_laboratorio = '{0}', nome_laboratorio = '{1}', cod_tecnico_laboratorio = '{2}'", codlaboratorio, nomelaboratorio, codtecnicolaboratorio);
                string condicao = string.Format("cod_laboratorio = '{0}'", codlaboratorio);
                dao.Alterar_Registro("tbl_laboratorio", valores, condicao);
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
                string condicao = string.Format("cod_laboratorio = '{0}'", codlaboratorio);
                dao.Deletar_Registro("tbl_laboratorio", condicao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
