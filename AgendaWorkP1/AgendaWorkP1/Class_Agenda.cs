using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaWorkP1
{
    class Class_Agenda
    {   
        private int ID_PACIENTE;
        private int CRM;
        private int CODIGO;
        private DateTime HORARIO;
     
        Class_DAL dao = new Class_DAL("localhost", "root", "", "work1");

        
        public int id_paciente
        {
            get
            {
                return ID_PACIENTE;
            }
            set
            {
                ID_PACIENTE = value;
            }
        }
        public int codigo
        {
            get
            {
                return CODIGO;
            }
            set
            {
                CODIGO = value;
            }
        }
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
        public DateTime horario
        {
            get
            {
                return HORARIO;
            }
            set
            {
                HORARIO = value;
            }
        }


        public void Inserir()
         {
             String sql = string.Format("insert into agenda values(null, {1}, {2},{3})", id_paciente, crm, horario.ToString("yyyy/MM/dd hh:mm"));
             dao.Executa(sql);
         }

        public void Excluir()
        {
            String sql = string.Format("delete from agenda where id_consulta = ({0})", codigo);
            dao.Executa(sql);
        }

        public void Alterar()
        {
            String sql = string.Format("update from agenda set id_paciente = ({0}), medico_crm = ({1}), horario = '({2})' where id_consulta = {(3)}",  id_paciente,crm,horario, codigo);
            dao.Executa(sql);
        }
       
        public DataTable Visualizar_Agenda_Geral()
        {
            return dao.ExecutaSelecaoSQL("select * from agenda");

        }
        public DataTable Visualizar_Agenda( int valor)
        {
            return dao.ExecutaSelecaoSQL("select * from agenda where medico_crm OR paciente_id =  " + valor  + "");

        }
        
    }
}
