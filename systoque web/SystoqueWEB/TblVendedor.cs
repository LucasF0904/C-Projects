using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace SystoqueWEB
{
    public class TblVendedor
    {

        Class_DAL_Mysql dao = new Class_DAL_Mysql("localhost", "root", "", "systoque");

        private int matricula;
        private string nome;
        private DateTime datanasc;
        private decimal comissao;

        public int MATRICULA
        {
            get
            {
                return matricula;
            }
            set
            {
                matricula = value;
            }
        }

        public string NOME
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public DateTime DATANASC
        {
            get
            {
                return datanasc;
            }
            set
            {
                datanasc = value;
            }
        }

        public decimal COMISSAO
        {
            get
            {
                return comissao;
            }
            set
            {
                comissao = value;
            }
        }

        public void Inserir()
        {
            string valores = "NULL,'" + NOME + "','" + DATANASC + "'," + COMISSAO;
            dao.Inserir_Registro("tblvendedor", valores);
        }

        public void Alterar()
        {
            string valores = "matricula=" + MATRICULA + ",nome='" + NOME + "',datanasc='" + DATANASC + "',comissao=" + COMISSAO;
            string condicao = "matricula=" + MATRICULA;
            dao.Alterar_Registro("tblvendedor", valores, condicao);
        }

        public void Excluir()
        {
            string condicao = "matricula=" + MATRICULA;
            dao.Deletar_Registro("tblvendedor", condicao);
        }

        
        public DataTable Pesquisar()
        {
            return dao.Pesquisar_Registro("tblvendedor", "*", "matricula=" + MATRICULA);
        }
    }
}
