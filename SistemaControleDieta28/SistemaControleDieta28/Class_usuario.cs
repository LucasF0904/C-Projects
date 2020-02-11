using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using System.Data;

namespace SistemaControleDieta28
{
    public class Class_usuario
    {
      public int id {get; set;}
      public string nome {get; set;}
      public string email {get; set;}
      public string senha {get; set;}
      public string sexo {get; set;}
      public DateTime  data_nascimento {get; set;}
      public double altura {get; set;}
      public double peso { get; set; }
      public int tipo_usuario { get; set; }

      public Class_DAL_Mysql dao = new Class_DAL_Mysql("localhost", "root", "", "sistema_controle_dieta");

        public void cadastrar()
      {
            try
            {
                string valores = string.Format("'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'", id, nome, email, senha, sexo, data_nascimento.ToString("yyyy/MM/dd"), altura.ToString().Replace(",","."), peso.ToString().Replace(",","."));
                dao.Inserir_Registro("usuario", valores);

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
                string values = string.Format("id = '{0}', nome = '{1}', email = '{2}', senha = '{3}', sexo = '{4}', data_nascimento = '{5}', altura = '{6}', peso = '{7}'", id, nome, email, senha, sexo, data_nascimento.ToString("yyyy-MM-dd"), altura.ToString().Replace(",", "."), peso.ToString().Replace(",","."));
                string cod = string.Format("id = {0}", id);
                dao.Alterar_Registro("usuario", values, cod);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable pesquisar()
        {
            try
            {
                string condicao = string.Format("email  = '{0}' and senha = '{1}'", email, senha);
                return dao.Pesquisar_Registro("usuario", condicao);
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
                  return dao.Visualizar_Registro("usuario");
              }
              catch (Exception ex)
              {
                  throw ex;
              }
          }

    }

    }
