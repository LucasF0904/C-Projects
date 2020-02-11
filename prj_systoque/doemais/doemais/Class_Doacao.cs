using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace doemais
{
    public class Class_Doacao
    {
        DAL.Class_DAL_Mysql dao = new DAL.Class_DAL_Mysql("localhost", "root", "", "doe_mais");
        public int codigo { get; set; }
        public int status { get; set; }
        public DateTime data { get; set; }
        public string info { get; set; }
        public int receptor { get; set; }
        public int doador { get; set; }
        public DataTable Buscadoacaopor(string condicao)
        {
            return dao.Pesquisar_Registro("doacao", condicao);
        }
        public DataTable BuscaMinhasDoacoes()
        {
            string sql = "Select codigo AS 'Codigo', data AS 'Data', info AS 'Informacoes' from doacao where receptor = " + receptor + " AND status = 2";
            return dao.ExecutaSelecaoSQL(sql);
        }
        public void Inserir()
        {
            string valores = string.Format("NULL,'{0}','{1}','{2}','{3}',NULL", status, data.ToString("yyyy-MM-dd"), info, receptor);
            dao.Inserir_Registro("doacao", valores);
        }
        public DataTable Buscadoacoes(string condicao)
        {
            string sql1 = "Select d.codigo AS 'Codigo', d.info AS 'Informacoes sobre',d.data AS 'Data', r.nome AS 'Nome do Receptor' ";
            string sql2 = "from doacao d JOIN usuario r ON d.receptor = r.id where "+condicao;
            string query = sql1 + sql2;
            return dao.ExecutaSelecaoSQL(query);
        }
        public DataTable HistoricoDoacao(string condicao)
        {
            string sql1 = "Select d.codigo AS 'Codigo', d.info AS 'Informacoes sobre',d.data AS 'Data', r.nome AS 'Nome do Receptor' ";
            string sql2 = "from doacao d JOIN usuario r ON d.receptor = r.id where d.status = 1 "+condicao;
            string query = sql1 + sql2;
            return dao.ExecutaSelecaoSQL(query);
        }
        public void Doar()
        {
            string valores = string.Format("doador = '{0}',status = 1", doador);
            string condicao = string.Format("codigo = {0}",codigo);
            dao.Alterar_Registro("doacao", valores, condicao);
        }
        public void Excluir()
        {
            string condicao = string.Format("codigo ='{0}'", codigo);
            dao.Deletar_Registro("doacao", condicao);
        }
    }
}