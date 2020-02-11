using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Sistema_Dieta
{
    public class Class_Meta
    {
        public int id { get; set; }
        public string descricao { get; set; }

        public Class_DAL_Mysql dao = new Class_DAL_Mysql("localhost", "root", "", "sistema_controle_dieta");

        public void Inserir_Meta()
        {
            try
            {
                string valores = string.Format("{0},'{1}'", id, descricao);
                dao.Inserir_Registro("meta", valores);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Visualizar_Meta()
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