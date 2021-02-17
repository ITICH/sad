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
        public static string stringConecao = null;

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
                MessageBox.Show("Ocorreu um erro, por favor contactar um administrador: \n" + ex.Message, "Ocorreu um erro na coneção ao servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;
            }
            return dt;

        }
    }
}
