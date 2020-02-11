using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using System.Data;

namespace Sistema_Dieta
{
    public class Class_Perfil_Alimentar
    {

      
        Class_DAL_Mysql dao = new Class_DAL_Mysql("localhost", "root", "", "sistema_controle_dieta");

        public int id { get; set; }
        public int id_usuario { get; set; }
        public int qtde_refeicoes_dia { get; set; }      
        


        public void Alterar()
        {
            try
            {
                dao.Alterar_Registro("perfil_alimentar", " qtde_refeicoes_dia = '" + qtde_refeicoes_dia + "'", " id = '" + id + "'");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Excluir()
        {
            try
            {
                dao.Deletar_Registro("perfil_alimentar", " id = '" + id + "' ");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Inserir()
        {

            try
            {
                dao.Inserir_Registro("perfil_alimentar", "null, '" + id_usuario + "','" + qtde_refeicoes_dia + "'");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable Pesquisar()
        {
            try
            {
                return dao.Pesquisar_Registro("perfil_alimentar", "id_usuario = " + id_usuario + " ");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }     
    }
}