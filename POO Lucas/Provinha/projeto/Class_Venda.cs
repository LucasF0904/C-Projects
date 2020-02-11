using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace Projeto
{
    public class Class_Venda
    {

        public int codremedio { get; set; }
        public string nomeremedio { get; set; }
        public string descricaoremedio { get; set; }
        public string principioativoremedio { get; set; }
        public int codlab { get; set; }
        public int qtdremedio { get; set; }
        public double valorremedio { get; set; }
        public List<Class_ItensVenda> itens = new List<Class_ItensVenda>();

        public Class_DAL_Mysql dao = new Class_DAL_Mysql("localhost", "root", "", "bd_farmacia");


        public Class_Venda(int codigo)
        {
            try
            {
                string condicao = string.Format("cod_remedio = '{0}'", codigo);
                DataTable dt = dao.Pesquisar_Registro("tbl_remedio", condicao);
                codremedio = Convert.ToInt32(dt.Rows[0][0]);
                nomeremedio = dt.Rows[0][1].ToString();
                descricaoremedio = dt.Rows[0][2].ToString();
                principioativoremedio = dt.Rows[0][3].ToString();
                codlab = Convert.ToInt32(dt.Rows[0][4]);
                qtdremedio = Convert.ToInt32(dt.Rows[0][5]);
                valorremedio = Convert.ToInt32(dt.Rows[0][6]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Class_Venda()
        {
            try
            {
                itens = new List<Class_ItensVenda>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable visualizar()
        {
            try
            {
                return dao.Visualizar_Registro("tbl_remedio");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Pesquisar_data_venda()
        {
            try
            {
                string condicao = string.Format("nome_remedio = '{0}'", nomeremedio);
                return dao.Pesquisar_Registro("tbl_remedio", condicao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void cadastrar_novo()
        {
           try
            {
                string valores = string.Format("'{0}','{1}','{2}','{3}','{4}','{5}','{6}'", codremedio, nomeremedio, descricaoremedio, principioativoremedio, codlab, qtdremedio, valorremedio.ToString().Replace(',', '.'));
                dao.Inserir_Registro("tbl_remedio", valores);
                codremedio = Convert.ToInt32(dao.ExecutaQuerySQL_ComRetorno("tbl_remedio", " max(cod_remedio) "));
                
               
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
                string valores = string.Format("nome_remedio = '{0}', descricao_remedio = '{1}', principioativo_remedio = '{2}', cod_laboratorio = '{3}', quantidade_remedio = '{4}', valor_remedio = '{5}'",nomeremedio, descricaoremedio, principioativoremedio, codlab, qtdremedio, valorremedio.ToString().Replace(',', '.'));
                string condicao = string.Format("cod_remedio = '{0}'", codremedio);
                dao.Alterar_Registro("tbl_remedio", valores, condicao);
           }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void deletar()
        {
            try
            {
                string condicao = string.Format("cod_remedio = '{0}'", codremedio);
                dao.Deletar_Registro("tbl_remedio", condicao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }

}
    

