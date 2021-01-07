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
    public partial class CriarParque : Form
    {
        /*
        Stages:
        1- Localização
        2- Parque
        3- Area
        4- Dominio
        5- Incubadora
        6- Incubadora Espaço
        7- Incubadora Serviços
        8- Carateristicas Instalacao
        9- Instalacoes
        */

        private DataTable dataTable;
        private DataRow[] foundRows;

        private int indexLocalizacao;
        private int indexParque;
        private int indexIncubadora;
        private int indexCaracteristicas;

        DataTable bufferIncubadoras;
        public CriarParque()
        {
            InitializeComponent();
            progressBar.Value = 10;
            ConecaoSQLServer.ExecutaSql("INSERT INTO Localizacao (distrit, concelh, morada) VALUES ('" + RegistoParque.distritoGeral + "', '" + RegistoParque.concelhoGeral + "', '" + RegistoParque.moradaGeral + "');");
            dataTable = ConecaoSQLServer.ExecutaSql("SELECT MAX(id_localizacao) FROM Localizacao");
            foundRows = dataTable.Select();
            indexLocalizacao = Convert.ToInt32(foundRows[0][0]);

            progressBar.Value = 20;
            ConecaoSQLServer.ExecutaSql("INSERT INTO Parques_cientificos (entidade_gestora, fins_lucrativos, interesse_publico, contacto_tel, ano_de_inicio, patrimonio_acossiativo_e_capital_social, id_fase_de_desenvolvimento, id_carateristica_juridica, id_localizacao, nome_parque, e_mail) VALUES (" +
                                        "'" + RegistoParque.entidadeGestoraGeral + "', " +
                                        "'" + RegistoParque.finsGeral + "', " +
                                        "'" + RegistoParque.interesseGeral + "', " +
                                        "'" + RegistoParque.telefoneGeral + "', " +
                                        "'" + "01-01-1970" + "', " +
                                        "'" + RegistoParque.capitalGeral + "', " +
                                        "'" + RegistoParque.faseGeral + "', " +
                                        "'" + RegistoParque.juridicialGeral + "', " +
                                        "'" + indexLocalizacao + "', " +
                                        "'" + RegistoParque.nomeGeral + "', " +
                                        "'" + RegistoParque.emailGeral + "')"
                                        );
            dataTable = ConecaoSQLServer.ExecutaSql("SELECT MAX(id_parque) FROM Parques_cientificos");
            foundRows = dataTable.Select();
            indexParque = Convert.ToInt32(foundRows[0][0]);

            progressBar.Value = 30;
            if (RegistoParque.areas.Count > 0)
            {
                foreach(string item in RegistoParque.areas)
                {
                    ConecaoSQLServer.ExecutaSql("INSERT INTO Areas_negocios (id_parque, id_nome_area) VALUES (" +
                                        "'" + indexParque + "', " +
                                        "'" + item + "')"
                                        );
                }
            }

            progressBar.Value = 40;
            if (RegistoParque.dominios.Count > 0)
            {
                foreach (string item in RegistoParque.dominios)
                {
                    ConecaoSQLServer.ExecutaSql("INSERT INTO Dominios_cientificos_tecnologicos (id_parque, id_nome_dominio) VALUES (" +
                                        "'" + indexParque + "', " +
                                        "'" + item + "')"
                                        );
                }
            }

            
            if(RegistoParque.incubadoras.Rows.Count > 0)
            {
                for(int i = 0; i < RegistoParque.incubadoras.Rows.Count; i++)
                {
                    progressBar.Value = 50;
                    ConecaoSQLServer.ExecutaSql("INSERT INTO Incubadoras (volume_negocios, numero_de_pessoas, nom_inc, id_parque) VALUES (" +
                        "'" + RegistoParque.incubadoras.Rows[i][1] + "', " +
                        "'" + RegistoParque.incubadoras.Rows[i][2] + "', " +
                        "'" + RegistoParque.incubadoras.Rows[i][0] + "', " +
                        "'" + indexParque + "')"
                        );
                    dataTable = ConecaoSQLServer.ExecutaSql("SELECT MAX(id_incubadora) FROM Incubadoras");
                    foundRows = dataTable.Select();
                    indexIncubadora = Convert.ToInt32(foundRows[0][0]);

                    progressBar.Value = 60;
                    ConecaoSQLServer.ExecutaSql("INSERT INTO Espacos_incubadora (tipo_espaco, id_incubadora) VALUES (" +
                    "'" + RegistoParque.incubadoras.Rows[i][3] + "', " +
                    "'" + indexIncubadora + "')"
                    );

                    progressBar.Value = 70;
                    ConecaoSQLServer.ExecutaSql("INSERT INTO Servicos_incubadora (tipo_servico, id_incubadora) VALUES (" +
                    "'" + RegistoParque.incubadoras.Rows[i][4] + "', " +
                    "'" + indexIncubadora + "')"
                    );
                }
            }

            if(RegistoParque.instalacoes.Rows.Count > 0)
            {
                
                for (int i = 0; i < RegistoParque.instalacoes.Rows.Count; i++)
                {
                    progressBar.Value = 80;
                    ConecaoSQLServer.ExecutaSql("INSERT INTO Carateristicas_instalacoes (num_lotes, num_lotes_ocupados, estacionamento, videovigilancia, seguranca, tipo_de_rede) VALUES (" +
                        "'" + RegistoParque.instalacoes.Rows[i][3] + "', " +
                        "'" + RegistoParque.instalacoes.Rows[i][4] + "', " +
                        "'" + RegistoParque.instalacoes.Rows[i][5] + "', " +
                        "'" + RegistoParque.instalacoes.Rows[i][6] + "', " +
                        "'" + RegistoParque.instalacoes.Rows[i][7] + "', " +
                        "'" + RegistoParque.instalacoes.Rows[i][8] + "')"
                        );
                    dataTable = ConecaoSQLServer.ExecutaSql("SELECT MAX(id_carateristicas) FROM Carateristicas_instalacoes");
                    foundRows = dataTable.Select();
                    indexCaracteristicas = Convert.ToInt32(foundRows[0][0]);

                    progressBar.Value = 90;
                    ConecaoSQLServer.ExecutaSql("INSERT INTO Instalacoes (id_carateristicas, id_parque, designaca, localidad, concelh) VALUES (" +
                        "'" + indexCaracteristicas + "', " +
                        "'" + indexParque + "', " +
                        "'" + RegistoParque.instalacoes.Rows[i][0] + "', " +
                        "'" + RegistoParque.instalacoes.Rows[i][1] + "', " +
                        "'" + RegistoParque.instalacoes.Rows[i][2] + "')"
                        );
                }
            }

            progressBar.Value = 100;
            concluido();
        }

        private void reverter()
        {
            Close();
        }

        private void concluido()
        {
            MessageBox.Show("Parque criado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult cancelarCriacao = MessageBox.Show("Tem a certeza que quer cancelar a operação?\n(Se aceitar a operação será terminada e voltará à edição do formulário.", "Operação Pausada", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cancelarCriacao == DialogResult.Yes)
            {
                reverter();
            }
        }
    }
}
