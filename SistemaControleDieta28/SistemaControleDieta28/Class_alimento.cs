using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using System.Data;

namespace SistemaControleDieta28
{
    public class Class_alimento
    {
      public int id {get; set;}
      public string nome {get; set;}
      public double calorias {get; set;}
      public int porcao_gramas {get; set;}

      public Class_DAL_Mysql dao = new Class_DAL_Mysql("localhost", "root", "", "sistema_controle_dieta");

        public void cadastrar()
      {
            try
            {
                string valores = string.Format("'{0}','{1}','{2}','{3}'", id, nome, calorias, porcao_gramas);
                dao.Inserir_Registro("alimento", valores);

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
                string values = string.Format("id = '{0}', nome = '{1}', calorias = '{2}', porcao_gramas = '{3}'", id, nome, calorias, porcao_gramas.ToString().Replace(",", "."));
                string cod = string.Format("id = {0}", id);
                dao.Alterar_Registro("alimento", values, cod);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

          public DataTable Pesquisa_email(string condicao)
        {
            try
            {
                return dao.Pesquisar_Registro("alimento","*", condicao);
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
                  return dao.Visualizar_Registro("alimento");
              }
              catch (Exception ex)
              {
                  throw ex;
              }
          }

    }
    }
