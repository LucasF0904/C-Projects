﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace Projeto
{
    public class Class_Produto
    {
        public string cb { get; set; }
        public string nomeprod { get; set; }
        public decimal valorvenda { get; set; }
        public decimal qtdeprod { get; set; }
        public decimal qtdeminprod { get; set; }
        public DateTime datavalidade { get; set; }
        public string prazogarantia { get; set; }
        public string lote { get; set; }

        private Class_DAL_SQL dao = new Class_DAL_SQL("Projeto1.mdf");
        public Class_Produto()
        {
        }

        public Class_Produto(string mat)
        {
            try
            {
                string condicao = string.Format("cb = '{0}'", cb);
                DataTable dt = dao.Pesquisar_Registro("Produto", condicao);
                cb = dt.Rows[0][0].ToString();
                nomeprod = dt.Rows[0][1].ToString();
                valorvenda = Convert.ToDecimal(dt.Rows[0][2]);
                qtdeprod = Convert.ToDecimal(dt.Rows[0][3]);
                qtdeminprod = Convert.ToDecimal(dt.Rows[0][4]);
                datavalidade = Convert.ToDateTime(dt.Rows[0][5]);
                prazogarantia = dt.Rows[0][6].ToString();
                lote = dt.Rows[0][7].ToString();
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
                return dao.Visualizar_Registro("Produto");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Pesquisar_datavalidade_Produto()
        {
            try
            {
                string condicao = string.Format("datavalidade = '{0}'", datavalidade.ToString("yyyy/MM/dd"));
                return dao.Pesquisar_Registro("Produto", condicao);
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
                string valores = string.Format("'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'", cb, nomeprod, valorvenda.ToString().Replace(',', '.'), qtdeprod.ToString().Replace(',', '.'), qtdeminprod.ToString().Replace(',', '.'), datavalidade.ToString("yyyy/MM/dd"),prazogarantia , lote);
                dao.Inserir_Registro("Produto", valores);
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
                string valores = string.Format("nomeprod = '{0}', valorvenda = '{1}', qtdeprod = '{2}', qtdeminprod = '{3}', datavalidade = '{4}', lote = '{5}', prazogarantia='{6}'", nomeprod, valorvenda.ToString().Replace(',', '.'), qtdeprod.ToString().Replace(',', '.'), qtdeminprod.ToString().Replace(',', '.'), datavalidade.ToString("yyyy/MM/dd"), lote, prazogarantia);
                string condicao = string.Format("cb = '{0}'", cb);
                dao.Alterar_Registro("Produto", valores, condicao);
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
                string condicao = string.Format("cb = '{0}'", cb);
                dao.Deletar_Registro("Produto", condicao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
