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
        public double total_calorias { get; set; }

        public Class_DAL_Mysql dao = new Class_DAL_Mysql("localhost", "root", "", "sistema_controle_dieta");

        public void Calorias_Total()
        {
            total_calorias = Convert.ToDouble(dao.ExecutaQuerySQL_ComRetorno("cardapio_usuario c JOIN alimento a ON c.id_alimento = a.id WHERE c.id_usuario = " + id_usuario, "SUM(a.calorias * c.porcao)"));
        }
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


    }
}