using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DAL;

namespace SistemaControleDieta28
{
    public class Class_Meta_Usuario
    {
        
            public int id { get; set; }
            public int id_usuario { get; set; }
            public int id_meta { get; set; }

            public Class_DAL_Mysql dao = new Class_DAL_Mysql("localhost", "root", "", "sistema_controle_dieta");

            public void cadastrar()
            {
                try
                {
                    string valores = string.Format("'{0}','{1}','{2}'", id, id_usuario, id_meta);
                    dao.Inserir_Registro("meta_usuario", valores);

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
                    string values = string.Format("id = '{0}', id_usuario = '{1}', id_meta = '{2}'", id, id_usuario, id_meta);
                    string cod = string.Format("id = {0}", id);
                    dao.Alterar_Registro("meta_usuario", values, cod);
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
                    return dao.Pesquisar_Registro("meta_usuario", "*", condicao);
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
                    return dao.Pesquisar_Registro("meta_usuario mu JOIN usuario u JOIN meta m ON mu.id_meta = m.id AND mu.id_usuario = u.id ", "m.descricao AS'Metas' ", " u.id = "+ id_usuario + "");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        
    }
}