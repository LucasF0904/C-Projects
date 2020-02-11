using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace prj_3C1
{
    public class Class_Vendedor
    {
        public string matricula {get;set;}
        public string nome {get;set;}
        public DateTime datanasc {get;set;}
        public decimal comissao {get;set;}

        private Class_DAL_SQL dao = new Class_DAL_SQL("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=bd_systoque;Integrated Security=True;");

        public Class_Vendedor()
        {
        }

        public Class_Vendedor(string mat)
        {
            try
            {
                DataTable dt = dao.Pesquisar_Registro("tbl_vendedor","matricula = " + matricula);
                matricula = dt.Rows[0][0].ToString();
                nome = dt.Rows[0][1].ToString();
                datanasc = Convert.ToDateTime(dt.Rows[0][2]);
                comissao = Convert.ToDecimal(dt.Rows[0][3]);
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
                return dao.Visualizar_Registro("tbl_vendedor");
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        public DataTable Pesquisar_Nome_vendedor()
        {
            try
            {
                return dao.Pesquisar_Registro("tbl_vendedor","nome like '%" + nome + "%'");
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
                string valores = string.Format("'{0}','{1}','{2}','{3}'",matricula,nome,datanasc.ToString("yyyy/MM/dd"),comissao.ToString().Replace(',','.'));
                dao.Inserir_Registro("tbl_vendedor", valores);
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
                string valores = string.Format("nome = '{0}', datanasc = '{1}', comissao = '{2}'", nome, datanasc.ToString("yyyy/MM/dd"), comissao.ToString().Replace(',', '.'));
                string condicao = string.Format("matricula = '{0}'",matricula);
                dao.Alterar_Registro("tbl_vendedor", valores, condicao);
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
                string condicao = string.Format("matricula = '{0}'", matricula);
                dao.Deletar_Registro("tbl_vendedor", condicao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }                

    }
}
