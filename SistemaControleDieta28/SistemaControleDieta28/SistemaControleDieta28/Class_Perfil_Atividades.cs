using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DAL;

namespace SistemaControleDieta28
{
    public class Class_Perfil_Atividades
    {

            public int id { get; set; }
            public int id_usuario { get; set; }
            public int frequencia_semanal { get; set; }
            public int intensidade { get; set; }
            public int media_queima_calorias_semana { get; set; } 

            public Class_DAL_Mysql dao = new Class_DAL_Mysql("localhost", "root", "", "sistema_controle_dieta");

            public void cadastrar()
            {
                try
                {
                    string valores = string.Format("'{0}','{1}','{2}','{3}','{4}'", id, id_usuario, frequencia_semanal, intensidade, media_queima_calorias_semana);
                    dao.Inserir_Registro("perfil_atividades", valores);

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
                    string values = string.Format("id = '{0}', id_usuario = '{1}', frequencia_semanal = '{2}', intensidade = '{3}', media_queima_calorias_semana = '{4}'", id, id_usuario, frequencia_semanal, intensidade, media_queima_calorias_semana);
                    string cod = string.Format("id = {0}", id);
                    dao.Alterar_Registro("perfil_atividades", values, cod);
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
                    return dao.Pesquisar_Registro("perfil_atividades", "*", condicao);
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
                    return dao.Visualizar_Registro("perfil_atividades");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }
    }
