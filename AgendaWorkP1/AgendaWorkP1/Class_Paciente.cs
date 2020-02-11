using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AgendaWorkP1
{
    class Class_Paciente
    {
        private int ID_PACIENTE;
        private int ID_USUARIO;
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

        public void Alterar()
        {
            String sql = string.Format("update from paciente set usuario_id = ({0}) where id_paciente = {(1)}", id_usuario, id_paciente);
            dao.Executa(sql);
        }
        public DataTable Visualizarr_Agenda(string campo)
        {
            return dao.ExecutaSelecaoSQL("select * from agenda where " + campo + "like " + id_paciente + "");

        }
        public void Inserir()
         {
             String sql = string.Format("insert into paciente values(null,'{1}')", id_paciente);
             dao.Executa(sql);
         }

         public void Excluir()
        {
            String sql = string.Format("delete from paciente where id_paciente = ({0})", id_paciente);
            dao.Executa(sql);
        }
        
        
        }
    }

