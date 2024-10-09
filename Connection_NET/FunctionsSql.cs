using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
using Connection_NET;
using System.Runtime.Remoting.Contexts;

namespace ControleOP
{
    class FunctionsSql
    {
        public static string sql { get; set; }

        public static string ConnectionString()
        {
            try
            {
                return @"Data Source=localhost\SQLEXPRESS;Initial Catalog=appDBJP;Integrated Security=True;";
            }
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("Não foi possível localizar o arquivo"))
                {
                    Exception err = new Exception(ex.Message, ex);
                    MessageBox.Show("Ocorreu um erro ao obter a string de conexão: " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    throw new Exception(ex.Message, ex);
                }
                else
                {
                    throw new Exception(ex.Message, ex);
                }
            }
        }

        public static void startQuery(string sql)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd;


            con.ConnectionString = ConnectionString();
            cmd = new SqlCommand(sql, con);
            cmd.CommandTimeout = 600;
            int i = 0;

            try
            {
                con.Open();
                i = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message, ex);
            }
            finally
            {
                con.Close();
            }
        }

        public static string getData(String sql, String field)
        {
            string retorno = string.Empty;

            SqlConnection con = new SqlConnection();
            SqlCommand cmd;

            con.ConnectionString = ConnectionString();

            try
            {
                cmd = new SqlCommand(sql, con);
                SqlDataReader dr;
                con.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    retorno = Convert.ToString(String.Format("{0}", dr[field]));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Endereço de servidor indisponível ou inexistente. Contate um administrador.", "Erro de servidor.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

            return retorno;
        }

        public static DataTable getTable(String sql)
        {
            DataTable dt = new DataTable();

            SqlConnection con = new SqlConnection();
            SqlCommand cmd;

            con.ConnectionString = ConnectionString();

            try
            {
                cmd = new SqlCommand(sql, con);
                cmd.CommandTimeout = 600;
                con.Open();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message, ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
