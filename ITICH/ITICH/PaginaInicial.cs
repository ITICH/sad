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
        public PaginaInicial()
        {
            InitializeComponent();
            
        }

        private void PaginaInicial_Load(object sender, EventArgs e)
        {
            string queryADM = "SELECT perfil FROM Empresa WHERE perfil = 1";//AINDA NÃO FUNCIONA CORRETAMENTE POR CAUSA DA ENCRIPTAÇÃO
            DataTable dadosUtilizador = ConecaoSQLServer.ExecutaSql(queryADM);

            if(dadosUtilizador.Rows.Count > 0)
            {
                button_addParque.Enabled = true;
                button_addParque.Visible = true;
            }
            else
            {
                button_addParque.Enabled = false;
                button_addParque.Visible = false;
            }
        }

        private void button_pedirAcesso_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_parques_Click(object sender, EventArgs e)
        {

        }

        private void button_addParque_Click(object sender, EventArgs e)
        {

        }

        private void button_simulacao_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
