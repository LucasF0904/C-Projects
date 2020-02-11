using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DAL;

namespace SistemaControleDieta28
{
    public class Class_Perfil_Alimentar
    {
        public int id { get; set; }
        public int id_usuario { get; set; }
        public int qtde_refeicoes_dia { get; set; }

        public Class_DAL_Mysql dao = new Class_DAL_Mysql("localhost", "root", "", "sistema_controle_dieta");

        public void cadastrar()
        {
            try
            {
                string valores = string.Format("'{0}','{1}','{2}'", id, id_usuario, qtde_refeicoes_dia);
                dao.Inserir_Registro("perfil_alimentar", valores);

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
                string values = string.Format("id = '{0}', id_usuario = '{1}', qtde_refeicoes_dia = '{2}'", id, id_usuario, qtde_refeicoes_dia);
                string cod = string.Format("id = {0}", id);
                dao.Alterar_Registro("perfil_alimentar", values, cod);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Visualizar_porusuario()
        {
            try
            {
                string condicao = string.Format("id_usuario  = '{0}'", id_usuario);
                return dao.Pesquisar_Registro("cardapio_usuario", condicao);
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
                return dao.Visualizar_Registro("perfil_alimentar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
    }
