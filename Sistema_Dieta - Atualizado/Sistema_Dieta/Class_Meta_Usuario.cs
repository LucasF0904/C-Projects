using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Sistema_Dieta
{
    public class Class_Meta_Usuario
    {
        public int id { get; set; }
        public int id_usuario { get; set; }
        public int id_meta { get; set; }

        public Class_DAL_Mysql dao = new Class_DAL_Mysql("localhost", "root", "", "sistema_controle_dieta");

        public void Inserir_Meta_Usuario()
        {
            try
            {
                string valores = string.Format("{0},'{1}','{2}'", id, id_usuario, id_meta);
                dao.Inserir_Registro("meta_usuario", valores);
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
                return dao.Pesquisar_Registro("meta_usuario", "id, id_meta", "id_usuario = " + id_usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Visualizar_Meta_Usuario()
        {
            try
            {
                string sql = "SELECT mu.id,meta.descricao FROM meta_usuario mu JOIN meta meta WHERE mu.id_meta = meta.id AND mu.id_usuario = " + id_usuario;
                return dao.ExecutaSelecaoSQL(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir_Meta_Usuario()
        {
            try
            {
                dao.Deletar_Registro("meta_usuario", "id = " + id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}