using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace AgendaWorkP1
{
    class Class_DAL
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt = new DataTable();

        public Class_DAL(string Servidor, string Usuario, string Senha, string Banco)
        {
            con = new MySqlConnection("server= " + Servidor + ";uid= " + Usuario + ";pwd= " + Senha + ";database= " + Banco);
        }

        public DataTable ExecutaSelecaoSQL(string sql)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand(sql, con);
                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                return dt;

            }
            catch (Exception)
            {
                throw;
            }
        }

            public void Executa (string sql)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}

