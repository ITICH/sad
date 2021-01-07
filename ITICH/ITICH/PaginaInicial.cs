using ITICH.ConecaoBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITICH
{
    public partial class PaginaInicial : Form
    {
        //variáveis da conta do utilizador para que a app saiba que conta foi usada para o login
        //pw tem a password desencriptada enquanto não conseguimos desencriptar a partir da base de dados
        //int id;
        //String pw;//-----------------------------------------------------------------ALTERAR DEPOIS DE ARRANJAR A PARTE DA DESENCRIPTAÇÃO

        public PaginaInicial()
        {
            InitializeComponent();

        }

        //verifica qual é o utilizador que está logado
        string utilizadorLogado = Login.dadosLogin;
        int utilizadorLogadoId = Login.dadosLoginID;
        //string utilizadorLogadopw = Login.dadosLoginPwd;

        private void PaginaInicial_Load(object sender, EventArgs e)
        {
            //string queryADM = "SELECT perfil FROM Empresa WHERE perfil = 1";//AINDA NÃO FUNCIONA CORRETAMENTE POR CAUSA DA ENCRIPTAÇÃO
            string queryADM = "SELECT e_mail, perfil FROM Empresa WHERE e_mail='" + utilizadorLogado + "' AND perfil = 1";//AINDA NÃO FUNCIONA CORRETAMENTE POR CAUSA DA ENCRIPTAÇÃO
            DataTable dadosUtilizador = ConecaoSQLServer.ExecutaSql(queryADM);
            
            if (dadosUtilizador.Rows.Count > 0)
            {
                button_addParque.Enabled = true;
                //button_addParque.Visible = true;            
            }
            else
            {
                button_addParque.Enabled = false;
                //button_addParque.Visible = false;
            }
            //mostra o nome da empresa
            string queryNomeUser = "SELECT nome_empresa FROM Empresa WHERE id_empresa='" + utilizadorLogadoId + "'";
            DataTable nomeUtilizador = ConecaoSQLServer.ExecutaSql(queryNomeUser);
            label_nomeEmpresa.Text = nomeUtilizador.Rows[0][0].ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DadosEmpresa dadosEmpresa = new DadosEmpresa(utilizadorLogadoId);
            dadosEmpresa.ShowDialog();
            this.Show();
        }

        private void button2_parques_Click(object sender, EventArgs e)
        {
            this.Hide();
            PesquisarParques pesquisarParques = new PesquisarParques();
            pesquisarParques.ShowDialog();
            this.Show();
        }

        private void button_addParque_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistoParques registoParques = new RegistoParques();
            registoParques.ShowDialog();
            this.Show();
            
        }

        private void button_simulacao_Click(object sender, EventArgs e)
        {
            this.Hide();
            Simulacao simulacao = new Simulacao();
            simulacao.ShowDialog();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tab11_Load(object sender, EventArgs e)
        {

        }

        private void tab12_Load(object sender, EventArgs e)
        {

        }

        private void label_nomeEmpresa_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
