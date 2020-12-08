using ITICH.ConecaoBD;
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
        //perfil de cada utilizador (existem apenas dois tipos Administrador e Empresa)
        private int perfilADM = 1;
        private int perfilEMP = 2;

        //metodo que encripta a palavra-passe antes de ser guardada na BD
        public string Encriptarpwd(string password) //VERIFICAR QUE METODO É USADO PARA ENCRIPTAR------------------------------------------------------
        {
            string msg = "";
            byte[] encode = new byte[password.Length];
            encode = Encoding.UTF8.GetBytes(password);
            msg = Convert.ToBase64String(encode);
            return msg;
        }

        public Registo()
        {
            InitializeComponent();
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
            //Chama metodo para encriptar a pwd
            string pwdEncriptada = Encriptarpwd(textBox_pwd.Text);

            //verifica se os campos estão preenchidos
            if (string.IsNullOrEmpty(textBox_nomeEmpresa.Text) || string.IsNullOrEmpty(textBox_contacto.Text) || string.IsNullOrEmpty(textBox_email.Text) || string.IsNullOrEmpty(textBox_pwd.Text) || string.IsNullOrEmpty(textBox_pwd2.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_nomeEmpresa.Select();
            }
            else if (FormatacaoEmail.IsValidEmail(textBox_email.Text) == false)
            {
                MessageBox.Show("Introduza um email correto!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_email.Select();
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
                string dadosUtilizador = "SELECT e_mail, nome_empresa FROM Empresa WHERE e_mail = '" + textBox_email.Text + "' OR nome_empresa = '" + textBox_nomeEmpresa.Text + "'";
                DataTable dt = ConecaoSQLServer.ExecutaSql(dadosUtilizador);

                if(dt.Rows.Count >=1)
                {
                    MessageBox.Show("O nome da empresa ou o email já existem!");
                }
                else
                {
                    //verifica se já exite ou não o nome ou o email (se já existirem não deixa inserir) e depois insere os dados se não existirem
                    string dadosInseridos = "IF NOT EXISTS(SELECT nome_empresa, e_mail FROM Empresa WHERE nome_empresa = '" + textBox_nomeEmpresa.Text + "' OR e_mail = '" +textBox_email.Text + "') INSERT INTO Empresa(nome_empresa,contacto_tel,e_mail,password,perfil) VALUES('" + textBox_nomeEmpresa.Text + "','" + textBox_contacto.Text + "','" +textBox_email.Text+ "','" +pwdEncriptada+ "','" +perfilEMP+ "')";
                    ConecaoSQLServer.ExecutaSql(dadosInseridos);

                    textBox_nomeEmpresa.Clear();
                    textBox_pwd.Clear();
                    textBox_pwd2.Clear();
                    textBox_contacto.Clear();
                    textBox_email.Clear();

                    Hide();

                    Login login = new Login(); //-------- ALTERAR NOVAMENTE SE NECESSARIO PARA PAGINA INICIAL----------!!!!!!!!!!!
                    login.ShowDialog();
                    
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
