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
        private static List<string> areas = new List<string>();
        private static List<string> dominios = new List<string>();
        private static DataTable incubadoras = new DataTable();
        private static DataTable instalacoes = new DataTable();

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

            if (incubadoras.Columns.Count != 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    incubadoras.Columns.Add(i.ToString(), typeof(string));
                }
            }

            if (instalacoes.Columns.Count != 9)
            {
                for (int i = 0; i < 9; i++)
                {
                    instalacoes.Columns.Add(i.ToString(), typeof(string));
                }
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
            if (comboBox_Area.SelectedItem != null)
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

        private void checkBox_Incubadora_CheckedChanged(object sender, EventArgs e)
        {
            _ = checkBox_Incubadora.Checked ? groupBox_Indubadora.Enabled = true : groupBox_Indubadora.Enabled = false;
        }
        private void button_AdicionarIncubadora_Click(object sender, EventArgs e)
        {
            if (verificarIncubadoras())
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
            else
            {
                MessageBox.Show("Existem erros nos dados.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private bool verificarIncubadoras()
        {
            bool result = true;
            if (!string.IsNullOrWhiteSpace(textBox_IncubadoraVolume.Text))
            {
                try
                {
                    int.Parse(textBox_IncubadoraVolume.Text);
                    result = true;
                }
                catch
                {
                    result = false;
                }
            }
            if (!string.IsNullOrWhiteSpace(textBox_IncubadoraRH.Text))
            {
                try
                {
                    int.Parse(textBox_IncubadoraRH.Text);
                    result = true;
                }
                catch
                {
                    result = false;
                }
            }
            return result;
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
            for (int i = 3; i < 5; i++)
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
                if (verificarGeral())
                {
                    criarParque();
                    MessageBox.Show("Parque criado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Existem erros nos dados.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Enabled = true;
                }
            }
        }
        private bool verificarGeral()
        {
            bool result = true;
            if (!string.IsNullOrWhiteSpace(textBox_TelefoneGeral.Text))
            {
                try
                {
                    int.Parse(textBox_TelefoneGeral.Text);
                    result = true;
                }
                catch
                {
                    result = false;
                }
            }
            if (!string.IsNullOrWhiteSpace(textBox_CapitalGeral.Text))
            {
                try
                {
                    int.Parse(textBox_CapitalGeral.Text);
                    result = true;
                }
                catch
                {
                    result = false;
                }
            }
            return result;
        }
        private void criarParque()
        {
            int indexLocalizacao;
            int indexParque;
            int indexIncubadora;
            int indexCaracteristicas;
            string nomeGeral;
            string moradaGeral;
            string concelhoGeral;
            string distritoGeral;
            string emailGeral;
            string telefoneGeral;
            string anoGeral;
            string entidadeGestoraGeral;
            int juridicialGeral;
            string capitalGeral;
            int faseGeral;
            int finsGeral;
            int interesseGeral;
            int temIncubadora;

            nomeGeral = textBox_NomeGeral.Text;
            moradaGeral = textBox_MoradaGeral.Text;
            concelhoGeral = textBox_ConcelhoGeral.Text;
            distritoGeral = textBox_DistritoGeral.Text;
            emailGeral = textBox_EmailGeral.Text;
            telefoneGeral = textBox_TelefoneGeral.Text;
            anoGeral = dateTimePicker_AnoGeral.Text;
            entidadeGestoraGeral = textBox_EntidadeGeral.Text;
            capitalGeral = textBox_CapitalGeral.Text;
            _ = comboBox_JuridicialGeral.SelectedIndex == -1 ? juridicialGeral = 0 : juridicialGeral = comboBox_JuridicialGeral.SelectedIndex;
            _ = comboBox_FaseGeral.SelectedIndex == -1 ? faseGeral = 0 : faseGeral = comboBox_FaseGeral.SelectedIndex;
            _ = checkBox_FinsGeral.Checked ? finsGeral = 1 : finsGeral = 0;
            _ = checkBox_InteresseGeral.Checked ? interesseGeral = 1 : interesseGeral = 0;
            _ = checkBox_Incubadora.Checked ? temIncubadora = 1 : temIncubadora = 0;
            if (areas.Count > 0)
            {
                for (int i = 0; i < areas.Count; i++)
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

            ConecaoSQLServer.ExecutaSql("INSERT INTO Localizacao (distrit, concelh, morada) VALUES ('" + distritoGeral + "', '" + concelhoGeral + "', '" + moradaGeral + "');");
            dataTable = ConecaoSQLServer.ExecutaSql("SELECT MAX(id_localizacao) FROM Localizacao");
            foundRows = dataTable.Select();
            indexLocalizacao = Convert.ToInt32(foundRows[0][0]);

            ConecaoSQLServer.ExecutaSql("INSERT INTO Parques_cientificos (entidade_gestora, fins_lucrativos, interesse_publico, contacto_tel, ano_de_inicio, patrimonio_acossiativo_e_capital_social, id_fase_de_desenvolvimento, id_carateristica_juridica, id_localizacao, nome_parque, e_mail, temIncubadora) VALUES (" +
                                        "'" + entidadeGestoraGeral + "', " +
                                        "'" + finsGeral + "', " +
                                        "'" + interesseGeral + "', " +
                                        "'" + telefoneGeral + "', " +
                                        "'" + anoGeral + "', " +
                                        "'" + capitalGeral + "', " +
                                        "'" + faseGeral + "', " +
                                        "'" + juridicialGeral + "', " +
                                        "'" + indexLocalizacao + "', " +
                                        "'" + nomeGeral + "', " +
                                        "'" + emailGeral + "', " +
                                        "'" + temIncubadora + "')"
                                        );
            dataTable = ConecaoSQLServer.ExecutaSql("SELECT MAX(id_parque) FROM Parques_cientificos");
            foundRows = dataTable.Select();
            indexParque = Convert.ToInt32(foundRows[0][0]);
            if (areas.Count > 0)
            {
                foreach (string item in areas)
                {
                    ConecaoSQLServer.ExecutaSql("INSERT INTO Areas_negocios (id_parque, id_nome_area) VALUES (" +
                                        "'" + indexParque + "', " +
                                        "'" + item + "')"
                                        );
                }
            }

            if (dominios.Count > 0)
            {
                foreach (string item in dominios)
                {
                    ConecaoSQLServer.ExecutaSql("INSERT INTO Dominios_cientificos_tecnologicos (id_parque, id_nome_dominio) VALUES (" +
                                        "'" + indexParque + "', " +
                                        "'" + item + "')"
                                        );
                }
            }
            if (checkBox_Incubadora.Checked)
            {
                if (incubadoras.Rows.Count > 0)
                {
                    for (int i = 0; i < incubadoras.Rows.Count; i++)
                    {
                        ConecaoSQLServer.ExecutaSql("INSERT INTO Incubadoras (volume_negocios, numero_de_pessoas, nom_inc, id_parque) VALUES (" +
                            "'" + incubadoras.Rows[i][1] + "', " +
                            "'" + incubadoras.Rows[i][2] + "', " +
                            "'" + incubadoras.Rows[i][0] + "', " +
                            "'" + indexParque + "')"
                            );
                        dataTable = ConecaoSQLServer.ExecutaSql("SELECT MAX(id_incubadora) FROM Incubadoras");
                        foundRows = dataTable.Select();
                        indexIncubadora = Convert.ToInt32(foundRows[0][0]);

                        ConecaoSQLServer.ExecutaSql("INSERT INTO Espacos_incubadora (tipo_espaco, id_incubadora) VALUES (" +
                        "'" + incubadoras.Rows[i][3] + "', " +
                        "'" + indexIncubadora + "')"
                        );

                        ConecaoSQLServer.ExecutaSql("INSERT INTO Servicos_incubadora (tipo_servico, id_incubadora) VALUES (" +
                        "'" + incubadoras.Rows[i][4] + "', " +
                        "'" + indexIncubadora + "')"
                        );
                    }
                }
            }
            if (instalacoes.Rows.Count > 0)
            {

                for (int i = 0; i < instalacoes.Rows.Count; i++)
                {
                    ConecaoSQLServer.ExecutaSql("INSERT INTO Carateristicas_instalacoes (num_lotes, num_lotes_ocupados, estacionamento, videovigilancia, seguranca, tipo_de_rede) VALUES (" +
                        "'" + instalacoes.Rows[i][3] + "', " +
                        "'" + instalacoes.Rows[i][4] + "', " +
                        "'" + instalacoes.Rows[i][5] + "', " +
                        "'" + instalacoes.Rows[i][6] + "', " +
                        "'" + instalacoes.Rows[i][7] + "', " +
                        "'" + instalacoes.Rows[i][8] + "')"
                        );
                    dataTable = ConecaoSQLServer.ExecutaSql("SELECT MAX(id_carateristicas) FROM Carateristicas_instalacoes");
                    foundRows = dataTable.Select();
                    indexCaracteristicas = Convert.ToInt32(foundRows[0][0]);

                    ConecaoSQLServer.ExecutaSql("INSERT INTO Instalacoes (id_carateristicas, id_parque, designaca, localidad, concelh) VALUES (" +
                        "'" + indexCaracteristicas + "', " +
                        "'" + indexParque + "', " +
                        "'" + instalacoes.Rows[i][0] + "', " +
                        "'" + instalacoes.Rows[i][1] + "', " +
                        "'" + instalacoes.Rows[i][2] + "')"
                        );
                }
            }

            areas.Clear();
            dominios.Clear();
            incubadoras.Clear();
            instalacoes.Clear();
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult cancelarParque = MessageBox.Show("Tem a certeza que quer sair?\n(Os valores inseridos não serão gravados)", "Cancelar Submissão", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (cancelarParque == DialogResult.Yes)
            {
                Close();
            }
        }

        private void RegistoParque_Load(object sender, EventArgs e)
        {

        }
    }
}
