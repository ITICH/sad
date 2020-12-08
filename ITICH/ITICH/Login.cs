using ITICH.ConecaoBD;
using System;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;


namespace ITICH
{
    public partial class Login : Form
    {
        //metodo que encripta a palavra-passe antes de ser guardada na BD
        public string Desencriptarpwd(string password) //VERIFICAR QUE METODO É USADO PARA ENCRIPTAR------------------------------------------------------
        {
            /*string msg = "";
            byte[] encode = new byte[password.Length];
            encode = Encoding.UTF8.GetBytes(password);
            msg = Convert.FromBase64String(encode);
            return msg;*/

            //NÃO ESETÁ A FUNCIONAR----------------------------------------------------------------------------------------------------------------------
            string decryptpwd = "";
            UTF8Encoding encodepwd = new UTF8Encoding();
            Decoder Decode = encodepwd.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(password);
            int charCount = Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            decryptpwd = new String(decoded_char);
            return decryptpwd;
        }

        public Login()
        {
            InitializeComponent();
        }

        //COMO DEFINIR ISTO METODO OU CLASSE????????????????????????????????????????????????????????????????
        public static string utilizadorLogado;

        public static string dadosLogin
        {
            get { return utilizadorLogado; }
            set { utilizadorLogado = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string pwdDesencripada = Desencriptarpwd(textBox_pw.Text);//--------------------------------------------------------------------------------

            //variavel usada para guardar e identificar o utilizador depois do login
            string userAtual = textBox_nome.Text;

            //seleciona os utitilizadores com perfil de Empresa
            string queryLoginEMP = "SELECT e_mail, password, perfil FROM Empresa WHERE e_mail = '" + textBox_nome.Text + "' AND password = '" + /*pwdDesencripada*/textBox_pw.Text + "' AND perfil = 2";
            //seleciona os utitilizadores com perfil de Administrador
            string queryLoginADM = "SELECT e_mail, password, perfil FROM Empresa WHERE e_mail = '" + textBox_nome.Text + "' AND password = '" + /*pwdDesencripada*/textBox_pw.Text + "' AND perfil = 1";

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

                    dadosLogin = userAtual;

                    this.Hide();

                    PaginaInicial paginaInicial = new PaginaInicial();
                    paginaInicial.ShowDialog();
                   
                   // this.Show();
                   // this.textBox_nome.Select();
                }
                //só pode ser acedido pelo perfil do ADM  ----------------------------------VERIFICAR SE É NECESSARIO OU NÃO TER ESTA PARTE
                else if (dadosUtilizadorADM.Rows.Count > 0)
                {
                    this.textBox_nome.Clear();
                    this.textBox_pw.Clear();
                    this.checkBox1.Checked = false;

                    dadosLogin = userAtual;

                    this.Hide();

                    PaginaInicial paginaInicial = new PaginaInicial();
                    paginaInicial.ShowDialog();

                    //this.Show();
                    //this.textBox_nome.Select();
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