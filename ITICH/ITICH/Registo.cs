using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITICH
{
    public partial class Registo : Form
    {
        private SqlConnection con = new SqlConnection();
        private SqlCommand com = new SqlCommand();

        public Registo()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source = LAPTOP-O0RQ78U5\SQLEXPRESS;Initial Catalog = ITICH;Integrated Security = True";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Registo_Load(object sender, EventArgs e)
        {
            textBox_nomeEmpresa.Select();
        }

        private void textBox_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_registar_Click(object sender, EventArgs e)
        {
            //verifica se os campos estão preenchidos
            if (string.IsNullOrEmpty(textBox_nomeEmpresa.Text) || string.IsNullOrEmpty(textBox_contacto.Text) || string.IsNullOrEmpty(textBox_email.Text) || string.IsNullOrEmpty(textBox_pwd.Text) || string.IsNullOrEmpty(textBox_pwd2.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_nomeEmpresa.Select();
            }
            else if (textBox_pwd.Text != textBox_pwd2.Text)
            {
                MessageBox.Show("As palavras-passe não correspodem uma à outra!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_pwd.Clear();
                textBox_pwd2.Clear();
                textBox_pwd.Select();
            }

            else
            {   
                //verifica se o nome e o email da empresa já exitem 
                SqlDataAdapter da = new SqlDataAdapter("SELECT email, nome_empresa FROM Empresa WHERE email = '" + textBox_email.Text + "' OR nome_empresa = '" + textBox_nomeEmpresa.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count >=1)
                {
                    MessageBox.Show("O nome da empresa ou o email já existem!");
                }
                else
                {
                    con.Open();
                    //verifica se já exite ou não o nome ou o email (se já existirem não deixa inserir) e depois insere os dados se não existirem
                    string dadosInseridos = "IF NOT EXISTS(SELECT nome_empresa, email FROM Empresa WHERE nome_empresa = @nome_empresa OR email = @email) INSERT INTO Empresa(nome_empresa,contacto_tel,email,password) VALUES(@nome_empresa,@contacto_tel,@email,@password)";

                    SqlCommand cmd = new SqlCommand(dadosInseridos, con);

                    cmd.Parameters.AddWithValue("@nome_empresa", textBox_nomeEmpresa.Text);
                    cmd.Parameters.AddWithValue("@contacto_tel", textBox_contacto.Text);
                    cmd.Parameters.AddWithValue("@email", textBox_email.Text);
                    cmd.Parameters.AddWithValue("@password", textBox_pwd.Text);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();

                    textBox_nomeEmpresa.Clear();
                    textBox_pwd.Clear();
                    textBox_pwd2.Clear();
                    textBox_contacto.Clear();
                    textBox_email.Clear();

                    Hide();

                    PaginaInicial paginaInicial = new PaginaInicial();
                    paginaInicial.ShowDialog();
                    paginaInicial = null;

                    Show();
                    textBox_nomeEmpresa.Select();
                }

                
            }
        }

        private void checkBox1_pwd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1_pwd.Checked == true)
            {
                textBox_pwd.UseSystemPasswordChar = false;
                textBox_pwd2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_pwd.UseSystemPasswordChar = true;
                textBox_pwd2.UseSystemPasswordChar = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
