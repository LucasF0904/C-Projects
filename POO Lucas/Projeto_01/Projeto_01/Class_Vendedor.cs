﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace Projeto_01
{
    public class Class_Vendedor
    {
        public decimal comissao { get; set; }

        public DateTime datanasc { get; set; }

        public int codigo { get; set; }

        public string nome { get; set; }

        public string rua { get; set; }

        public int numero { get; set; }

        public string telefone { get; set; }

        public string bairro { get; set; }

        public string logradouro { get; set; }

        public string cidade { get; set; }

        public string estado { get; set; }
    
        private Class_DAL_SQL dao = new Class_DAL_SQL("Projeto1.mdf");
        
        public DataTable visualizar()
        {
            try
            {
                return dao.Visualizar_Registro("Vendedor");
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
                return dao.Pesquisar_Registro("Vendedor", "nome like '%" + nome + "%'");
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
                string valores = string.Format("'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}'", codigo, nome, rua, numero, telefone, bairro, logradouro, cidade, estado, datanasc.ToString("yyyy/MM/dd"), comissao.ToString().Replace(',', '.'));
                dao.Inserir_Registro("Vendedor", valores);

            }
            catch(Exception ex)
            {
            throw ex;
        }
      }

        public void alterar_dados()
        {
            try
            {
                string valores = string.Format("nome = '{0}', DataNascimento = '{1}', comissao = '{2}'", nome, datanasc.ToString("yyyy-MM-dd"), comissao.ToString().Replace(',', '.'));
                string condicao = string.Format("codigo = '{0}'", codigo);
                dao.Alterar_Registro("Vendedor", valores, condicao);
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
                string condicao = string.Format("codigo = '{0}'", codigo);
                dao.Deletar_Registro("Vendedor", condicao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
