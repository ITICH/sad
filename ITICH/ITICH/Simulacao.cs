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
    public partial class Simulacao : Form
    {
        public Simulacao()
        {
            InitializeComponent();
        }

        //verifica qual é o utilizador que está logado
        int utilizadorLogadoId = Login.dadosLoginID;

        private void Simulacao_Load(object sender, EventArgs e)
        {
            string queryLocalizacao = "SELECT P.parque, L.distrit FROM Parques_cientificos P, Localizacao L WHERE P.id_localizacao = L.id_localizacao AND /*campo texto = L.distrit*/";
            DataTable dadosLocal = ConecaoSQLServer.ExecutaSql(queryLocalizacao);

            string queryFases = "SELECT P.id_parque, F.nome_fase FROM Parques_cientificos P, Fases_desenvolvimento F WHERE P.id_fase_de_desenvolvimento = F.id_fase_desnvolvimento AND /*campo texto = L.nome_fase*/";
            DataTable dadosFases = ConecaoSQLServer.ExecutaSql(queryFases);

            string queryAreas = "SELECT P.id_parque, N.nome_area FROM Parques_cientificos P, Areas_negocios A, Nome_area N WHERE N.id_nome_area = A.id_nome_area AND /*campo texto = N.nome_area eeee id_parque igual ao das outras querys????*/";
            DataTable dadosAreas = ConecaoSQLServer.ExecutaSql(queryAreas);

            string queryVolNegocios = "SELECT I.volume_negocios, P.patrimonio_acossiativo_e_capital_social, P.id_parque, P.nome_parque FROM Incubadoras I, Parques_cientificos P /*WHERE P.id_parque = I.id_parque AND /*campo texto = N.nome_area eeee id_parque igual ao das outras querys????*/*/ Order By P.nome_parque";
            DataTable dadosVol = ConecaoSQLServer.ExecutaSql(queryVolNegocios);

            string queryInstalacoes = "SELECT P.id_parque, I.id_carateristica, C.estacionamento, C.videovigilancia, C.seguranca FROM Instalacoes I, Parques_cientificos P, Carateristicas_instalacoes C /*WHERE I.id_carateristica = C.id_carateristica AND /*campo texto = 3 campos estac,video,seg eeee id_parque igual ao das outras querys????*/*/ Order By P.nome_parque";
            DataTable dadosInstalacoes = ConecaoSQLServer.ExecutaSql(queryInstalacoes);

            //string queryEspacoDisponivel = "SELECT P.id_parque, I.id_carateristica, C.num_lotes, C.num_lotes_ocupados FROM Instalacoes I, Parques_cientificos P, Carateristicas_instalacoes C /*WHERE I.id_carateristica = C.id_carateristica AND /*campo texto = disponilidade eeee id_parque igual ao das outras querys????*/*/ Order By P.nome_parque";
            //DataTable dadosEspacoDisponivel = ConecaoSQLServer.ExecutaSql(queryEspacoDisponivel);


        }

        private void label1Simulacao_Click(object sender, EventArgs e)
        {

        }

        private void button1_back4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
