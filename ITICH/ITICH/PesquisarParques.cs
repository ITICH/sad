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
    public partial class PesquisarParques : Form
    {
        public PesquisarParques()
        {
            InitializeComponent();
        }
        private void dadosDataGrid(string sql)
        {
            DataTable dadosParques = ConecaoSQLServer.ExecutaSql(sql);
            dataGridView1.DataSource = dadosParques;
            dataGridView1.Columns[0].HeaderText = "Parque Científico";
            dataGridView1.Columns[1].HeaderText = "Localidade";
            dataGridView1.Columns[2].HeaderText = "Email";
            dataGridView1.Columns[0].Width = 212;
            dataGridView1.Columns[1].Width = 213;
            dataGridView1.Columns[2].Width = 213;
        }
        private void PesquisarParques_Load(object sender, EventArgs e)
        {
            //verifica qual é o utilizador que está logado
            string utilizadorLogador = Login.dadosLogin;
            //verifica se o utilizado logado é administrador ou utilizador normal
            //string queryADM = "SELECT e_mail, perfil FROM Empresa WHERE e_mail='" + utilizadorLogador + "' AND perfil = 1";//AINDA NÃO FUNCIONA CORRETAMENTE POR CAUSA DA ENCRIPTAÇÃO -- falta tambem verificar o utilizador
            //DataTable dadosUtilizador = ConecaoSQLServer.ExecutaSql(queryADM);
            string mostrarParques = "SELECT P.nome_parque, L.distrit, P.e_mail FROM Parques_cientificos P, Localizacao L WHERE L.id_localizacao = P.id_localizacao";
            dadosDataGrid(mostrarParques);
        }
        private void groupBox1_Enter(object sender, EventArgs e){ }
        private void label_nomeParque_Click(object sender, EventArgs e){ }
        private void textBox1_TextChanged(object sender, EventArgs e){ }
        private void button_pesquisaP_Click(object sender, EventArgs e)
        {
            string pesquisaNome = "SELECT P.nome_parque, L.distrit, P.e_mail FROM Parques_cientificos P, Localizacao L WHERE P.nome_parque ='" + textBox_pesquisa.Text + "' AND L.id_localizacao = P.id_localizacao";
            string pesquisaDistrito = "SELECT P.nome_parque, L.distrit, P.e_mail FROM Parques_cientificos P, Localizacao L WHERE L.distrit ='" + textBox_pesqDistrito.Text + "' AND L.id_localizacao = P.id_localizacao";
            string pesquisaNomeDistrito = "SELECT P.nome_parque, L.distrit, P.e_mail FROM Parques_cientificos P, Localizacao L WHERE P.nome_parque ='" + textBox_pesquisa.Text + "'AND L.distrit ='" + textBox_pesqDistrito.Text + "' AND L.id_localizacao = P.id_localizacao";
            
            if (string.IsNullOrEmpty(textBox_pesquisa.Text) && string.IsNullOrEmpty(textBox_pesqDistrito.Text))
            {
                MessageBox.Show("Introduza um dos campos de pesquisa!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_pesquisa.Select();
            }
            else if (!string.IsNullOrEmpty(textBox_pesquisa.Text) && string.IsNullOrEmpty(textBox_pesqDistrito.Text))
            {
                dadosDataGrid(pesquisaNome);
            }
            else if (string.IsNullOrEmpty(textBox_pesquisa.Text) && !string.IsNullOrEmpty(textBox_pesqDistrito.Text))
            {
                dadosDataGrid(pesquisaDistrito);
            }
            else
            {
                dadosDataGrid(pesquisaNomeDistrito);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){ }
        private void button_pedirAcesso2_Click(object sender, EventArgs e)
        {
            EnviarPedidoEmail enviarPedidoEmail = new EnviarPedidoEmail();
            enviarPedidoEmail.ShowDialog();
            this.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaginaInicial paginaInicial = new PaginaInicial();
            paginaInicial.ShowDialog();
            this.Show();
        }
        private void textBox_pesqDistrito_TextChanged(object sender, EventArgs e){ }
        private void label1_distrito_Click(object sender, EventArgs e){ }
    }
}
