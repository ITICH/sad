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

        private void PesquisarParques_Load(object sender, EventArgs e)
        {
            string queryADM = "SELECT perfil FROM Empresa WHERE perfil = 1";//AINDA NÃO FUNCIONA CORRETAMENTE POR CAUSA DA ENCRIPTAÇÃO
            DataTable dadosUtilizador = ConecaoSQLServer.ExecutaSql(queryADM);

            if (dadosUtilizador.Rows.Count > 0)
            {
                button_addParque2.Enabled = true;
              //  button_addParque2.Visible = true;
            }
            else
            {
                button_addParque2.Enabled = false;
                //button_addParque2.Visible = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label_nomeParque_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_pesquisaP_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_addParque2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistoParques registoParques = new RegistoParques();
            registoParques.ShowDialog();
            this.Show();
        }

        private void button_pedirAcesso2_Click(object sender, EventArgs e)
        {

        }
    }
}
