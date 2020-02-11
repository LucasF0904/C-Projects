using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using System.Data;

namespace Provinha
{
    public class Class_Remedio
    {
        public int cod_remedio { get; set; }
        public string nome_remedio { get; set; }
        public string descricao_remedio { get; set; }
        public string principioativo_remedio { get; set; }
        public int cod_laboratorio { get; set; }
        public int quantidade_remedio{ get; set; }
        public double valor_remedio { get; set; }

        public Class_DAL_Mysql dao = new Class_DAL_Mysql("localhost", "root", "", "bd_farmacia");

        public DataTable visualizar()
        {
            try
            {
                return dao.Visualizar_Registro("tbl_remedio");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void cadastrar()
        {
            try
            {
                string valores = string.Format("'{0}','{1}','{2}','{3}','{4}','{5}','{6}'", cod_remedio, nome_remedio, descricao_remedio, principioativo_remedio, cod_laboratorio, quantidade_remedio, valor_remedio);
                dao.Inserir_Registro("tbl_remedio", valores);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void alterar()
        {
            try
            {
                string valores = string.Format(@"nome_remedio = '{0}', descricao_remedio ='{1}', principioativo_remedio ='{2}', quantidade_remedio ='{3}', valor_remedio ='{4}'", nome_remedio, descricao_remedio, principioativo_remedio, quantidade_remedio, valor_remedio);
                dao.Alterar_Registro("tbl_remedio", valores, "cod_remedio = " + cod_remedio);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void excluir()
        {
            try
            {
                dao.Deletar_Registro("tbl_remedio", "cod_remedio = " + cod_remedio);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}