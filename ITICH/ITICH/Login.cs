using ITICH.ConecaoBD;
using Microsoft.SqlServer.Management.Common;
using System;
using System.Data;
using System.Windows.Forms;
//using CSLoginRegisterForm.Connection;


namespace ITICH
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_nome.Text) && !string.IsNullOrEmpty(textBox_pw.Text))
            {
                string mySQL = "select email, password from Empresas where email = '" + textBox_nome.Text + "' and password = '" + @textBox_pw.Text + "'";
                DataTable dadosUtilizador = ConecaoSQLServer.ExecuteSql(mySQL);

                if (dadosUtilizador.Rows.Count > 0)
                {
                    textBox_nome.Clear();
                    textBox_pw.Clear();
                    checkBox1.Checked = false;

                    Hide();

                    PaginaInicial paginaInicial = new PaginaInicial();
                    paginaInicial.ShowDialog();

                    Show();
                    textBox_nome.Select();
                }
                else
                {
                    MessageBox.Show("O nome ou a palavra passe errada!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    textBox_nome.Focus();
                    textBox_nome.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Introduza o nome ou a palavra passe", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_nome.Select();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
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
