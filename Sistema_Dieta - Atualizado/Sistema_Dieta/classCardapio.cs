using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DAL;

namespace Sistema_Dieta
{    
    public class classCardapio
    {
        public int id { get; set; }
        public int id_tipo_refeicao { get; set; }
        public int id_usuario { get; set; }
        public int id_alimento { get; set; }
        public int porcao { get; set; }
        
        private Class_DAL_Mysql dao = new Class_DAL_Mysql("localhost", "root", "", "sistema_controle_dieta");

        public void cadastra()
        {
            try
            {
                string sql = string.Format("'{0}','{1}','{2}','{3}','{4}'", id, id_tipo_refeicao, id_usuario, id_alimento, porcao);
                dao.Inserir_Registro("cardapio_usuario", sql);
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
                string sql = string.Format("id_tipo_refeicao = '{0}',id_usuario = '{1}',id_alimento = '{2}',porcao = '{3}'", id_tipo_refeicao, id_usuario, id_alimento, porcao);
                string condicao = string.Format("id = '{0}'", id);
                dao.Alterar_Registro("cardapio_usuario", sql, condicao);
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
                string sql = string.Format("id = '{0}'", id);
                dao.Deletar_Registro("cardapio_usuario", sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable PesquisarTipoRefeicao()
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

        public DataTable PesquisarAlimento()
        {
            try
            {
                return dao.Visualizar_Registro("alimento");
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

        public DataTable Visualizar_PorUsuario()
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

        public DataTable Visualizar_PorCampos(string condicao)
        {
            try
            {                
                return dao.Pesquisar_Registro("cardapio_usuario", condicao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable VisualizarCardapioCompleto()
        {
            try
            {
                return dao.Visualizar_Registro("((cardapio_usuario join tipo_refeicao on cardapio_usuario.id_tipo_refeicao = tipo_refeicao.id) join usuario on cardapio_usuario.id_usuario = usuario.id) join alimento on cardapio_usuario.id_alimento = alimento.id");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable FeedCaloriasTotais()
        {
            try
            {
                return dao.ExecutaSelecaoSQL("select *,(cardapio_usuario.porcao * alimento.calorias)as calorias_Totais from (cardapio_usuario join alimento on cardapio_usuario.id_alimento = alimento.id) join tipo_refeicao on cardapio_usuario.id_tipo_refeicao = tipo_refeicao.id where cardapio_usuario.id_usuario = " + id_usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}