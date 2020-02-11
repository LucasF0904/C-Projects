using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace prj_venda2
{
    public class vendedor
    {
        public string matricula { get; set; }
        public string nome { get; set; }
        public char sexo { get; set; }
        public char telefone { get; set; }
        public DateTime datanasc { get; set; }
        public string logradouro { get; set; }
        public string bairro { get; set; }
        public char cep { get; set; }
        public string cidade { get; set; }
        public char complemento { get; set; }
        public int numero { get; set; }
        public decimal comissao { get; set; }

        Class_DAL_Mysql dao = new  Class_DAL_Mysql("localhost", "root", "", "venda");

        public vendedor()
        {
        }

        public vendedor(string mat)
        {
            try
            {
                DataTable dt = dao.Pesquisar_Registro("tbl_vendedor", "matricula = " + matricula);
                matricula = dt.Rows[0][0].ToString();
                nome = dt.Rows[0][1].ToString();
                datanasc = Convert.ToDateTime( dt.Rows[0][2]) ;
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
                return dao.Pesquisar_Registro("tbl_vendedor", "nome like '%" + nome + "%'");
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
                string valores = string.Format("'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}", matricula, nome,sexo,telefone, datanasc,logradouro, bairro,cep,cidade, complemento,numero.ToString(), comissao.ToString().Replace(',', '.'));
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
                string valores = string.Format("nome = '{0}', sexo = '{1}', telefone = '{2}'datanasc = '{3}', logradouro = '{4}', bairro = '{5}', cep = '{6}', cidade = '{7}', complemento = '{8}', numero = '{9}', comissao = '{10}'", nome, sexo, telefone, datanasc, logradouro, bairro, cep, cidade, complemento, numero.ToString(), comissao.ToString().Replace(',', '.'));
                string condicao = string.Format("matricula = '{0}'", matricula);
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
