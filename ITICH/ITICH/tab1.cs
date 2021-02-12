using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITICH.ConecaoBD;

namespace ITICH
{
    public partial class tab1 : UserControl
    {
        public tab1()
        {
            InitializeComponent();
        }

        private void dadosGraficos(string sql, int i)
        {
            DataTable dt = ConecaoSQLServer.ExecutaSql(sql);

            if (i == 1)
            {
                chart1.DataSource = dt;
                chart1.Series["Volume"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
                chart1.Series["Volume"].XValueMember = "nome_parque";
                chart1.Series["Volume"].YValueMembers = "patrimonio_acossiativo_e_capital_social";
                chart1.Series["Volume"].IsValueShownAsLabel = true;
                chart1.DataBind();
            }
            else if (i == 2)
            {
               // chart_fDesenvolvimento.Series["Area"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
                chart_fDesenvolvimento.Series["Areas"].XValueMember = "nome_area";
                chart_fDesenvolvimento.Series["Areas"].YValueMembers = "total";
                //chart1.Series["Volume"].IsValueShownAsLabel = true;
                chart_fDesenvolvimento.DataSource = dt;
                chart_fDesenvolvimento.DataBind();
            }
            else
            {
                // chart_fDesenvolvimento.Series["Area"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
                chart_fases.Series["Fases"].XValueMember = "nome_fase";
                chart_fases.Series["Fases"].YValueMembers = "fases";
                //chart1.Series["Volume"].IsValueShownAsLabel = true;
                chart_fases.DataSource = dt;
                chart_fases.DataBind();
            }

            /*string[] x = new string[dt.Rows.Count];
            int[] y = new int[dt.Rows.Count];

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                x[i] = dt.Rows[i][0].ToString();
                y[i] = Convert.ToInt32(dt.Rows[i][1]);
            }
            chart1.Series[0].Points.DataBindXY(x, y);*/
            

            /*int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                //string res = dr["nome_parque"].ToString();
                //string res2 = dr["patrimonio_acossiativo_e_capital_social"].ToString();

                this.chart1.DataSource = dt.Rows[i];
                this.chart1.Series["Volume"].XValueMember = "nome_parque";
                this.chart1.Series["Volume"].YValueMembers = "patrimonio_acossiativo_e_capital_social";
                //this.chart1.Series["Volume"].IsValueShownAsLabel = true;
                this.chart1.DataBind();
                i+=1;
            }*/
        }
        private void tab1_Load(object sender, EventArgs e)
        {
            //grafico Volume de Negócios
            string volNegocios = "SELECT P.patrimonio_acossiativo_e_capital_social, P.nome_parque FROM Parques_cientificos P Order By P.nome_parque";
            string areas = "SELECT N.nome_area, COUNT(A.id_nome_area) AS total FROM Areas_negocios A, Nome_area N WHERE N.id_nome_area = A.id_nome_area GROUP BY N.nome_area";
            string fases = "SELECT F.nome_fase, COUNT(P.id_fase_de_desenvolvimento) AS fases FROM Parques_cientificos P, Fases_desenvolvimento F WHERE F.id_fase_desenvolvimento = P.id_fase_de_desenvolvimento GROUP BY F.nome_fase";
            //DataTable dt = ConecaoSQLServer.ExecutaSql(volNegocios);
            int i = 0;
            dadosGraficos(volNegocios, i+1);
            dadosGraficos(areas, i+2);
            dadosGraficos(fases, i);

            //this.chart1.DataSource = dt;
            //this.chart1.Series["Volume"].XValueMember = "nome_parque";
            //this.chart1.Series["Volume"].YValueMembers = "patrimonio_acossiativo_e_capital_social";

            //grafico Areas de Desenvolvimento
            /*string area = "SELECT count(N.nome_area) AS total, N.nome_area FROM Nome_area N, Areas_negocios A, Parques_cientificos P WHERE P.id_parque = A.id_parque";
            DataTable dt2 = ConecaoSQLServer.ExecutaSql(area);

            this.chart_fDesenvolvimento.DataSource = dt;
            this.chart_fDesenvolvimento.Series["Volume"].XValueMember = "nome_area";
            this.chart_fDesenvolvimento.Series["Volume"].YValueMembers = "total";*/
        }

        private void panel4_Paint(object sender, PaintEventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void panel5_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e){}
        private void label2_Click(object sender, EventArgs e){}
        private void pictureBox2_Click(object sender, EventArgs e){}
        private void panel8_Paint(object sender, PaintEventArgs e){}
        private void panel7_Paint(object sender, PaintEventArgs e){}
        private void panel6_Paint(object sender, PaintEventArgs e){}
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e){}
        private void panel11_Paint(object sender, PaintEventArgs e){}
        private void pictureBox3_Click(object sender, EventArgs e){}
        private void panel10_Paint(object sender, PaintEventArgs e){}
        private void panel9_Paint(object sender, PaintEventArgs e){}
        private void label3_Click(object sender, EventArgs e){}
        private void label2_Click_1(object sender, EventArgs e){}
        private void chart1_Click(object sender, EventArgs e){}
        private void chart_fDesenvolvimento_Click(object sender, EventArgs e){}
        private void chart2_Click(object sender, EventArgs e){}
        private void panel8_Paint_1(object sender, PaintEventArgs e){}
        private void label4_Click(object sender, EventArgs e){}
        private void chart_fases_Click(object sender, EventArgs e) {}
    }
}
