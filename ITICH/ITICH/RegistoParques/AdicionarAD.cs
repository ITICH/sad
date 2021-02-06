using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ITICH.ConecaoBD;

using System.Diagnostics;

namespace ITICH.RegistoParques
{
    public partial class AdicionarAD : Form
    {
        enum Tipo
        {
            Area,
            Dominio
        }

        Tipo escolha;

        public AdicionarAD()
        {

        }

        public void initArea()
        {
            InitializeComponent();
            label_Descricao.Text = "Escreva o nome da Área de Negócio:";
            escolha = Tipo.Area;
        }

        public void initDominio()
        {
            InitializeComponent();
            label_Descricao.Text = "Escreva o nome do Domínio Científico e Tecnológico:";
            escolha = Tipo.Dominio;
        }

        private void button_Confirmar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox_AdicionarAD.Text) || String.IsNullOrEmpty(textBox_AdicionarAD.Text))
            {
                MessageBox.Show("Submissão inválida.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                switch (escolha)
                {
                    case Tipo.Area:
                        DataTable dtArea = ConecaoSQLServer.ExecutaSql("SELECT * FROM Nome_area WHERE nome_area = '" + textBox_AdicionarAD.Text + "'");
                        if (dtArea.Rows.Count > 0)
                        {
                            MessageBox.Show("Já existe uma área com este nome.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            ConecaoSQLServer.ExecutaSql("INSERT INTO Nome_area (nome_area) VALUES ('" + textBox_AdicionarAD.Text + "')");
                            MessageBox.Show("Área criada com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        Close();
                        break;
                    case Tipo.Dominio:
                        DataTable dtDominio = ConecaoSQLServer.ExecutaSql("SELECT * FROM Nome_dominio WHERE nome_dominio = '" + textBox_AdicionarAD.Text + "'");
                        if (dtDominio.Rows.Count > 0)
                        {
                            MessageBox.Show("Já existe um domínio com este nome.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            ConecaoSQLServer.ExecutaSql("INSERT INTO Nome_dominio (nome_dominio) VALUES ('" + textBox_AdicionarAD.Text + "')");
                            MessageBox.Show("Domínio criado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                        Close();
                        break;
                }


            }
        }

        private void AdicionarAD_Load(object sender, EventArgs e)
        {

        }
    }
}
