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
using System.Collections;
using System.Media;

namespace ITICH.RegistoParques
{
    public partial class RegistoParque : Form
    {
        private DataTable dataTable;
        private DataRow[] foundRows;

        public static string nomeGeral;
        public static string moradaGeral;
        public static string concelhoGeral;
        public static string distritoGeral;
        public static string emailGeral;
        public static string telefoneGeral;
        public static string anoGeral;
        public static string entidadeGestoraGeral;
        public static int juridicialGeral;
        public static string capitalGeral;
        public static int faseGeral;
        public static int finsGeral;
        public static int interesseGeral;
        public static List<string> areas = new List<string>();
        public static List<string> dominios = new List<string>();
        public static DataTable incubadoras = new DataTable();
        public static DataTable instalacoes = new DataTable();

        public RegistoParque()
        {
            InitializeComponent();

            dataTable = ConecaoSQLServer.ExecutaSql("SELECT * FROM Carateristicas_juridicas");
            foundRows = dataTable.Select();
            for (int i = 0; i < foundRows.Length; i++)
            {
                comboBox_JuridicialGeral.Items.Add(foundRows[i][1].ToString());
            }
            dataTable = ConecaoSQLServer.ExecutaSql("SELECT * FROM Fases_desenvolvimento");
            foundRows = dataTable.Select();
            for (int i = 0; i < foundRows.Length; i++)
            {
                comboBox_FaseGeral.Items.Add(foundRows[i][1].ToString());
            }

            for(int i = 0; i < 5; i++)
            {
                incubadoras.Columns.Add(i.ToString(), typeof(string));
            }
            for (int i = 0; i < 9; i++)
            {
                instalacoes.Columns.Add(i.ToString(), typeof(string));
            }

            Refresh();
        }

        public override void Refresh()
        {
            this.Enabled = false;
            comboBox_Area.Text = "Selecione Área...";
            comboBox_Area.Items.Clear();
            dataTable = ConecaoSQLServer.ExecutaSql("SELECT * FROM Nome_area");
            foundRows = dataTable.Select();
            for (int i = 0; i < foundRows.Length; i++)
            {
                comboBox_Area.Items.Add(foundRows[i][1].ToString());
            }
            foreach (string item in areas)
            {
                comboBox_Area.Items.Remove(item);
            }

            comboBox_Dominio.Text = "Selecione Domínio...";
            comboBox_Dominio.Items.Clear();
            dataTable = ConecaoSQLServer.ExecutaSql("SELECT * FROM Nome_dominio");
            foundRows = dataTable.Select();
            for (int i = 0; i < foundRows.Length; i++)
            {
                comboBox_Dominio.Items.Add(foundRows[i][1].ToString());
            }
            foreach (string item in dominios)
            {
                comboBox_Dominio.Items.Remove(item);
            }
            base.Refresh();
            this.Enabled = true;
        }

        private void button_AdicionarArea_Click(object sender, EventArgs e)
        {
            if(comboBox_Area.SelectedItem != null)
            {
                areas.Add(comboBox_Area.SelectedItem.ToString());
                int areaRowIndex = dataGridView_Area.Rows.Add();
                dataGridView_Area.Rows[areaRowIndex].Cells[0].Value = comboBox_Area.SelectedItem.ToString();
                button_RemoverArea.Enabled = true;
                Refresh();
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }
        private void button_RemoverArea_Click(object sender, EventArgs e)
        {
            if (dataGridView_Area.RowCount > 0)
            {
                areas.Remove(dataGridView_Area.SelectedCells[0].Value.ToString());
                dataGridView_Area.Rows.RemoveAt(dataGridView_Area.CurrentCell.RowIndex);
                Refresh();
            }
            if (dataGridView_Area.RowCount == 0)
            {
                button_RemoverArea.Enabled = false;
            }
        }
        private void button_CriarArea_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            AdicionarAD adicionarAD = new AdicionarAD();
            adicionarAD.initArea();
            adicionarAD.ShowDialog();
            this.Enabled = true;
            Refresh();
        }

        private void button_AdicionarDominio_Click(object sender, EventArgs e)
        {
            if (comboBox_Dominio.SelectedItem != null)
            {
                dominios.Add(comboBox_Dominio.SelectedItem.ToString());
                int dominioRowIndex = dataGridView_Dominio.Rows.Add();
                dataGridView_Dominio.Rows[dominioRowIndex].Cells[0].Value = comboBox_Dominio.SelectedItem.ToString();
                button_RemoverDominio.Enabled = true;
                Refresh();
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }
        private void button_RemoverDominio_Click(object sender, EventArgs e)
        {
            if (dataGridView_Dominio.RowCount > 0)
            {
                dominios.Remove(dataGridView_Dominio.SelectedCells[0].Value.ToString());
                dataGridView_Dominio.Rows.RemoveAt(dataGridView_Dominio.CurrentCell.RowIndex);
                Refresh();
            }
            if (dataGridView_Dominio.RowCount == 0)
            {
                button_RemoverDominio.Enabled = false;
            }
        }
        private void button_CriarDominio_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            AdicionarAD adicionarAD = new AdicionarAD();
            adicionarAD.initDominio();
            adicionarAD.ShowDialog();
            this.Enabled = true;
            Refresh();
        }

        private void button_AdicionarIncubadora_Click(object sender, EventArgs e)
        {
            bool isIncubadoraEmpty = true;
            DataRow incubadorasRow;
            incubadorasRow = incubadoras.NewRow();
            incubadorasRow[0] = textBox_IncubadoraNome.Text;
            incubadorasRow[1] = textBox_IncubadoraVolume.Text;
            incubadorasRow[2] = textBox_IncubadoraRH.Text;
            incubadorasRow[3] = textBox_IncubadoraEspaco.Text;
            incubadorasRow[4] = textBox_IncubadoraServico.Text;
            for (int i = 0; i < incubadoras.Columns.Count; i++)
            {
                if (!String.IsNullOrWhiteSpace(incubadorasRow[i].ToString()))
                {
                    isIncubadoraEmpty = false;
                    break;
                }
            }
            if (!isIncubadoraEmpty)
            {
                incubadoras.Rows.Add(incubadorasRow);
                int IncubadoraRowIndex = dataGridView_Incubadora.Rows.Add();
                for (int i = 0; i < incubadoras.Columns.Count; i++)
                {
                    dataGridView_Incubadora.Rows[IncubadoraRowIndex].Cells[i].Value = incubadorasRow[i];
                }
                textBox_IncubadoraNome.Clear();
                textBox_IncubadoraVolume.Clear();
                textBox_IncubadoraRH.Clear();
                textBox_IncubadoraEspaco.Clear();
                textBox_IncubadoraServico.Clear();
                button_RemoverIncubadora.Enabled = true;
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }
        private void button_RemoverIncubadora_Click(object sender, EventArgs e)
        {
            if (dataGridView_Incubadora.RowCount > 0)
            {
                DataRow[] incubadorasRow;
                incubadorasRow = incubadoras.Select();
                incubadorasRow[dataGridView_Incubadora.CurrentCell.RowIndex].Delete();
                dataGridView_Incubadora.Rows.RemoveAt(dataGridView_Incubadora.CurrentCell.RowIndex);
            }
            if (dataGridView_Incubadora.RowCount == 0)
            {
                button_RemoverIncubadora.Enabled = false;
            }
        }

        private void button_AdicionarInstalacao_Click(object sender, EventArgs e)
        {
            bool isInstalacaoEmpty = true;
            DataRow instalacoesRow;
            instalacoesRow = instalacoes.NewRow();
            instalacoesRow[0] = textBox_NomeInstalacao.Text;
            instalacoesRow[1] = textBox_LocalidadeInstalacao.Text;
            instalacoesRow[2] = textBox_ConcelhoInstalacao.Text;
            instalacoesRow[3] = numericUpDown_LotesInstalacao.Text;
            instalacoesRow[4] = numericUpDown_OcupadosInstalacao.Text;
            instalacoesRow[5] = checkBox_EstacionamentoInstalacao.CheckState;
            instalacoesRow[6] = checkBox_VigilanciaInstalacao.CheckState;
            instalacoesRow[7] = checkBox_SegurancaInstalacao.CheckState;
            instalacoesRow[8] = textBox_RedeInstalacao.Text;
            for (int i = 0; i < 3; i++)
            {
                if (!String.IsNullOrWhiteSpace(instalacoesRow[i].ToString()))
                {
                    isInstalacaoEmpty = false;
                    break;
                }
            }
            for (int i = 5; i < 8; i++)
            {
                if (instalacoesRow[i].ToString() == "Checked")
                {
                    isInstalacaoEmpty = false;
                    break;
                }
            }
            for(int i = 3; i < 5; i++)
            {
                if (Convert.ToInt32(instalacoesRow[i]) > 0)
                {
                    isInstalacaoEmpty = false;
                    break;
                }
            }
            if (!String.IsNullOrWhiteSpace(instalacoesRow[8].ToString()))
            {
                isInstalacaoEmpty = false;
            }
            
            if (!isInstalacaoEmpty)
            {
                instalacoes.Rows.Add(instalacoesRow);
                int InstalacoesRowIndex = dataGridView_Instalacao.Rows.Add();
                dataGridView_Instalacao.Rows[InstalacoesRowIndex].Cells[0].Value = textBox_NomeInstalacao.Text;
                dataGridView_Instalacao.Rows[InstalacoesRowIndex].Cells[1].Value = textBox_LocalidadeInstalacao.Text;
                dataGridView_Instalacao.Rows[InstalacoesRowIndex].Cells[2].Value = textBox_ConcelhoInstalacao.Text;
                dataGridView_Instalacao.Rows[InstalacoesRowIndex].Cells[3].Value = numericUpDown_LotesInstalacao.Text;
                dataGridView_Instalacao.Rows[InstalacoesRowIndex].Cells[4].Value = numericUpDown_OcupadosInstalacao.Text;
                dataGridView_Instalacao.Rows[InstalacoesRowIndex].Cells[5].Value = checkBox_EstacionamentoInstalacao.CheckState;
                dataGridView_Instalacao.Rows[InstalacoesRowIndex].Cells[6].Value = checkBox_VigilanciaInstalacao.CheckState;
                dataGridView_Instalacao.Rows[InstalacoesRowIndex].Cells[7].Value = checkBox_SegurancaInstalacao.CheckState;
                dataGridView_Instalacao.Rows[InstalacoesRowIndex].Cells[8].Value = textBox_RedeInstalacao.Text;
                textBox_NomeInstalacao.Clear();
                textBox_LocalidadeInstalacao.Clear();
                textBox_ConcelhoInstalacao.Clear();
                numericUpDown_LotesInstalacao.Value = 0;
                numericUpDown_OcupadosInstalacao.Value = 0;
                checkBox_EstacionamentoInstalacao.Checked = false;
                checkBox_VigilanciaInstalacao.Checked = false;
                checkBox_SegurancaInstalacao.Checked = false;
                textBox_RedeInstalacao.Clear();
                button_RemoverInstalacao.Enabled = true;
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }
        private void button_RemoverInstalacao_Click(object sender, EventArgs e)
        {
            if (dataGridView_Instalacao.RowCount > 0)
            {
                DataRow[] instalacoesRow;
                instalacoesRow = instalacoes.Select();
                instalacoesRow[dataGridView_Instalacao.CurrentCell.RowIndex].Delete();
                dataGridView_Instalacao.Rows.RemoveAt(dataGridView_Instalacao.CurrentCell.RowIndex);
            }
            if (dataGridView_Instalacao.RowCount == 0)
            {
                button_RemoverInstalacao.Enabled = false;
            }
        }
        private void numericUpDown_LotesInstalacao_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_OcupadosInstalacao.Maximum = numericUpDown_LotesInstalacao.Value;
        }
        private void numericUpDown_OcupadosInstalacao_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_OcupadosInstalacao.Maximum = numericUpDown_LotesInstalacao.Value;
        }

        private void button_Confirmar_Click(object sender, EventArgs e)
        {
            DialogResult confirmarParque = MessageBox.Show("Deseja confirmar o parque criado?", "Confirmar Submissão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmarParque == DialogResult.Yes)
            {
                this.Enabled = false;
                nomeGeral = textBox_NomeGeral.Text;
                moradaGeral = textBox_MoradaGeral.Text;
                concelhoGeral = textBox_ConcelhoGeral.Text;
                distritoGeral = textBox_DistritoGeral.Text;
                emailGeral = textBox_EmailGeral.Text;
                telefoneGeral = textBox_TelefoneGeral.Text;
                anoGeral = dateTimePicker_AnoGeral.ToString();
                entidadeGestoraGeral = textBox_EntidadeGeral.Text;
                capitalGeral = textBox_CapitalGeral.Text;
                juridicialGeral = comboBox_JuridicialGeral.SelectedIndex;
                faseGeral = comboBox_FaseGeral.SelectedIndex;

                _ = checkBox_FinsGeral.Checked ? finsGeral = 1 : finsGeral = 0;
                _ = checkBox_InteresseGeral.Checked ? interesseGeral = 1 : interesseGeral = 0;

                if (areas.Count > 0)
                {
                    for(int i = 0; i < areas.Count; i++)
                    {
                        dataTable = ConecaoSQLServer.ExecutaSql("SELECT id_nome_area FROM Nome_area WHERE(nome_area = '" + areas[i] + "');");
                        foundRows = dataTable.Select();
                        areas[i] = foundRows[0][0].ToString();
                    }
                }

                if (dominios.Count > 0)
                {
                    for (int i = 0; i < dominios.Count; i++)
                    {
                        dataTable = ConecaoSQLServer.ExecutaSql("SELECT id_nome_dominio FROM Nome_dominio WHERE(nome_dominio = '" + dominios[i] + "');");
                        foundRows = dataTable.Select();
                        dominios[i] = foundRows[0][0].ToString();
                    }
                }

                if (instalacoes.Rows.Count > 0)
                {
                    for (int i = 0; i < instalacoes.Rows.Count; i++)
                    {
                        for (int k = 5; k < 8; k++)
                        {
                            _ = instalacoes.Rows[i][k].Equals("Checked") ? instalacoes.Rows[i][k] = "1" : instalacoes.Rows[i][k] = "0";
                            Console.WriteLine(instalacoes.Rows[i][k]);
                        }
                    }
                }
                CriarParque criarParque = new CriarParque();
                criarParque.ShowDialog();
                this.Enabled = true;
            }
        }
        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            /*
            DialogResult cancelarParque = MessageBox.Show("Tem a certeza que quer sair?\n(Os valores inseridos não serão gravados)", "Cancelar Submissão", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (cancelarParque == DialogResult.Yes)
            {
                Close();
            }
            */
        }


    }
}
