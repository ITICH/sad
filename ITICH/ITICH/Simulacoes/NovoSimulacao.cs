using ITICH.ConecaoBD;
using ITICH.RegistoParques;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITICH.Simulacoes
{
    public partial class NovoSimulacao : Form
    {
        public static List<string> areas = new List<string>();
        public static SortedList<int, double> resSimulacao = new SortedList<int, double>();
        //lista onde vai guardar todos os resultados
        public static List<Resultados> result = new List<Resultados>();
        public static int estacionamentoInst;
        public static int vigilanciaInst;
        public static int segurancaInst;
        public static int temIncubadora;

        public static int local;
        public static int area;
        public static int fDesenvolvimento;
        public static int volNegocios;
        public static int cartInstalacao;
        public static int serIncubadora;
        public static int tipoInstalacao;

        private DataTable dataTable;
        private DataRow[] foundRows;
        string[] distritos = { "", "Aveiro", "Beja", "Braga", "Bragança", "Castelo Branco", "Coimbra", "Évora", "Faro", "Guarda", "Leiria", "Lisboa", "Portalegre", "Porto", "Santarém", "Setúbal", "Viana do Castelo", "Vila Real", "Viseu", "Ilha da Madeira", "Ilha de Porto Santo", "Ilha de Santa Maria", "Ilha de São Miguel", "Ilha Terceira", "Ilha da Graciosa", "Ilha de São Jorge", "Ilha do Pico", "Ilha do Faial", "Ilha das Flores", "Ilha do Corvo" };
        int[] volNeg = { 10000, 100000, 300000, 500000, 700000, 900000, 1000000, 30000000, 50000000, 100000000 };
        string[] tipoInst = { "", "Salas", "Incubação", "Cowork", "Lotes" };
        //dicionario onde são guardados os niveis de importância
        Dictionary<int, string> niveisImp = new Dictionary<int, string>();
        
        //verifica qual é o utilizador que está logado
        int utilizadorLogadoId = Login.dadosLoginID;
        //numero de parques a usar na simulação
        private static int numParques;
        
        //numero de critérios a usar na simulação
        private static int numCriterios = 7;
        double[] valCriterios;

        public NovoSimulacao()
        {
            InitializeComponent();
            //dados na comboBox fases
            dataTable = ConecaoSQLServer.ExecutaSql("SELECT * FROM Fases_desenvolvimento");
            foundRows = dataTable.Select();
            for (int i = 0; i < foundRows.Length; i++)
            {
                comboBox2_fase.Items.Add(foundRows[i][1].ToString());
            }
            //dados na comboBox distritos
            comboBox1.DataSource = distritos;
            //dados na comboBox fases
            comboBox2.DataSource = volNeg;
            //dados na comboBox fases
            comboBox5.DataSource = tipoInst;
            Refresh();
        }
        private void dadosDataGrid(SortedList<int,double> resultados, int[] id_parques, string[] nome_parque, string[] email)
        {
            dataGridView_teste.Columns.Add("Name", "Parque");
            dataGridView_teste.Columns.Add("Email", "Email");
            dataGridView_teste.Columns.Add("Value", "Percentagem");

            int id = 1;
            for (int i = 0; i < resultados.Count; i++)
            {
                result.Add(new Resultados { id_parques = id_parques[i], nome_parque=nome_parque[i], email=email[i], resl=Math.Round((double)resultados[id] * 100, 2)});
                id++;
            }
            List<Resultados> SortedList = result.OrderByDescending(o => o.resl).ToList();//Ordena os dados pela ordem decrescente da percentagem
            //Coloca os resusltados todos na tabela. Apresenta um top 3 dos melhores parques
            for (int i = 0; i < 3/*resultados.Count*/; i++)
            {
                dataGridView_teste.Rows.Add(/*result[i].id_parques, */SortedList[i].nome_parque, SortedList[i].email, SortedList[i].resl+"%");
            }
            //Ordena os dados pela ordem decrescente da percentagem
            //this.dataGridView_teste.Sort(dataGridView_teste.Columns["Value"], ListSortDirection.Descending);
            //Apresenta um top 3 dos melhores parques, removo todos os resultados depois do terceiro valor
            /*for (int i = 0; i < dataGridView_teste.Rows.Count; i++)
            {
                DataGridViewRow apagarRow = dataGridView_teste.Rows[i];
                dataGridView_teste.Rows.Remove(apagarRow);
            }*/
            dataGridView_teste.Columns[0].Width = 120;
            dataGridView_teste.Columns[1].Width = 115;
            dataGridView_teste.Columns[2].Width = 115;
            dataGridView_teste.Rows[0].Height = 40;
            dataGridView_teste.Rows[1].Height = 40;
            dataGridView_teste.Rows[2].Height = 40;
        }

        public override void Refresh()
        {
            this.Enabled = false;
            comboBox3.Text = "Selecione Área...";
            comboBox3.Items.Clear();
            dataTable = ConecaoSQLServer.ExecutaSql("SELECT * FROM Nome_area");
            foundRows = dataTable.Select();
            for (int i = 0; i < foundRows.Length; i++)
            {
                comboBox3.Items.Add(foundRows[i][1].ToString());
            }
            foreach (string item in areas)
            {
                comboBox3.Items.Remove(item);
            }
            base.Refresh();
            this.Enabled = true;
        }

        private void Simulacao1_Load(object sender, EventArgs e)
        {
            button_guardar.Visible = false;
            label39.Visible = false;
            button3.Visible = false;

            niveisImp.Add(3, "Pouco Importânte");//adiciona os niveis de importância ao dicionario
            niveisImp.Add(1, "Mesma Importância");
            niveisImp.Add(5, "Grande Importância");
            niveisImp.Add(7, "Importância Muito Grande");
            niveisImp.Add(9, "Extremanente Importânte");

            //preenche as selectBoxs com os dados os Niveis de Importacia em relação a cada critério
            comboBox_Fd.DataSource = new BindingSource(niveisImp,null);
            comboBox_Fd.ValueMember = "Key";
            comboBox_Fd.DisplayMember = "Value";
            
            comboBox_TInt.DataSource = new BindingSource(niveisImp, null);
            comboBox_TInt.ValueMember = "Key";
            comboBox_TInt.DisplayMember = "Value";

            comboBox_Vn.DataSource = new BindingSource(niveisImp, null);
            comboBox_Vn.ValueMember = "Key";
            comboBox_Vn.DisplayMember = "Value";

            comboBox_CInst.DataSource = new BindingSource(niveisImp, null);
            comboBox_CInst.ValueMember = "Key";
            comboBox_CInst.DisplayMember = "Value";

            comboBox_Inc.DataSource = new BindingSource(niveisImp, null);
            comboBox_Inc.ValueMember = "Key";
            comboBox_Inc.DisplayMember = "Value";

            comboBox_area.DataSource = new BindingSource(niveisImp, null);
            comboBox_area.ValueMember = "Key";
            comboBox_area.DisplayMember = "Value";

            comboBox2_a.DataSource = new BindingSource(niveisImp, null);
            comboBox2_a.ValueMember = "Key";
            comboBox2_a.DisplayMember = "Value";

            comboBox2_ci.DataSource = new BindingSource(niveisImp, null);
            comboBox2_ci.ValueMember = "Key";
            comboBox2_ci.DisplayMember = "Value";

            comboBox2_i.DataSource = new BindingSource(niveisImp, null);
            comboBox2_i.ValueMember = "Key";
            comboBox2_i.DisplayMember = "Value";

            comboBox2_ti.DataSource = new BindingSource(niveisImp, null);
            comboBox2_ti.ValueMember = "Key";
            comboBox2_ti.DisplayMember = "Value";

            comboBox2_vn.DataSource = new BindingSource(niveisImp, null);
            comboBox2_vn.ValueMember = "Key";
            comboBox2_vn.DisplayMember = "Value";

            comboBox3_ci.DataSource = new BindingSource(niveisImp, null);
            comboBox3_ci.ValueMember = "Key";
            comboBox3_ci.DisplayMember = "Value";

            comboBox3_i.DataSource = new BindingSource(niveisImp, null);
            comboBox3_i.ValueMember = "Key";
            comboBox3_i.DisplayMember = "Value";

            comboBox3_ti.DataSource = new BindingSource(niveisImp, null);
            comboBox3_ti.ValueMember = "Key";
            comboBox3_ti.DisplayMember = "Value";

            comboBox3_vn.DataSource = new BindingSource(niveisImp, null);
            comboBox3_vn.ValueMember = "Key";
            comboBox3_vn.DisplayMember = "Value";

            comboBox4_ci.DataSource = new BindingSource(niveisImp, null);
            comboBox4_ci.ValueMember = "Key";
            comboBox4_ci.DisplayMember = "Value";

            comboBox4_i.DataSource = new BindingSource(niveisImp, null);
            comboBox4_i.ValueMember = "Key";
            comboBox4_i.DisplayMember = "Value";

            comboBox4_ti.DataSource = new BindingSource(niveisImp, null);
            comboBox4_ti.ValueMember = "Key";
            comboBox4_ti.DisplayMember = "Value";

            comboBox5_i.DataSource = new BindingSource(niveisImp, null);
            comboBox5_i.ValueMember = "Key";
            comboBox5_i.DisplayMember = "Value";

            comboBox5_ti.DataSource = new BindingSource(niveisImp, null);
            comboBox5_ti.ValueMember = "Key";
            comboBox5_ti.DisplayMember = "Value";

            comboBox6_ti.DataSource = new BindingSource(niveisImp, null);
            comboBox6_ti.ValueMember = "Key";
            comboBox6_ti.DisplayMember = "Value";
        }
        private void button1_back4_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem != null)
            {
                areas.Add(comboBox3.SelectedItem.ToString());
                int areaRowIndex = dataGridView2.Rows.Add();
                dataGridView2.Rows[areaRowIndex].Cells[0].Value = comboBox3.SelectedItem.ToString();
                button2.Enabled = true;
                Refresh();
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount > 0)
            {
                areas.Remove(dataGridView2.SelectedCells[0].Value.ToString());
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentCell.RowIndex);
                Refresh();
            }
            if (dataGridView2.RowCount == 0)
            {
                button2.Enabled = false;
            }
        }

        private void button_ConfirmarDados_Click(object sender, EventArgs e)
        {
            //Matriz com a importancia dos critérios
            valCriterios = new double[] { 1, ((KeyValuePair<int, string>)comboBox_Fd.SelectedItem).Key, ((KeyValuePair<int, string>)comboBox_area.SelectedItem).Key, ((KeyValuePair<int, string>)comboBox_Vn.SelectedItem).Key, ((KeyValuePair<int, string>)comboBox_CInst.SelectedItem).Key,
                ((KeyValuePair<int, string>)comboBox_Inc.SelectedItem).Key, ((KeyValuePair<int, string>)comboBox_TInt.SelectedItem).Key, 1 / ((KeyValuePair<int, string>)comboBox_Fd.SelectedItem).Key, 1, ((KeyValuePair<int, string>)comboBox2_a.SelectedItem).Key, ((KeyValuePair<int, string>)comboBox2_vn.SelectedItem).Key,
                ((KeyValuePair<int, string>)comboBox2_ci.SelectedItem).Key, ((KeyValuePair<int, string>)comboBox2_i.SelectedItem).Key, ((KeyValuePair<int, string>)comboBox2_ti.SelectedItem).Key, 1 / ((KeyValuePair<int, string>)comboBox_area.SelectedItem).Key, 1 / ((KeyValuePair<int, string>)comboBox2_a.SelectedItem).Key, 
                1, ((KeyValuePair<int, string>)comboBox3_vn.SelectedItem).Key, ((KeyValuePair<int, string>)comboBox3_ci.SelectedItem).Key, ((KeyValuePair<int, string>)comboBox3_i.SelectedItem).Key, ((KeyValuePair<int, string>)comboBox3_ti.SelectedItem).Key, 1 / ((KeyValuePair<int, string>)comboBox_Vn.SelectedItem).Key, 
                1 / ((KeyValuePair<int, string>)comboBox2_vn.SelectedItem).Key, 1 / ((KeyValuePair<int, string>)comboBox3_vn.SelectedItem).Key, 1, ((KeyValuePair<int, string>)comboBox4_ci.SelectedItem).Key, ((KeyValuePair<int, string>)comboBox4_i.SelectedItem).Key, ((KeyValuePair<int, string>)comboBox4_ti.SelectedItem).Key, 
                1 / ((KeyValuePair<int, string>)comboBox_CInst.SelectedItem).Key, 1 / ((KeyValuePair<int, string>)comboBox2_ci.SelectedItem).Key, 1 / ((KeyValuePair<int, string>)comboBox3_ci.SelectedItem).Key, 1 / ((KeyValuePair<int, string>)comboBox4_ci.SelectedItem).Key, 1,
                ((KeyValuePair<int, string>)comboBox5_i.SelectedItem).Key, ((KeyValuePair<int, string>)comboBox5_ti.SelectedItem).Key, 1 / ((KeyValuePair<int, string>)comboBox_Inc.SelectedItem).Key, 1 / ((KeyValuePair<int, string>)comboBox2_i.SelectedItem).Key, 1 / ((KeyValuePair<int, string>)comboBox3_i.SelectedItem).Key, 
                1 / ((KeyValuePair<int, string>)comboBox4_i.SelectedItem).Key, 1 / ((KeyValuePair<int, string>)comboBox5_i.SelectedItem).Key, 1, ((KeyValuePair<int, string>)comboBox6_ti.SelectedItem).Key, 1 / ((KeyValuePair<int, string>)comboBox_TInt.SelectedItem).Key, 
                1 / ((KeyValuePair<int, string>)comboBox2_ti.SelectedItem).Key, 1 / ((KeyValuePair<int, string>)comboBox3_ti.SelectedItem).Key, 1 / ((KeyValuePair<int, string>)comboBox4_ti.SelectedItem).Key, 1 / ((KeyValuePair<int, string>)comboBox5_ti.SelectedItem).Key, 
                1 / ((KeyValuePair<int, string>)comboBox6_ti.SelectedItem).Key, 1};

            double[,] matrizCriterios = new double[numCriterios, numCriterios];

            int conta = 0;
            for (int i = 0; i < numCriterios; i++)//Preeche a matriz de Criterios
            {
                for (int j = 0; j < numCriterios; j++)
                {
                    matrizCriterios[i, j] = valCriterios[conta];
                    conta+=1;
                }
            }

            double[] resCaclCriterios = new double[numCriterios];
            resCaclCriterios = CalcSimulacao.CalcCriteriosAhp(matrizCriterios,numCriterios);

            string parques = "SELECT COUNT(id_parque) as numParques FROM Parques_cientificos";//busca o numero de parques / opções
            DataTable dtParques = ConecaoSQLServer.ExecutaSql(parques);
            numParques = Int32.Parse(dtParques.Rows[0][0].ToString());

            //colocar comentario-------------VERIFICAR PQ É QUE SE NÃO TIVER TUDO PREENCHIDO CONTINUA COM O CALC E FICA INVERTIDA A MATRIZ E COM O VAL 8
            if (string.IsNullOrEmpty(label_ImpLocal.Text) || string.IsNullOrEmpty(label_impArea.Text) || 
                string.IsNullOrEmpty(label_impFdesenv.Text) || string.IsNullOrEmpty(label_impVol.Text) || 
                string.IsNullOrEmpty(label_impInst.Text) || string.IsNullOrEmpty(label_impSerInc.Text) || 
                string.IsNullOrEmpty(label_impTpInst.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                local = Int32.Parse(label_ImpLocal.Text);
                area = Int32.Parse(label_impArea.Text);
                fDesenvolvimento = Int32.Parse(label_impFdesenv.Text);
                volNegocios = Int32.Parse(label_impVol.Text);
                cartInstalacao = Int32.Parse(label_impInst.Text);
                serIncubadora = Int32.Parse(label_impSerInc.Text);
                tipoInstalacao = Int32.Parse(label_impTpInst.Text);
            }

            //busca o id de TODOS os parques / opções
            string parquesTodos = "SELECT id_parque, nome_parque, e_mail FROM Parques_cientificos";
            DataTable dtParquesTodos = ConecaoSQLServer.ExecutaSql(parquesTodos);
            int[] tdParques = new int[dtParquesTodos.Rows.Count];
            string[] nomeParques = new string[dtParquesTodos.Rows.Count];
            string[] emailParques = new string[dtParquesTodos.Rows.Count];
            for (int i=0;i< dtParquesTodos.Rows.Count;i++)
            {
                tdParques[i] = Int32.Parse(dtParquesTodos.Rows[i][0].ToString());//id de todos os parques
                nomeParques[i] = dtParquesTodos.Rows[i][1].ToString();//todos os nomes dos parques
                emailParques[i] = dtParquesTodos.Rows[i][2].ToString();//email dos parques
            }

    //########################################################################################################################################################################
            //busca os parques com o mesmo local na comboBox
            string queryLocalizacao = "SELECT P.id_parque, L.distrit FROM Parques_cientificos P, Localizacao L WHERE P.id_localizacao = L.id_localizacao AND L.distrit = '" + comboBox1.Text + "'";
            DataTable dtLocal = ConecaoSQLServer.ExecutaSql(queryLocalizacao);
            int[] locaisMaisImp = new int[dtLocal.Rows.Count];
            for (int i = 0; i < dtLocal.Rows.Count; i++)
            {
                locaisMaisImp[i] = Int32.Parse(dtLocal.Rows[i][0].ToString());
            }

            //preenche a matriz LOCALIDADE e calcula a matriz com o metodo ahp e retorna um vetor com os RESULTADOS
            double[] resCaclMatrizLocal = new double[tdParques.Length];
            resCaclMatrizLocal = CalcSimulacao.PreencheMatriz(tdParques, locaisMaisImp, local);
            //Console.Write("[{0}]", string.Join(";", resCaclMatrizLocal));

    //########################################################################################################################################################################
            //busca os parques com a mesma fase na comboBox
            string queryFases = "SELECT P.id_parque, F.nome_fase FROM Parques_cientificos P, Fases_desenvolvimento F WHERE P.id_fase_de_desenvolvimento = F.id_fase_desenvolvimento AND F.nome_fase = '" + comboBox2_fase.SelectedText + "'";
            DataTable dtFases = ConecaoSQLServer.ExecutaSql(queryFases);
            int[] fasesMaisImp = new int[dtFases.Rows.Count];
            for (int i = 0; i < dtFases.Rows.Count; i++)
            {
                fasesMaisImp[i] = Int32.Parse(dtFases.Rows[i][0].ToString());
            }

            //preenche a matriz FASES e calcula a matriz com o metodo ahp e retorna um vetor com os RESULTADOS
            double[] resCaclMatrizFase = new double[tdParques.Length];
            resCaclMatrizFase = CalcSimulacao.PreencheMatriz(tdParques, fasesMaisImp, fDesenvolvimento);

    //########################################################################################################################################################################
            //busca os parques com a mesma Area na comboBox 
            int[] areasMaisImp = new int[areas.Count];
            if (areas.Count > 0)
            {
                for(int i = 0; i < areas.Count; i++)
                {
                    string queryAreas = "SELECT P.id_parque FROM Parques_cientificos P, Areas_negocios A, Nome_area N WHERE N.id_nome_area = A.id_nome_area AND N.nome_area ='" + areas[i] + "'";
                    dataTable = ConecaoSQLServer.ExecutaSql(queryAreas);
                    foundRows = dataTable.Select();
                    areasMaisImp[i] = Int32.Parse(foundRows[0][0].ToString());
                }
            }
            double[] resCaclMatrizAreas = new double[tdParques.Length];
            resCaclMatrizAreas = CalcSimulacao.PreencheMatriz(tdParques, areasMaisImp, area);

    //########################################################################################################################################################################            
            //busca os parques com o mesmo ou maior volumeNegocios na comboBox
            string queryVolNegocios = "SELECT P.id_parque, P.nome_parque FROM Parques_cientificos P WHERE P.patrimonio_acossiativo_e_capital_social >= '" + comboBox2.SelectedText + "'";
            DataTable dtVol = ConecaoSQLServer.ExecutaSql(queryVolNegocios);
            int[] volNegMaisImp = new int[dtVol.Rows.Count];
            for (int i = 0; i < dtVol.Rows.Count; i++)
            {
                volNegMaisImp[i] = Int32.Parse(dtVol.Rows[i][0].ToString());
            }

            //preenche a matriz VOL. NEGOCIOS e calcula a matriz com o metodo ahp e retorna um vetor com os RESULTADOS
            double[] resCaclMatrizVolNeg = new double[tdParques.Length];
            resCaclMatrizVolNeg = CalcSimulacao.PreencheMatriz(tdParques, volNegMaisImp, volNegocios);

    //########################################################################################################################################################################
            //busca os parques com as mesmas carateristica da instalação selceionadas
            _ = checkBox_EstacionamentoInstalacao.Checked ? estacionamentoInst = 1 : estacionamentoInst = 0;
            _ = checkBox_SegurancaInstalacao.Checked ? segurancaInst = 1 : segurancaInst = 0;
            _ = checkBox_VigilanciaInstalacao.Checked ? vigilanciaInst = 1 : vigilanciaInst = 0;

            double[] resCaclMatrizCartInst = new double[tdParques.Length];
            if (segurancaInst == 1 && estacionamentoInst == 1 && vigilanciaInst == 1)
            {
                string queryInstalacoes = "SELECT P.id_parque FROM Instalacoes I, Parques_cientificos P, Carateristicas_instalacoes C WHERE I.id_carateristicas = C.id_carateristicas AND C.estacionamento = 1 AND C.videovigilancia = 1 AND C.seguranca = 1 AND C.tipo_de_rede = '" + textBox_RedeInstalacao.Text + "'";
                DataTable dtInstalacoes = ConecaoSQLServer.ExecutaSql(queryInstalacoes);
                int[] cartInstMaisImp = new int[dtInstalacoes.Rows.Count];
                for (int i = 0; i < dtInstalacoes.Rows.Count; i++)
                {
                    cartInstMaisImp[i] = Int32.Parse(dtInstalacoes.Rows[i][0].ToString());
                }

                //preenche a matriz Caract. Instalações e calcula a matriz com o metodo ahp e retorna um vetor com os RESULTADOS
                resCaclMatrizCartInst = CalcSimulacao.PreencheMatriz(tdParques, cartInstMaisImp, cartInstalacao);
            }
            else if (segurancaInst == 1 || estacionamentoInst == 1 || vigilanciaInst == 1)
            {
                string queryInstalacoes = "SELECT P.id_parque FROM Instalacoes I, Parques_cientificos P, Carateristicas_instalacoes C WHERE I.id_carateristicas = C.id_carateristicas AND C.estacionamento = 1 OR C.videovigilancia = 1 OR C.seguranca = 1 AND C.tipo_de_rede = '" + textBox_RedeInstalacao.Text + "'";
                DataTable dtInstalacoes = ConecaoSQLServer.ExecutaSql(queryInstalacoes);
                int[] cartInstMaisImp = new int[dtInstalacoes.Rows.Count];
                for (int i = 0; i < dtInstalacoes.Rows.Count; i++)
                {
                    cartInstMaisImp[i] = Int32.Parse(dtInstalacoes.Rows[i][0].ToString());
                }

                //preenche a matriz Caract. Instalações e calcula a matriz com o metodo ahp e retorna um vetor com os RESULTADOS
                resCaclMatrizCartInst = CalcSimulacao.PreencheMatriz(tdParques, cartInstMaisImp, cartInstalacao);
            }

    //########################################################################################################################################################################
            //busca os parques com o incubadoras
            double[] resCaclMatrizInc = new double[tdParques.Length]; ;
            if (checkBox1.Checked)
            {
                temIncubadora = 0;
                string querySerIncubadora = "SELECT P.id_parque, P.nome_parque FROM Parques_cientificos P WHERE P.temIncubadora = 0";
                DataTable dtSerIncubadora = ConecaoSQLServer.ExecutaSql(querySerIncubadora);
                int[] incMaisImp = new int[dtSerIncubadora.Rows.Count];
                for (int i = 0; i < dtSerIncubadora.Rows.Count; i++)
                {
                    incMaisImp[i] = Int32.Parse(dtSerIncubadora.Rows[i][0].ToString());
                }

                //preenche a matriz INCUBADORA e calcula a matriz com o metodo ahp e retorna um vetor com os RESULTADOS
                resCaclMatrizInc = CalcSimulacao.PreencheMatriz(tdParques, incMaisImp, serIncubadora);
            }
            else if (checkBox2.Checked)
            {
                temIncubadora = 1;
                string querySerIncubadora = "SELECT P.id_parque, P.nome_parque FROM Parques_cientificos P WHERE P.temIncubadora = 1";
                DataTable dtSerIncubadora = ConecaoSQLServer.ExecutaSql(querySerIncubadora);
                int[] incMaisImp = new int[dtSerIncubadora.Rows.Count];
                for (int i = 0; i < dtSerIncubadora.Rows.Count; i++)
                {
                    incMaisImp[i] = Int32.Parse(dtSerIncubadora.Rows[i][0].ToString());
                }

                //preenche a matriz INCUBADORA e calcula a matriz com o metodo ahp e retorna um vetor com os RESULTADOS
                resCaclMatrizInc = CalcSimulacao.PreencheMatriz(tdParques, incMaisImp, serIncubadora);
            }

    //#######################################################################################################################################################################
            //busca os parques com o mesmo tipo de instalação na comboBox  //ALTERAR PARAO TIPO DE ESPAÇO DA INCUBADORA????????????
            string queryTipoInst = "SELECT P.id_parque FROM Instalacoes I, Parques_cientificos P WHERE I.id_parque = P.id_parque AND I.designaca = '" + comboBox5.SelectedText + "'";
            DataTable dtTipoInst = ConecaoSQLServer.ExecutaSql(queryTipoInst);
            int[] tipoInstMaisImp = new int[dtTipoInst.Rows.Count];
            for (int i = 0; i < dtTipoInst.Rows.Count; i++)
            {
                tipoInstMaisImp[i] = Int32.Parse(dtTipoInst.Rows[i][0].ToString());
            }

            //preenche a matriz TIPO INSTALAÇÃO e calcula a matriz com o metodo ahp e retorna um vetor com os RESULTADOS
            double[] resCaclMatrizTipoInst = new double[tdParques.Length];
            resCaclMatrizTipoInst = CalcSimulacao.PreencheMatriz(tdParques, tipoInstMaisImp, tipoInstalacao);

    //#######################################################################################################################################################################
            //RESULTADO da SIMULAÇÃO
            resSimulacao = CalcSimulacao.CalcSimulacaoAhp(resCaclCriterios, resCaclMatrizLocal, resCaclMatrizFase, resCaclMatrizAreas, resCaclMatrizVolNeg, resCaclMatrizCartInst, resCaclMatrizInc, resCaclMatrizTipoInst, tdParques.Length);
            dadosDataGrid(resSimulacao, tdParques, nomeParques, emailParques);//mostra resultado no datagrid

            button_guardar.Visible = true;
            label39.Visible = true;
            //button3.Visible = true;
            //button_ConfirmarDados.Enabled = false;
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            string email=null;
            foreach (DataGridViewRow row in dataGridView_teste.SelectedRows)
            {
                email = row.Cells[1].Value.ToString();
            }
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Selecione um parque!", "",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string caminho = CriarXml.CriarXML(email);
            MessageBox.Show("Dados exportados e guardados com sucesso, em \n"+caminho, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            /*this.Controls.Clear();
            this.InitializeComponent();
            button_ConfirmarDados.Enabled = true;*/
            /*NovoSimulacao fr = new NovoSimulacao();
            this.Hide();
            fr.Show();*/
            
            //return;
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label_ImpLocal.Text = trackBar1.Value.ToString();
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label_impFdesenv.Text = trackBar2.Value.ToString();
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label_impArea.Text = trackBar3.Value.ToString();
        }
        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            label_impVol.Text = trackBar4.Value.ToString();
        }
        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            label_impInst.Text = trackBar5.Value.ToString();
        }
        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            label_impSerInc.Text = trackBar6.Value.ToString();
        }
        private void trackBar7_Scroll(object sender, EventArgs e)
        {
            label_impTpInst.Text = trackBar7.Value.ToString();
        }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox_TInt_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void comboBox_Inc_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void comboBox_Vn_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void comboBox_CInst_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void comboBox_area_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void comboBox_Fd_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label_ImpLocal_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void groupBox_local_Enter(object sender, EventArgs e) { }
        private void tabPage2_Click(object sender, EventArgs e){ }
        private void tabPage3_Click(object sender, EventArgs e) { }
        private void tabPage4_Click(object sender, EventArgs e) { }
        private void tabPage5_Click(object sender, EventArgs e) { }
        private void tabPage6_Click(object sender, EventArgs e) { }
        private void tabPage7_Click(object sender, EventArgs e) { }
        private void label1Simulacao_Click(object sender, EventArgs e) { }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox2_ti_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void comboBox2_i_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void comboBox2_vn_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label11_Click(object sender, EventArgs e) { }
        private void comboBox2_ci_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label12_Click(object sender, EventArgs e) { }
        private void comboBox2_a_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label13_Click(object sender, EventArgs e) { }
        private void label15_Click(object sender, EventArgs e) { }
        private void label16_Click(object sender, EventArgs e) { }
        private void comboBox2_fase_SelectedIndexChanged(object sender, EventArgs e) { }
        private void groupBox_fase_Enter(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void comboBox3_ti_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label14_Click(object sender, EventArgs e) { }
        private void comboBox3_i_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label17_Click(object sender, EventArgs e) { }
        private void comboBox3_vn_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label18_Click(object sender, EventArgs e) { }
        private void comboBox3_ci_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label19_Click(object sender, EventArgs e) { }
        private void groupBox3_Enter(object sender, EventArgs e) { }
        private void groupBox_area_Enter(object sender, EventArgs e) { }
        private void label20_Click(object sender, EventArgs e) { }
        private void label21_Click(object sender, EventArgs e) { }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label22_Click(object sender, EventArgs e) { }
        private void label_impVol_Click(object sender, EventArgs e) { }
        private void label23_Click(object sender, EventArgs e) { }
        private void groupBox5_Enter(object sender, EventArgs e) { }
        private void comboBox6_ti_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label34_Click(object sender, EventArgs e) { }
        private void label33_Click(object sender, EventArgs e) { }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }
        private void checkBox2_CheckedChanged(object sender, EventArgs e) { }
        private void label29_Click(object sender, EventArgs e) { }
        private void label_impSerInc_Click(object sender, EventArgs e) { }
        private void groupBox8_Enter(object sender, EventArgs e) { }
        private void label_impTpInst_Click(object sender, EventArgs e) { }
        private void label35_Click(object sender, EventArgs e) { }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label36_Click(object sender, EventArgs e) { }
        private void groupBox10_Enter(object sender, EventArgs e) { }
        private void groupBox4_Enter(object sender, EventArgs e) { }
        private void button_exportar_Click(object sender, EventArgs e) { }
        private void dataGridView_teste_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void groupBox6_Enter(object sender, EventArgs e) { }
        private void groupBox7_Enter(object sender, EventArgs e) { }
        private void label40_Click(object sender, EventArgs e) { }
    }
}
