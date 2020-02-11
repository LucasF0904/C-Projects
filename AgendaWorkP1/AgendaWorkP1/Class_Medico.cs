using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace AgendaWorkP1
{
    class Class_Medico
    {

        private int CRM;
        private int ID_USUARIO;

        Class_DAL dao = new Class_DAL("localhost", "root", "", "work1");

        public int crm
        {
            get
            {
                return CRM;
            }
            set
            {
                CRM = value;
            }
        }
        public int id_usuario
        {
            get
            {
                return ID_USUARIO;
            }
            set
            {
                ID_USUARIO = value;
            }

        }
        public void Inserir()
        {
            String sql = string.Format("insert into medico values({0} , {1})", crm, id_usuario);
            dao.Executa(sql);
        }

        public void Excluir()
        {
            String sql = string.Format("delete from medico where id_paciente = ({0})", crm);
            dao.Executa(sql);
        }

         public void Alterar()
           {
               String sql = string.Format("update madico set usuario_id = ({0}) where crm = {(1)}",id_usuario, crm);
               dao.Executa(sql);
          }
        public DataTable Visualizar_Medico(int valor)
        {
            return dao.ExecutaSelecaoSQL("select * from medico where medico_crm = " + crm + "");

        }

        public DataTable Visualizar_Medico_Geral(int valor)
        {
            return dao.ExecutaSelecaoSQL("select * from medico where medico");

        }
    }
}