using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    public class Class_DAL_Mysql
    {
                /// <summary>
        /// Atributos/Campos de conexão com banco 
        /// </summary>
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;

        public Class_DAL_Mysql(string Servidor, string Usuario, string Senha, string Banco) //construtor instanciando a conexao
        {
            con = new MySqlConnection("server=" + Servidor + ";uid=" + Usuario + ";pwd=" + Senha + ";database=" + Banco);
        }

        private void Abrir_conexao()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        public DataTable Visualizar_Registro(string tabela)
        {
            try
            {
                cmd = new MySqlCommand("select * from " + tabela, con);
                da = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                Abrir_conexao();
                da.Fill(dt);
                con.Close();

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Pesquisar_Registro(string tabela, string condicao)
        {
            try
            {
                cmd = new MySqlCommand("select * from " + tabela + " where " + condicao, con);
                da = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                Abrir_conexao();
                da.Fill(dt);
                con.Close();

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Pesquisar_Registro(string tabela, string campos, string condicao)
        {
            try
            {
                cmd = new MySqlCommand("select " + campos + " from " + tabela + " where " + condicao, con);
                da = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                Abrir_conexao();
                da.Fill(dt);
                con.Close();

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Inserir_Registro(string tabela, string valores)
        {
            try
            {
                cmd = new MySqlCommand("insert into " + tabela + " values( " + valores + " )", con);
                Abrir_conexao();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Inserir_Registro(string tabela, string campos, string valores)
        {
            try
            {
                cmd = new MySqlCommand("insert into " + tabela + "( " + campos + " ) values( " + valores + " )", con);
                Abrir_conexao();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Alterar_Registro(string tabela, string valores, string condicao)
        {
            try
            {
                cmd = new MySqlCommand("Update " + tabela + " set " + valores + " where " + condicao, con);
                Abrir_conexao();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Deletar_Registro(string tabela, string condicao)
        {
            try
            {
                cmd = new MySqlCommand("Delete from " + tabela + " where " + condicao, con);
                Abrir_conexao();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Object ExecutaQuerySQL_ComRetorno(string tabela, string campos)
        {
            try
            {
                cmd = new MySqlCommand("Select " + campos + " from " + tabela, con);
                Abrir_conexao();
                object retorno = cmd.ExecuteScalar();
                con.Close();

                return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ExecutaSelecaoSQL(string SQL)
        {
            try
            {
                cmd = new MySqlCommand(SQL, con);
                da = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                Abrir_conexao();
                da.Fill(dt);
                con.Close();

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExecutaQuerySQL(string SQL)
        {
            try
            {               
                cmd = new MySqlCommand(SQL, con);                
                Abrir_conexao();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
