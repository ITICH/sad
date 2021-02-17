using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ITICH.ConecaoBD;

namespace ITICH
{
    public partial class Inicializador : Form
    {


        public Inicializador()
        {
            InitializeComponent();
            testeDB();
        }

        private void testeDB()
        {
            try
            {
                //Ler valor do endereço no ficheiro XML
                XmlDocument doc = new XmlDocument();
                doc.Load("appinfo.xml");
                XmlNode node = doc.DocumentElement.SelectSingleNode("connection");
                if (node.InnerText.Length > 0)
                {
                    ConecaoSQLServer.stringConecao = @"Data Source = " + node.InnerText + @"; Initial Catalog = ITICH; Integrated Security = True; Integrated Security = True;";
                    DataTable dt = ConecaoSQLServer.ExecutaSql("SELECT * FROM Parques_cientificos");
                    if (dt != null)
                    {
                        //Continuar para login
                        Login login = new Login();
                        login.ShowDialog();
                    }
                }
            }
            catch
            {

            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
