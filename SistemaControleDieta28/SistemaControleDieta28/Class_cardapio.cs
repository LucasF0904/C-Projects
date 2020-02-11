using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using System.Data;

namespace SistemaControleDieta28
{
    public class Class_cardapio
    {
        public int id { get; set; }
        public int id_tipo_refeicao { get; set; }
        public int id_usuario { get; set; }
        public int id_alimento { get; set; }
        public int porcao { get; set; } 

        public Class_DAL_Mysql dao = new Class_DAL_Mysql("localhost", "root", "", "sistema_controle_dieta");

        public void cadastrar()
        {
            try
            {
                string valores = string.Format("'{0}','{1}','{2}','{3}','{4}'", id, id_tipo_refeicao, id_usuario, id_alimento, porcao);
                dao.Inserir_Registro("cardapio_usuario", valores);

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
                string values = string.Format("id = '{0}', id_tipo_refeicao = '{1}', id_usuario = '{2}', id_alimento = '{3}', porcao = '{4}'", id, id_tipo_refeicao, id_usuario, id_alimento, porcao);
                string cod = string.Format("id = {0}", id);
                dao.Alterar_Registro("cardapio_usuario", values, cod);
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
                return dao.Visualizar_Registro("cardapio_usuario");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}