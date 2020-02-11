using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using System.Data;

namespace Sistema_Dieta
{
    public class Classe_Perfil_Atividades
    {
        
        Class_DAL_Mysql dao = new Class_DAL_Mysql("localhost", "root", "", "sistema_controle_dieta");

        public int id { get; set; }
        public int id_usuario { get; set; }
        public int frequencia_semanal { get; set; }
        public int intensidade { get; set; }
        public int media_queima_calorias_semanal { get; set; }


        public void Inserir_perfil_atividade()
        {

            try
            {
                dao.Inserir_Registro("perfil_atividades", "null,'" + id_usuario + "','" + frequencia_semanal + "','" + intensidade + "','" + media_queima_calorias_semanal + "'");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable Pesquisar_perfil_atividades()
        {
            try
            {
                return dao.Pesquisar_Registro("perfil_atividades", "id_usuario = " + id_usuario + " ");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Alterar_perfil_atividade()
        {
            try
            {
                dao.Alterar_Registro("perfil_atividades", " frequencia_semanal = '" + frequencia_semanal + "', intensidade = '" + intensidade + "', media_queima_calorias_semana = '" + media_queima_calorias_semanal + "'", "id='"+id+"'");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Excluir_perfil_atividade()
        {
            try
            {
                dao.Deletar_Registro("perfil_atividades", " id = '" + id + "' ");
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}