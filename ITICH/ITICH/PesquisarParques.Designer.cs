﻿namespace ITICH
{
    partial class PesquisarParques
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisarParques));
            this.groupBox_pesqParque = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_pesquisa = new System.Windows.Forms.TextBox();
            this.label_nomeParque = new System.Windows.Forms.Label();
            this.label1_distrito = new System.Windows.Forms.Label();
            this.textBox_pesqDistrito = new System.Windows.Forms.TextBox();
            this.button1_back = new System.Windows.Forms.Button();
            this.button_pedirAcesso2 = new System.Windows.Forms.Button();
            this.button_pesquisaP = new System.Windows.Forms.Button();
            this.groupBox_pesqParque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_pesqParque
            // 
            this.groupBox_pesqParque.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_pesqParque.Controls.Add(this.dataGridView1);
            this.groupBox_pesqParque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_pesqParque.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_pesqParque.ForeColor = System.Drawing.Color.White;
            this.groupBox_pesqParque.Location = new System.Drawing.Point(53, 121);
            this.groupBox_pesqParque.Name = "groupBox_pesqParque";
            this.groupBox_pesqParque.Size = new System.Drawing.Size(959, 471);
            this.groupBox_pesqParque.TabIndex = 0;
            this.groupBox_pesqParque.TabStop = false;
            this.groupBox_pesqParque.Text = "Parques Cientificos e Tecnologicos";
            this.groupBox_pesqParque.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(19, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(921, 415);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox_pesquisa
            // 
            this.textBox_pesquisa.Location = new System.Drawing.Point(356, 63);
            this.textBox_pesquisa.Name = "textBox_pesquisa";
            this.textBox_pesquisa.Size = new System.Drawing.Size(190, 22);
            this.textBox_pesquisa.TabIndex = 1;
            this.textBox_pesquisa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_nomeParque
            // 
            this.label_nomeParque.AutoSize = true;
            this.label_nomeParque.BackColor = System.Drawing.Color.Transparent;
            this.label_nomeParque.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nomeParque.ForeColor = System.Drawing.Color.White;
            this.label_nomeParque.Location = new System.Drawing.Point(62, 61);
            this.label_nomeParque.Name = "label_nomeParque";
            this.label_nomeParque.Size = new System.Drawing.Size(244, 23);
            this.label_nomeParque.TabIndex = 2;
            this.label_nomeParque.Text = "Pesquisar parque pelo Nome:";
            this.label_nomeParque.Click += new System.EventHandler(this.label_nomeParque_Click);
            // 
            // label1_distrito
            // 
            this.label1_distrito.AutoSize = true;
            this.label1_distrito.BackColor = System.Drawing.Color.Transparent;
            this.label1_distrito.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_distrito.ForeColor = System.Drawing.Color.White;
            this.label1_distrito.Location = new System.Drawing.Point(563, 61);
            this.label1_distrito.Name = "label1_distrito";
            this.label1_distrito.Size = new System.Drawing.Size(141, 23);
            this.label1_distrito.TabIndex = 11;
            this.label1_distrito.Text = "ou pelo Distrito:";
            this.label1_distrito.Click += new System.EventHandler(this.label1_distrito_Click);
            // 
            // textBox_pesqDistrito
            // 
            this.textBox_pesqDistrito.Location = new System.Drawing.Point(733, 63);
            this.textBox_pesqDistrito.Name = "textBox_pesqDistrito";
            this.textBox_pesqDistrito.Size = new System.Drawing.Size(190, 22);
            this.textBox_pesqDistrito.TabIndex = 12;
            this.textBox_pesqDistrito.TextChanged += new System.EventHandler(this.textBox_pesqDistrito_TextChanged);
            // 
            // button1_back
            // 
            this.button1_back.BackColor = System.Drawing.Color.Transparent;
            this.button1_back.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_back.Image = global::ITICH.Properties.Resources.undo2;
            this.button1_back.Location = new System.Drawing.Point(12, 12);
            this.button1_back.Name = "button1_back";
            this.button1_back.Size = new System.Drawing.Size(47, 37);
            this.button1_back.TabIndex = 10;
            this.button1_back.UseVisualStyleBackColor = false;
            this.button1_back.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_pedirAcesso2
            // 
            this.button_pedirAcesso2.BackColor = System.Drawing.Color.White;
            this.button_pedirAcesso2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_pedirAcesso2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_pedirAcesso2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pedirAcesso2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pedirAcesso2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.button_pedirAcesso2.Image = global::ITICH.Properties.Resources.mail3;
            this.button_pedirAcesso2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_pedirAcesso2.Location = new System.Drawing.Point(1086, 25);
            this.button_pedirAcesso2.Name = "button_pedirAcesso2";
            this.button_pedirAcesso2.Size = new System.Drawing.Size(298, 67);
            this.button_pedirAcesso2.TabIndex = 9;
            this.button_pedirAcesso2.Text = "Pedir para adicionar novo parque";
            this.button_pedirAcesso2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_pedirAcesso2.UseVisualStyleBackColor = false;
            this.button_pedirAcesso2.Click += new System.EventHandler(this.button_pedirAcesso2_Click);
            // 
            // button_pesquisaP
            // 
            this.button_pesquisaP.BackColor = System.Drawing.Color.Transparent;
            this.button_pesquisaP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_pesquisaP.FlatAppearance.BorderSize = 0;
            this.button_pesquisaP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_pesquisaP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pesquisaP.Image = global::ITICH.Properties.Resources.magnifying_glass;
            this.button_pesquisaP.Location = new System.Drawing.Point(949, 56);
            this.button_pesquisaP.Name = "button_pesquisaP";
            this.button_pesquisaP.Size = new System.Drawing.Size(41, 36);
            this.button_pesquisaP.TabIndex = 3;
            this.button_pesquisaP.UseVisualStyleBackColor = false;
            this.button_pesquisaP.Click += new System.EventHandler(this.button_pesquisaP_Click);
            // 
            // PesquisarParques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1406, 683);
            this.Controls.Add(this.textBox_pesqDistrito);
            this.Controls.Add(this.label1_distrito);
            this.Controls.Add(this.button1_back);
            this.Controls.Add(this.button_pedirAcesso2);
            this.Controls.Add(this.button_pesquisaP);
            this.Controls.Add(this.label_nomeParque);
            this.Controls.Add(this.textBox_pesquisa);
            this.Controls.Add(this.groupBox_pesqParque);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PesquisarParques";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Parques Cientificos e Tecnológicos";
            this.Load += new System.EventHandler(this.PesquisarParques_Load);
            this.groupBox_pesqParque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_pesqParque;
        private System.Windows.Forms.TextBox textBox_pesquisa;
        private System.Windows.Forms.Label label_nomeParque;
        private System.Windows.Forms.Button button_pesquisaP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_pedirAcesso2;
        private System.Windows.Forms.Button button1_back;
        private System.Windows.Forms.Label label1_distrito;
        private System.Windows.Forms.TextBox textBox_pesqDistrito;
    }
}