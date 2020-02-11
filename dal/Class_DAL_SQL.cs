using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace DAL
{
    public class Class_DAL_SQL
    {
        /// <summary>
        /// Atributos/Campos de conexão com banco 
        /// </summary>
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public Class_DAL_SQL(string BancoDados) //construtor instanciando a conexao
        {
            con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\" + BancoDados + ";Integrated Security=True");
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
                cmd = new SqlCommand("select * from " + tabela, con);
                da = new SqlDataAdapter(cmd);
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
                cmd = new SqlCommand("select * from " + tabela + " where " + condicao, con);
                da = new SqlDataAdapter(cmd);
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
                cmd = new SqlCommand("select " + campos + " from " + tabela + " where " + condicao, con);
                da = new SqlDataAdapter(cmd);
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
                cmd = new SqlCommand("insert into " + tabela + " values( " + valores + " )", con);
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
                cmd = new SqlCommand("insert into " + tabela + "( " + campos + " ) values( " + valores + " )", con);
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
                cmd = new SqlCommand("Update " + tabela + " set " + valores + " where " + condicao, con);
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
                cmd = new SqlCommand("Delete from " + tabela + " where " + condicao, con);
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
                cmd = new SqlCommand("Select " + campos + " from " + tabela, con);
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
                cmd = new SqlCommand(SQL, con);
                da = new SqlDataAdapter(cmd);
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
                cmd = new SqlCommand(SQL, con);                
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
