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
using ITICH.RegistoParques;
using System.Diagnostics;

using System.Diagnostics;
using System.Media;

namespace ITICH.RegistoParques
{
    public partial class RegistoForm : Form
    {
        private bool safeToQuit = false;

        private DataTable dataTable;
        private DataRow[] foundRows;

        private static List<string> areas = new List<string>();
        private static List<string> dominios = new List<string>();

        public RegistoForm()
        {
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(RegistoForm_FormClosing);

            //Popular com os dados encontrados na base de dados
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

            Refresh();
        }

        //Override do metodo Refresh
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

        //Verificar Dados Gerais
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

        //AREAS
        //Adicionar Area
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
        //Remover Area
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
        //Criar Area
        private void button_CriarArea_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            AdicionarAD adicionarAD = new AdicionarAD();
            adicionarAD.initArea();
            adicionarAD.ShowDialog();
            this.Enabled = true;
            Refresh();
        }

        //DOMINIOS
        //Adicionar Dominio
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
        //Remover Dominio
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
        //Criar Dominio
        private void button_CriarDominio_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            AdicionarAD adicionarAD = new AdicionarAD();
            adicionarAD.initDominio();
            adicionarAD.ShowDialog();
            this.Enabled = true;
            Refresh();
        }

        //INCUBADORAS
        //Adicionar Espaço
        private void button_AdicionarEspaco_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_Espaco.Text))
            {
                bool hasDupe = false;
                for (int i = 0; i < dataGridView_Espaco.Rows.Count; i++)
                {
                    if (textBox_Espaco.Text.ToLower().Replace(" ", "") == dataGridView_Espaco.Rows[i].Cells[0].Value.ToString().ToLower().Replace(" ", ""))
                    {
                        hasDupe = true;
                    }
                }
                if (!hasDupe)
                {
                    int espacoRowIndex = dataGridView_Espaco.Rows.Add();
                    dataGridView_Espaco.Rows[espacoRowIndex].Cells[0].Value = textBox_Espaco.Text.ToString();
                    textBox_Espaco.Clear();
                    button_RemoverEspaco.Enabled = true;
                    Refresh();
                }
                else
                {
                    MessageBox.Show("Já existe um espaço com esse nome.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }
        //Remover Espaço
        private void button_RemoverEspaco_Click(object sender, EventArgs e)
        {
            if (dataGridView_Espaco.RowCount > 0)
            {
                dataGridView_Espaco.Rows.RemoveAt(dataGridView_Espaco.CurrentCell.RowIndex);
            }
            if (dataGridView_Espaco.RowCount == 0)
            {
                button_RemoverEspaco.Enabled = false;
            }
        }
        //Adicionar Serviço
        private void button_AdicionarServico_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_Servico.Text))
            {
                bool hasDupe = false;
                for (int i = 0; i < dataGridView_Servico.Rows.Count; i++)
                {
                    if (textBox_Servico.Text.ToLower().Replace(" ", "") == dataGridView_Servico.Rows[i].Cells[0].Value.ToString().ToLower().Replace(" ", ""))
                    {
                        hasDupe = true;
                    }
                }
                if (!hasDupe)
                {
                    int servicoRowIndex = dataGridView_Servico.Rows.Add();
                    dataGridView_Servico.Rows[servicoRowIndex].Cells[0].Value = textBox_Servico.Text.ToString();
                    textBox_Servico.Clear();
                    button_RemoverServico.Enabled = true;
                    Refresh();
                }
                else
                {
                    MessageBox.Show("Já existe um serviço com esse nome.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }
        //Remover Serviço
        private void button_RemoverServico_Click(object sender, EventArgs e)
        {
            if (dataGridView_Servico.RowCount > 0)
            {
                dataGridView_Servico.Rows.RemoveAt(dataGridView_Servico.CurrentCell.RowIndex);
            }
            if (dataGridView_Servico.RowCount == 0)
            {
                button_RemoverServico.Enabled = false;
            }
        }
        //Verificar campos da Incubadora
        private bool verificarIncubadoras()
        {
            bool result = true;
            if (!string.IsNullOrWhiteSpace(textBox_VolumeIncubadora.Text))
            {
                try
                {
                    int.Parse(textBox_VolumeIncubadora.Text);
                    result = true;
                }
                catch
                {
                    result = false;
                }
            }
            if (!string.IsNullOrWhiteSpace(textBox_RHIncubadora.Text))
            {
                try
                {
                    int.Parse(textBox_RHIncubadora.Text);
                    result = true;
                }
                catch
                {
                    result = false;
                }
            }
            return result;
        }
        //Adicionar Incubadora
        private void button_AdicionarIncubadora_Click(object sender, EventArgs e)
        {
            if (verificarIncubadoras())
            {

                if (!string.IsNullOrEmpty(textBox_NomeIncubadora.Text) ||
                    !string.IsNullOrEmpty(textBox_VolumeIncubadora.Text) ||
                    !string.IsNullOrEmpty(textBox_RHIncubadora.Text) ||
                    dataGridView_Espaco.Rows.Count > 0)
                {
                    int IncubadoraRowIndex = dataGridView_Incubadora.Rows.Add();

                    dataGridView_Incubadora.Rows[IncubadoraRowIndex].Cells[0].Value = textBox_NomeIncubadora.Text;
                    dataGridView_Incubadora.Rows[IncubadoraRowIndex].Cells[1].Value = textBox_VolumeIncubadora.Text;
                    dataGridView_Incubadora.Rows[IncubadoraRowIndex].Cells[2].Value = textBox_RHIncubadora.Text;
                    DataGridViewComboBoxCell espacoCell = (DataGridViewComboBoxCell)dataGridView_Incubadora[3, IncubadoraRowIndex];
                    espacoCell.Items.Clear();
                    for (int i = 0; i < dataGridView_Espaco.Rows.Count; i++)
                    {
                        espacoCell.Items.Add(dataGridView_Espaco.Rows[i].Cells[0].Value.ToString());
                    }

                    textBox_Espaco.Clear();
                    while (dataGridView_Espaco.Rows.Count > 0)
                    {
                        dataGridView_Espaco.Rows.RemoveAt(0);
                    }
                    textBox_NomeIncubadora.Clear();
                    textBox_VolumeIncubadora.Clear();
                    textBox_RHIncubadora.Clear();
                    textBox_Espaco.Clear();
                    button_RemoverIncubadora.Enabled = true;
                }
                else
                {
                    SystemSounds.Beep.Play();
                }
            }
            else
            {
                MessageBox.Show("Existem dados que não foram inseridos corretamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Remover Incubadora
        private void button_RemoverIncubadora_Click(object sender, EventArgs e)
        {
            if (dataGridView_Incubadora.RowCount > 0)
            {
                dataGridView_Incubadora.Rows.RemoveAt(dataGridView_Incubadora.CurrentCell.RowIndex);
            }
            if (dataGridView_Incubadora.RowCount == 0)
            {
                button_RemoverIncubadora.Enabled = false;
            }
        }

        //INSTALACOES
        //Adicionar Instalacao
        private void button_AdicionarInstalacao_Click(object sender, EventArgs e)
        {
            bool isInstalacaoEmpty;

            _ = String.IsNullOrEmpty(textBox_NomeInstalacao.Text) ? isInstalacaoEmpty = true : isInstalacaoEmpty = false;

            if (!isInstalacaoEmpty)
            {
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

                for (int i = 0; i < dataGridView_Instalacao.Rows.Count; i++)
                {
                    int estacionamento = dataGridView_Instalacao.Rows[i].Cells[5].Value.ToString() == "Checked" ? estacionamento = 1 : estacionamento = 0;
                }
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }
        //Remover Instalacao
        private void button_RemoverInstalacao_Click(object sender, EventArgs e)
        {
            if (dataGridView_Instalacao.RowCount > 0)
            {
                dataGridView_Instalacao.Rows.RemoveAt(dataGridView_Instalacao.CurrentCell.RowIndex);
            }
            if (dataGridView_Instalacao.RowCount == 0)
            {
                button_RemoverInstalacao.Enabled = false;
            }
        }
        //Limites Instalacao
        private void numericUpDown_LotesInstalacao_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_OcupadosInstalacao.Maximum = numericUpDown_LotesInstalacao.Value;
        }
        private void numericUpDown_OcupadosInstalacao_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_OcupadosInstalacao.Maximum = numericUpDown_LotesInstalacao.Value;
        }

        //Confirmar
        private void button_Confirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_NomeGeral.Text))
            {
                MessageBox.Show("Por favor especificar o nome do parque.", "Erro na Submissão!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verificarGeral())
            {
                DialogResult confirmarParque = MessageBox.Show("Deseja confirmar o parque criado?", "Confirmar Submissão?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmarParque == DialogResult.Yes)
                {
                    this.Enabled = false;
                    criarParque();
                    MessageBox.Show("Parque criado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    safeToQuit = true;
                    this.Enabled = true;
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Não existem erros no formulário.\nPor favor, verifique os seus dados.", "Erro na Submissão!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Criar Parque
        private void criarParque()
        {
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

            ConecaoSQLServer.ExecutaSql("INSERT INTO Localizacao (distrit, concelh, morada) VALUES ('" + textBox_DistritoGeral.Text + "', '" + textBox_ConcelhoGeral.Text + "', '" + textBox_MoradaGeral.Text + "');");
            dataTable = ConecaoSQLServer.ExecutaSql("SELECT MAX(id_localizacao) FROM Localizacao");
            foundRows = dataTable.Select();
            int indexLocalizacao = Convert.ToInt32(foundRows[0][0]);

            int finsGeral = checkBox_FinsGeral.Checked ? 1 : 0;
            int interesseGeral = checkBox_InteresseGeral.Checked ? 1 : 0;
            int juridicialGeral = comboBox_JuridicialGeral.SelectedIndex == -1 ? 0 : comboBox_JuridicialGeral.SelectedIndex;
            int faseGeral = comboBox_FaseGeral.SelectedIndex == -1 ? 0 : comboBox_FaseGeral.SelectedIndex;
            int temIncubadora = dataGridView_Incubadora.Rows.Count > 0 ? temIncubadora = 1 : temIncubadora = 0;
            ConecaoSQLServer.ExecutaSql("INSERT INTO Parques_cientificos (entidade_gestora, fins_lucrativos, interesse_publico, contacto_tel, ano_de_inicio, patrimonio_acossiativo_e_capital_social, id_fase_de_desenvolvimento, id_carateristica_juridica, id_localizacao, nome_parque, e_mail, temIncubadora) VALUES (" +
                                        "'" + textBox_EntidadeGeral.Text + "', " +
                                        "'" + finsGeral + "', " +
                                        "'" + interesseGeral + "', " +
                                        "'" + textBox_TelefoneGeral.Text + "', " +
                                        "'" + dateTimePicker_AnoGeral.Text + "', " +
                                        "'" + textBox_CapitalGeral.Text + "', " +
                                        "'" + faseGeral + "', " +
                                        "'" + juridicialGeral + "', " +
                                        "'" + indexLocalizacao + "', " +
                                        "'" + textBox_NomeGeral.Text + "', " +
                                        "'" + textBox_EmailGeral.Text + "', " +
                                        "'" + temIncubadora + "')"
                                        );

            dataTable = ConecaoSQLServer.ExecutaSql("SELECT MAX(id_parque) FROM Parques_cientificos");
            foundRows = dataTable.Select();
            int indexParque = Convert.ToInt32(foundRows[0][0]);

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

            if (temIncubadora == 1)
            {
                for (int i = 0; i < dataGridView_Incubadora.Rows.Count; i++)
                {
                    ConecaoSQLServer.ExecutaSql("INSERT INTO Incubadoras (volume_negocios, numero_de_pessoas, nom_inc, id_parque) VALUES (" +
                        "'" + dataGridView_Incubadora.Rows[i].Cells[1].Value.ToString() + "', " +
                        "'" + dataGridView_Incubadora.Rows[i].Cells[2].Value.ToString() + "', " +
                        "'" + dataGridView_Incubadora.Rows[i].Cells[0].Value.ToString() + "', " +
                        "'" + indexParque + "')"
                        );
                    dataTable = ConecaoSQLServer.ExecutaSql("SELECT MAX(id_incubadora) FROM Incubadoras");
                    foundRows = dataTable.Select();
                    int indexIncubadora = Convert.ToInt32(foundRows[0][0]);

                    DataGridViewComboBoxCell espacoCell = (DataGridViewComboBoxCell)dataGridView_Incubadora[3, i];
                    for (int k = 0; k < espacoCell.Items.Count; k++)
                    {
                        ConecaoSQLServer.ExecutaSql("INSERT INTO Espacos_incubadora (tipo_espaco, id_incubadora) VALUES (" +
                        "'" + espacoCell.Items[k].ToString() + "', " +
                        "'" + indexIncubadora + "')"
                        );
                    }

                    DataGridViewComboBoxCell servicoCell = (DataGridViewComboBoxCell)dataGridView_Incubadora[3, i];
                    for (int k = 0; k < servicoCell.Items.Count; k++)
                    {
                        ConecaoSQLServer.ExecutaSql("INSERT INTO Servicos_incubadora (tipo_servico, id_incubadora) VALUES (" +
                        "'" + servicoCell.Items[k].ToString() + "', " +
                        "'" + indexIncubadora + "')"
                        );
                    }
                }
            }

            if (dataGridView_Instalacao.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView_Instalacao.Rows.Count; i++)
                {
                    int estacionamento = dataGridView_Instalacao.Rows[i].Cells[5].Value.ToString() == "Checked" ? estacionamento = 1 : estacionamento = 0;
                    int vigilancia = dataGridView_Instalacao.Rows[i].Cells[6].Value.ToString() == "Checked" ? vigilancia = 1 : vigilancia = 0;
                    int seguranca = dataGridView_Instalacao.Rows[i].Cells[7].Value.ToString() == "Checked" ? seguranca = 1 : seguranca = 0;

                    ConecaoSQLServer.ExecutaSql("INSERT INTO Carateristicas_instalacoes (num_lotes, num_lotes_ocupados, estacionamento, videovigilancia, seguranca, tipo_de_rede) VALUES (" +
                        "'" + dataGridView_Instalacao.Rows[i].Cells[3].Value.ToString() + "', " +
                        "'" + dataGridView_Instalacao.Rows[i].Cells[4].Value.ToString() + "', " +
                        "'" + estacionamento + "', " +
                        "'" + vigilancia + "', " +
                        "'" + seguranca + "', " +
                        "'" + dataGridView_Instalacao.Rows[i].Cells[8].Value.ToString() + "')"
                        );

                    dataTable = ConecaoSQLServer.ExecutaSql("SELECT MAX(id_carateristicas) FROM Carateristicas_instalacoes");
                    foundRows = dataTable.Select();
                    int indexCaracteristicas = Convert.ToInt32(foundRows[0][0]);

                    ConecaoSQLServer.ExecutaSql("INSERT INTO Instalacoes (id_carateristicas, id_parque, designaca, localidad, concelh) VALUES (" +
                        "'" + indexCaracteristicas + "', " +
                        "'" + indexParque + "', " +
                        "'" + dataGridView_Instalacao.Rows[i].Cells[0].Value.ToString() + "', " +
                        "'" + dataGridView_Instalacao.Rows[i].Cells[1].Value.ToString() + "', " +
                        "'" + dataGridView_Instalacao.Rows[i].Cells[2].Value.ToString() + "')"
                        );
                }
            }

            areas.Clear();
            dominios.Clear();
        }

        //Sair do form
        private void RegistoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing)
                return;

            if (!safeToQuit)
            {
                if (MessageBox.Show("Tem a certeza que quer abandonar a criação do parque?\n(Todas as informações serão perdidas!)", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void RegistoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
