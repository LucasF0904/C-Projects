using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using System.Data;

namespace SistemaControleDieta28
{
    public class Class_tipo_refeicao
    {
        public int id { get; set; }
        public string descricao { get; set; }

        public Class_DAL_Mysql dao = new Class_DAL_Mysql("localhost", "root", "", "sistema_controle_dieta");

        public void cadastrar()
        {
            try
            {
                string valores = string.Format("'{0}','{1}','{2}','{3}'", id, descricao);
                dao.Inserir_Registro("tipo_refeicao", valores);

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
                string values = string.Format("id = '{0}', descricao = '{1}'", id, descricao);
                string cod = string.Format("id = {0}", id);
                dao.Alterar_Registro("tipo_refeicao", values, cod);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Pesquisa_email(string condicao)
        {
            try
            {
                return dao.Pesquisar_Registro("tipo_refeicao", "*", condicao);
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
                return dao.Visualizar_Registro("tipo_refeicao");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}