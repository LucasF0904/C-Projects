using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace AgendaWorkP1
{
   
    class Class_Usuario
    {
        private int ID_USUARIO;
        private int TIPO_USUARIO;
        private string NOME;
        private string EMAIL;
        private string SENHA;
   
   
        Class_DAL dao = new Class_DAL("localhost", "root", "", "work1");

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

       public int tipo_usuario
       {
           get
           {
               return TIPO_USUARIO;
           }
           set
           {
               TIPO_USUARIO = value;
           }
       }
       public string senha
       {
           get
           {
               return SENHA;
           }
           set
           {
               SENHA = value;
           }
       }
       public string nome
       {
           get
           {
               return NOME;
           }
           set
           {
               NOME = value;
           }
       }
       public string email
       {
           get
           {
               return EMAIL;
           }
           set
           {
               EMAIL = value;
           }
       }
      
         public void Inserir()
         {
             String sql = string.Format("insert into usuario values({0},'{1}','{2}','{3}',{4})", id_usuario,nome,email,senha,tipo_usuario);
             dao.Executa(sql);
         }

         public void Excluir()
         {
             String sql = string.Format("delete from usuario where id_usuario = ({0}')", id_usuario);
             dao.Executa(sql);
         }
        public void Alterar()
         {
             String sql = string.Format("update usuario set nome = {0}, senha = {1}, email = {2}, tipo_usuario = {3}", nome, senha, email, tipo_usuario);
             dao.Executa(sql);
         }

     

         public DataTable Visualizar()
         {
             return dao.ExecutaSelecaoSQL("select * from usuario" );
                       
         }
         public DataTable Login_Email_Senha()
         {
             return dao.ExecutaSelecaoSQL("select * from usuario where email = '" + email + "' AND senha = '"+ senha+"'" );            
         }
         public DataTable Visualizar_Usuarios(string campo, string valor)
         {
             return dao.ExecutaSelecaoSQL("select * from usuario where" + campo + " = "+valor);

         }

        }
    
     
       

    }

