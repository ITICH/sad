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
        //variáveis da conta do utilizador para que a app saiba que conta foi usada para o login
        //pw tem a password desencriptada enquanto não conseguimos desencriptar a partir da base de dados---------------ALTERAR ESTA PARTE DEPOIS DE ARRANJAR A PARTE DE DESENCRIPTAR
        //public int id;
        //public String pw;

        //metodo que encripta a palavra-passe antes de ser guardada na BD
        public string Encriptarpwd(string password) //VERIFICAR QUE METODO É USADO PARA ENCRIPTAR------------------------------------------------------
        {
            string msg = "";
            byte[] encode = new byte[password.Length];
            encode = Encoding.UTF8.GetBytes(password);
            msg = Convert.ToBase64String(encode);
            return msg;
        }

        public Login()
        {
            InitializeComponent();
        }

        //COMO DEFINIR ISTO METODO OU CLASSE????????????????????????????????????????????????????????????????
        public static string utilizadorLogado;
        public static int idUtilizadorLogado;
        public static string pwdUtilizadorLogado;

        public static string dadosLogin
        {
            get { return utilizadorLogado; }
            set { utilizadorLogado = value; }
        }

        public static int dadosLoginID
        {
            get { return idUtilizadorLogado; }
            set { idUtilizadorLogado = value; }
        }
        public static string dadosLoginPwd
        {
            get { return pwdUtilizadorLogado; }
            set { pwdUtilizadorLogado = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //variavel usada para guardar e identificar o utilizador depois do login
            string userAtual = textBox_nome.Text;

            //seleciona os utitilizadores com perfil de Empresa
            string queryLoginEMP = "SELECT id_empresa, e_mail, password, perfil FROM Empresa WHERE e_mail = '" + textBox_nome.Text + "' AND password = '" + Encriptarpwd(textBox_pw.Text) + "' AND perfil = 2";
            //seleciona os utitilizadores com perfil de Administrador
            string queryLoginADM = "SELECT id_empresa, e_mail, password, perfil FROM Empresa WHERE e_mail = '" + textBox_nome.Text + "' AND password = '" + Encriptarpwd(textBox_pw.Text) + "' AND perfil = 1";

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
                    dadosLogin = userAtual;
                    dadosLoginID = Int32.Parse(dadosUtilizador.Rows[0][0].ToString());
                    dadosLoginPwd = textBox_pw.Text;//-----------------------------------------------------ALTERAR ESTA PARTE DEPOIS DE ARRANJAR A PARTE DE DESENCRIPTAR

                    this.textBox_nome.Clear();
                    this.textBox_pw.Clear();
                    this.checkBox1.Checked = false;

                    this.Hide();

                    PaginaInicial paginaInicial = new PaginaInicial();
                    paginaInicial.ShowDialog();
                   
                   // this.Show();
                   // this.textBox_nome.Select();
                }
                //só pode ser acedido pelo perfil do ADM  ----------------------------------VERIFICAR SE É NECESSARIO OU NÃO TER ESTA PARTE
                else if (dadosUtilizadorADM.Rows.Count > 0)
                {
                    //guarda o id e a password da conta para saber que conta foi usada para o login
                    //this.id = Int32.Parse(dadosUtilizadorADM.Rows[0][0].ToString());
                    //this.pw = textBox_pw.Text; //-----------------------------------------------------ALTERAR ESTA PARTE DEPOIS DE ARRANJAR A PARTE DE DESENCRIPTAR

                    dadosLogin = userAtual;
                    dadosLoginID = Int32.Parse(dadosUtilizadorADM.Rows[0][0].ToString());
                    dadosLoginPwd = textBox_pw.Text;//-----------------------------------------------------ALTERAR ESTA PARTE DEPOIS DE ARRANJAR A PARTE DE DESENCRIPTAR

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}