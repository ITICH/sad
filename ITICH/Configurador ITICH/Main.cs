using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Configurador_ITICH
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                //Mudar valor do endereço no ficheiro XML

                Application.Exit();
            }
            catch
            {
                MessageBox.Show("Ocurreu um Erro.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
