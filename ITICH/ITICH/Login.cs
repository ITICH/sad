using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ITICH
{
    public partial class Login : Form
    {
        private SqlConnection con = new SqlConnection();
        private SqlCommand com = new SqlCommand();

        public Login()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source = LAPTOP-O0RQ78U5\SQLEXPRESS;Initial Catalog = ITICH;Integrated Security = True";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT email, password FROM Empresa WHERE email = '" + textBox_nome.Text + "' AND password = '" + textBox_pw.Text + "'";
            SqlDataReader dr = com.ExecuteReader();

            if (string.IsNullOrEmpty(textBox_nome.Text) || string.IsNullOrEmpty(textBox_pw.Text))
            {
                MessageBox.Show("Introduza o nome ou a palavra passe!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_nome.Select();
            }
            else
            {
                if (dr.Read())
                {
                    if (textBox_nome.Text.Equals(dr["email"].ToString()) && textBox_pw.Text.Equals(dr["password"].ToString()))
                    {
                        //MessageBox.Show("Sucesso Login", "qwe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.textBox_nome.Clear();
                        this.textBox_pw.Clear();
                        this.checkBox1.Checked = false;

                        this.Hide();

                        PaginaInicial paginaInicial = new PaginaInicial();
                        paginaInicial.ShowDialog();
                        paginaInicial = null;

                        this.Show();
                        this.textBox_nome.Select();
                    }
                    else
                    {
                        MessageBox.Show("O nome ou a palavra passe errada!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        textBox_nome.Focus();
                        textBox_nome.SelectAll();
                    }
                }
            }
            
            con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Registo registo = new Registo();
            registo.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_pw_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox_nome.Select();
        }

        private void textBox_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                textBox_pw.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_pw.UseSystemPasswordChar = true;
            }
        }
    }
}