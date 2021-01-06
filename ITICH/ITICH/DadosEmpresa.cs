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
    public partial class DadosEmpresa : Form
    {
        //variaveis para o funcionamento do form
        private bool edit = false;
        //DataTable com para guardar os dados do utilizador
        DataTable dadosUtilizador;
        //id da conta do utilizador para que a app saiba que conta foi usada para o login
        int id;
        //variavel para query de SQL
        String querySQL;

        public DadosEmpresa(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void DadosEmpresa_Load(object sender, EventArgs e)
        {
            //labels do form ficam com os dados da conta
            querySQL = "SELECT nome_empresa, contacto_tel, e_mail, password FROM Empresa WHERE id_empresa = '" + id + "';";
            dadosUtilizador = ConecaoBD.ConecaoSQLServer.ExecutaSql(querySQL);

            label_nomeEmpresa.Text = dadosUtilizador.Rows[0][0].ToString();
            label_emailConta.Text = dadosUtilizador.Rows[0][2].ToString();
            label_passwordConta.Text = new string('*', desencriptarpwd(dadosUtilizador.Rows[0][3].ToString()).Length);
            label_contactoConta.Text = dadosUtilizador.Rows[0][1].ToString();


            //muda a aparencia do form dependendo se está no modo de edição de dados ou não
            if (!edit)
            {
                button_cancel.Text = "Voltar atrás";
                button_editDados.Text = "Editar dados";
                label_repitaPassword.Visible = false;
                textBox_nomeEmpresa.Visible = false;
                textBox_email.Visible = false;
                textBox_password.Visible = false;
                textBox_repitaPassword.Visible = false;
                textBox_contacto.Visible = false;
                label_emailConta.Visible = true;
                label_passwordConta.Visible = true;
                label_contactoConta.Visible = true;
                checkBox_mostrarPassword.Visible = false;
            }
            else
            {
                button_cancel.Text = "Cancelar";
                button_editDados.Text = "Guardar dados";
                label_repitaPassword.Visible = true;
                textBox_nomeEmpresa.Text = label_nomeEmpresa.Text;
                textBox_nomeEmpresa.Visible = true;
                textBox_email.Text = label_emailConta.Text;
                textBox_email.Visible = true;
                textBox_password.Visible = true;
                textBox_repitaPassword.Visible = true;
                textBox_contacto.Text = label_contactoConta.Text;
                textBox_contacto.Visible = true;
                label_emailConta.Visible = false;
                label_passwordConta.Visible = false;
                label_contactoConta.Visible = false;
                checkBox_mostrarPassword.Visible = true;
            }
        }

        private void button_editDados_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                //quando não está no modo de edição de dados e o utilizador clica no botão "Editar dados", o form passa para o modo de edição de dados
                edit = !edit;
                DadosEmpresa_Load(this, e);

            }
            else
            {
                //quando o form está no modo de edição de dados
                //verifica que as passwords inseridas são iguais
                if (textBox_password.Text == textBox_repitaPassword.Text)
                {
                    //caso haja informação que foi alterada, um aviso aparece para que o utilizador confirme as mudanças
                    if (textBox_nomeEmpresa.Text != label_nomeEmpresa.Text || textBox_email.Text != label_emailConta.Text || (textBox_password.Text != desencriptarpwd(dadosUtilizador.Rows[0][3].ToString()) && !String.IsNullOrEmpty(textBox_password.Text)) || textBox_contacto.Text != label_contactoConta.Text)
                    {
                        DialogResult confirm = MessageBox.Show("Quer guardar as alterações?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (confirm == DialogResult.Yes)
                        {
                            //caso o utilizador confirme as mudanças, o programa atualiza a base de dados para que passe a ter os dados novos
                            if (textBox_nomeEmpresa.Text != label_nomeEmpresa.Text)
                            {
                                querySQL = "UPDATE Empresa SET nome_empresa = '" + textBox_nomeEmpresa.Text + "' WHERE id_empresa = '" + this.id + "';";
                                ConecaoBD.ConecaoSQLServer.ExecutaSql(querySQL);
                            }
                            if (textBox_email.Text != label_email.Text)
                            {
                                querySQL = "UPDATE Empresa SET e_mail = '" + textBox_email.Text + "' WHERE id_empresa = '" + this.id + "';";
                                ConecaoBD.ConecaoSQLServer.ExecutaSql(querySQL);
                            }
                            if (textBox_password.Text != desencriptarpwd(dadosUtilizador.Rows[0][3].ToString())) ;
                            {
                                byte[] encode = new byte[textBox_password.Text.Length];
                                encode = Encoding.UTF8.GetBytes(textBox_password.Text);
                                querySQL = "UPDATE Empresa SET password = '" + Convert.ToBase64String(encode) + "' WHERE id_empresa = '" + this.id + "';";
                                ConecaoBD.ConecaoSQLServer.ExecutaSql(querySQL);
                            }
                            if (textBox_contacto.Text != label_contactoConta.Text)
                            {
                                querySQL = "UPDATE Empresa SET contacto_tel = '" + textBox_contacto.Text + "' WHERE id_empresa = '" + this.id + "';";
                                ConecaoBD.ConecaoSQLServer.ExecutaSql(querySQL);
                            }
                            //depois de guardar os dados, o form deixa de estar no modo de edição de dados e atualiza a informação das labels
                            edit = false;
                            textBox_password.Clear();
                            textBox_repitaPassword.Clear();
                            checkBox_mostrarPassword.Checked = false;
                            DadosEmpresa_Load(this, e);
                        }
                    }
                    else
                    {
                        edit = false;
                        DadosEmpresa_Load(this, e);
                    }
                }
                else
                {
                    //caso as passwords inseridas sejam diferentes
                    MessageBox.Show("As palavras-passe não correspondem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                //deixa de estar no modo de edição de dados quando o botão "Cancelar" é usado
                edit = !edit;
                DadosEmpresa_Load(this, e);
            }
            else
            {
                //o form fecha quando o form não está no modo de edição de dados e o utilizador usa o botão "Voltar atrás"
                this.Close();
            }
        }

        private void checkBox_mostrarPassword_CheckedChanged(object sender, EventArgs e)
        {
            //código para ver o texto das passwords inseridas dependendo da checkBox
            if (checkBox_mostrarPassword.Checked)
            {
                textBox_password.UseSystemPasswordChar = false;
                textBox_repitaPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_password.UseSystemPasswordChar = true;
                textBox_repitaPassword.UseSystemPasswordChar = true;
            }
        }

        public String desencriptarpwd(string password)
        {
            string decryptpwd = "";
            UTF8Encoding encodepwd = new UTF8Encoding();
            Decoder Decode = encodepwd.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(password);
            int charCount = Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            decryptpwd = new String(decoded_char);
            return decryptpwd;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}


