using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace doemais
{
    public class Class_Usuario
    {
        DAL.Class_DAL_Mysql dao = new DAL.Class_DAL_Mysql("localhost", "root", "", "doe_mais");
        public int id { get; set;}
        public string nome { get; set;}
        public string email { get; set; }
        public string senha { get; set;}
        public int tipo_usuario { get; set; }
        public string tipo_sangue { get; set;}
        public string rh { get; set; }
        public DateTime ultima_doacao { get; set; }
        public DateTime data_nasc { get; set;}
        public DataTable Buscausuariopor(string condicao)
        {
            return dao.Pesquisar_Registro("usuario", condicao);
        }
        public void Inserir()
        {
            string valores = string.Format("NULL,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'", nome, email, senha, tipo_usuario, tipo_sangue, rh, ultima_doacao.ToString("yyyy-MM-dd"), data_nasc.ToString("yyyy-MM-dd"));
            dao.Inserir_Registro("usuario", valores);
        }

    }
}