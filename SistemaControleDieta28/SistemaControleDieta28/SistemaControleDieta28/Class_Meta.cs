using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using System.Data;

namespace SistemaControleDieta28
{
    public class Class_Meta
    {
        public int id { get; set; }
        public string  descricao { get; set; }


        public Class_DAL_Mysql dao = new Class_DAL_Mysql("localhost", "root", "", "sistema_controle_dieta");

        public void cadastrar()
        {
            try
            {
                string valores = string.Format("'{0}','{1}'", id, descricao);
                dao.Inserir_Registro("meta", valores);

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
                dao.Alterar_Registro("meta", values, cod);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Visualizar()
        {
            try
            {
                return dao.Visualizar_Registro("meta");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}