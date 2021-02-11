using ITICH.ConecaoBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ITICH.Simulacoes
{
    public partial class Historico : Form
    {
        //verifica qual é o utilizador que está logado
        int utilizadorLogadoId = Login.dadosLoginID;
        public Historico()
        {
            InitializeComponent();
        }
        private void Historico_Load(object sender, EventArgs e)
        {
            string mostrarResSimulacoes = "SELECT resultado FROM Resultados_simulacao WHERE id_empresa = '"+ utilizadorLogadoId +"'";
            DataTable dt = ConecaoSQLServer.ExecutaSql(mostrarResSimulacoes);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Simulações";
            dataGridView1.Columns[0].Width = 880;

            button_abrir.Visible = false;
            richTextBox1.Visible = false;
            
            if (dataGridView1.SelectedCells.Count == 1)
            {
                //button_abrir.Visible = true;
            }
            else
            {
                //False statement
            }
        }
        private void button_abrir_Click(object sender, EventArgs e)
        {
            string abrir="";
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                abrir = row.Cells[0].Value.ToString().Replace(" ","");
            }
            //@"C:\Users\Asus\Source\Repos\sad\ITICH\ITICH\Xml\"
            XmlDocument xmlDoc = new XmlDocument();
            string strFilename = @"C:\Users\Asus\Source\Repos\sad\ITICH\ITICH\Xml\"+abrir;
            Console.WriteLine(strFilename);

            if (File.Exists(strFilename))
                xmlDoc.Load(strFilename);
            else
                Console.WriteLine("The file {0} could not be located", strFilename);

            /*string fname = "";
            OpenFileDialog dg = new OpenFileDialog();
            dg.Filter = "XML Files | *.xml";
            dg.FileName = abrir;
            dg.ShowDialog();
            fname = dg.FileName;
            if (fname == "") return;
            string readFile = File.ReadAllText(fname);
            richTextBox1.Text = readFile;*/


            /*string onlyContent = string.Empty;
            var visitors = xmlDoc.SelectNodes("Visitors/Visitor");
            for (int i = 0; i < visitors.Count; i++)
            {
                onlyContent += string.Format("\n", i);

                foreach (XmlNode node in visitors[i].ChildNodes)
                    onlyContent += string.Format("{0},", node.InnerText);
            }

            File.WriteAllText(@"C:\Users\Asus\Desktop\XMLparques\Written XML.txt", onlyContent);*/
        }

        private void groupBox_pesqParque_Enter(object sender, EventArgs e){ }
        private void button1_back4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){ }
    }
}
