using ITICH.ConecaoBD;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


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
            //seleciona os utitilizadores com perfil de Empresa
            string queryLoginEMP = "SELECT email, password, perfil FROM Empresa WHERE email = '" + textBox_nome.Text + "' AND password = '" + textBox_pw.Text + "' AND perfil = 2";
            //seleciona os utitilizadores com perfil de Administrador
            string queryLoginADM = "SELECT email, password, perfil FROM Empresa WHERE email = '" + textBox_nome.Text + "' AND password = '" + textBox_pw.Text + "' AND perfil = 1";
            
            DataTable dadosUtilizador = ConecaoSQLServer.ExecutaSql(queryLoginEMP);
            DataTable dadosUtilizadorADM = ConecaoSQLServer.ExecutaSql(queryLoginADM);

            if (string.IsNullOrEmpty(textBox_nome.Text) || string.IsNullOrEmpty(textBox_pw.Text))
            {
                MessageBox.Show("Introduza o email ou a palavra passe!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_nome.Select();
            }
            //chama metodo que verifica se o email está na forma correta ex.: aaa@aaa.com
            else if (FormatacaoEmail.IsValidEmail(textBox_nome.Text) == false)
            {
                MessageBox.Show("Introduza um email correto!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_nome.Select();
            }
            else
            {
                //se o utilizador existir e os dados estiverem corretos vai entra na app
                if (dadosUtilizador.Rows.Count > 0)
                {
                    this.textBox_nome.Clear();
                    this.textBox_pw.Clear();
                    this.checkBox1.Checked = false;

                    this.Hide();

                    PaginaInicial paginaInicial = new PaginaInicial();
                    paginaInicial.ShowDialog();

                    this.Show();
                    this.textBox_nome.Select();
                }
                //só pode ser acedido pelo perfil do ADM 
                else if (dadosUtilizadorADM.Rows.Count > 0)
                {
                    this.textBox_nome.Clear();
                    this.textBox_pw.Clear();
                    this.checkBox1.Checked = false;

                    this.Hide();

                    AreaAdministrador areaAdministrador = new AreaAdministrador();
                    areaAdministrador.ShowDialog();

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
            if (checkBox1.Checked == true)
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