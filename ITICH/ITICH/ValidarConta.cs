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
    public partial class ValidarConta : Form
    {
        DataTable dadosContas;
        String querySQL;
        int id;

        public ValidarConta()
        {
            InitializeComponent();
        }

        private void ValidarConta_Load(object sender, EventArgs e)
        {
            //Preenche a lista com o nome das empresas que estão por validar
            querySQL = "SELECT nome_empresa, e_mail, contacto_tel FROM Empresa WHERE validada = '0';";
            dadosContas = ConecaoBD.ConecaoSQLServer.ExecutaSql(querySQL);
            while (this.listBox_contas.Items.Count != 0)
            {
                this.listBox_contas.Items.RemoveAt(0);
            }
            for (int i = 0; i < dadosContas.Rows.Count; i++)
            {
                this.listBox_contas.Items.Add(dadosContas.Rows[i][0].ToString());
            }

        }

        private void listBox_contas_Click(object sender, EventArgs e)
        {
            //Mostra os botões de "Eliminar" e "Verificar" conta e atribuí o nome, email e contacto às labels do form
            try
            {
                this.id = this.listBox_contas.SelectedIndex;
                this.label_nomeEmpresa.Text = dadosContas.Rows[this.id][0].ToString();
                this.label_emailEmpresa.Text = dadosContas.Rows[this.id][1].ToString();
                this.label_contactoEmpresa.Text = dadosContas.Rows[this.id][2].ToString();
                this.button_elim.Enabled = true;
                this.button_validar.Enabled = true;
                this.ValidarConta_Load(sender, e);
            }
            catch (IndexOutOfRangeException ex)
            {

            }

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_validar_Click(object sender, EventArgs e)
        {
            //Verifica se o ADM selecionou a conta pretendida
            DialogResult confirm = MessageBox.Show("Quer validar a seguinte conta?\n" +
                "\nNome: " + dadosContas.Rows[this.id][0] +
                "\nEmail: " + dadosContas.Rows[this.id][1] +
                "\nContacto: " + dadosContas.Rows[this.id][2], "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                //validada = 1 para a conta selecionada
                querySQL = "UPDATE Empresa SET validada = '1' WHERE nome_empresa = '" + dadosContas.Rows[this.id][0] + "' AND e_mail = '" + dadosContas.Rows[this.id][1] + "' AND contacto_tel = '" + dadosContas.Rows[this.id][2] + "';";
                ConecaoBD.ConecaoSQLServer.ExecutaSql(querySQL);
                this.label_nomeEmpresa.ResetText();
                this.label_emailEmpresa.ResetText();
                this.label_contactoEmpresa.ResetText();
                this.button_elim.Enabled = false;
                this.button_validar.Enabled = false;
                this.ValidarConta_Load(sender, e);
            }
        }

        private void button_elim_Click(object sender, EventArgs e)
        {
            //Verifica se o ADM selecionou a conta pretendida
            DialogResult confirm = MessageBox.Show("Quer eliminar a seguinte conta?\n" +
                "\nNome: " + dadosContas.Rows[this.id][0] +
                "\nEmail: " + dadosContas.Rows[this.id][1] +
                "\nContacto: " + dadosContas.Rows[this.id][2], "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                //Elimina a conta da base de dados
                querySQL = "DELETE FROM Empresa WHERE nome_empresa = '" + dadosContas.Rows[this.id][0] + "' AND e_mail = '" + dadosContas.Rows[this.id][1] + "' AND contacto_tel = '" + dadosContas.Rows[this.id][2] + "';";
                ConecaoBD.ConecaoSQLServer.ExecutaSql(querySQL);
                this.label_nomeEmpresa.ResetText();
                this.label_emailEmpresa.ResetText();
                this.label_contactoEmpresa.ResetText();
                this.button_elim.Enabled = false;
                this.button_validar.Enabled = false;
                this.ValidarConta_Load(sender, e);
            }
        }
    }
}
