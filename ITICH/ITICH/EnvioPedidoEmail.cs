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
    public partial class EnviarPedidoEmail : Form
    {
        public EnviarPedidoEmail()
        {
            InitializeComponent();
        }

        private void EnviarPedidoEmail_Load(object sender, EventArgs e)
        {
            string utilizadorLogado = Login.dadosLogin;
            string emailADM = "nunofeiteira@gmail.com";//MUDAR DEPOIS DOS TESTES!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            string emailEmpresa = "nunofeiteira22@gmail.com";//MUDAR DEPOIS DOS TESTES!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //textBox_emailDe.Text = utilizadorLogado;//MUDAR PARA ESTE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            textBox_emailDe.Text = emailEmpresa;
            textBox_emailPara.Text = emailADM;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_emailDe_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_emailPara_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_back2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
