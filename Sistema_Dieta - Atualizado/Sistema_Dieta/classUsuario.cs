using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DAL;

namespace Sistema_Dieta
{
    public class classUsuario
    {
        public int id { get; set; }
        public string nome{ get; set; }
        public string email{ get; set; }
        public string senha{ get; set; }
        public string sexo{ get; set; }
        public DateTime data_nascimento{ get; set; }
        public double altura{ get; set; }
        public double peso { get; set; }

        private Class_DAL_Mysql dao = new Class_DAL_Mysql("localhost", "root", "", "sistema_controle_dieta");

        public void cadastra()
        {
            try
            {
                string sql = string.Format("'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'", id, nome, email, senha, sexo, data_nascimento.ToString("yyyy/MM/dd"), altura.ToString().Replace(',', '.'), peso.ToString().Replace(',', '.'));
                dao.Inserir_Registro("usuario", sql);
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
    }
}