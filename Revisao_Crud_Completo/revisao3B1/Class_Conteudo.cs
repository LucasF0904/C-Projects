using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using System.Data;

namespace revisao3B1
{
    public class Class_Conteudo
    {
        public int cod_cont { get; set; }
        public string descricao_conteudo { get; set; }
        public int cargahoraria_cont { get; set; }

        public Class_DAL_Mysql dao = new Class_DAL_Mysql("localhost", "root", "", "bd_curso");

        public DataTable visualizar()
        {
            try
            {
                return dao.Visualizar_Registro("tbl_conteudo");
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
                string valores = string.Format("'{0}','{1}','{2}'", cod_cont, descricao_conteudo, cargahoraria_cont);
                dao.Inserir_Registro("tbl_conteudo", valores);
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
                string valores = string.Format(@"descricao_conteudo = '{0}', cargahoraria_cont ='{1}'", descricao_conteudo, cargahoraria_cont);
                dao.Alterar_Registro("tbl_conteudo", valores, "cod_cont = " + cod_cont);
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
                dao.Deletar_Registro("tbl_conteudo", "cod_cont = " + cod_cont);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}