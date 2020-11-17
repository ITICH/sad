using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITICH.ConecaoBD
{
    class ConecaoSQLServer
    {
        public static string stringConecao = @"Data Source = LAPTOP-O0RQ78U5\SQLEXPRESS;Initial Catalog = ITICH;Integrated Security = True";

        public static DataTable ExecutaSql(string sql)
        {
            SqlConnection connection = new SqlConnection();
            DataTable dt = new DataTable();

            try
            {
                connection.ConnectionString = stringConecao;
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(dt);

                connection.Close();
                connection = null;
                return dt;

            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Ocorreu um erro na coneção ao servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;
            }
            return dt;

        }
    }
}
