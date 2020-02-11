using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using System.Data;

namespace Provinha
{
    public class Class_laboratorio
    {
        public int cod_laboratorio { get; set; }
        public string nome_laboratorio { get; set; }
        public int cod_tecnico_laboratorio { get; set; }


        public Class_DAL_Mysql dao = new Class_DAL_Mysql("localhost", "root", "", "bd_farmacia");

        public DataTable visualizar()
        {
            try
            {
                return dao.Visualizar_Registro("tbl_laboratorio");
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        public void cadastrar()
        {
            try
            {
                string valores = string.Format("'{0}','{1}','{2}'",cod_laboratorio,nome_laboratorio,cod_tecnico_laboratorio);
                dao.Inserir_Registro("tbl_laboratorio", valores);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void alterar()
        {
            try
            {
                string valores = string.Format(@"cod_laboratorio = '{0}',nome_laboratorio ='{1}',cod_tecnico_laboratorio ='{2}'", cod_laboratorio, nome_laboratorio, cod_tecnico_laboratorio);
                dao.Alterar_Registro("tbl_laboratorio", valores, "cod_laboratorio = " + cod_laboratorio);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void excluir()
        {
            try
            {
                dao.Deletar_Registro("tbl_laboratorio", "cod_laboratorio = " + cod_laboratorio);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}