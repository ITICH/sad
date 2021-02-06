namespace ITICH
{
    partial class PaginaInicial
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_nomeEmpresa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tab11 = new ITICH.tab1();
            this.button_historico = new System.Windows.Forms.Button();
            this.button_ValidarContas = new System.Windows.Forms.Button();
            this.button_sair = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_addParque = new System.Windows.Forms.Button();
            this.button_simulacao = new System.Windows.Forms.Button();
            this.button2_parques = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.label_nomeEmpresa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(317, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1607, 80);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_nomeEmpresa
            // 
            this.label_nomeEmpresa.AutoSize = true;
            this.label_nomeEmpresa.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nomeEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.label_nomeEmpresa.Location = new System.Drawing.Point(334, 23);
            this.label_nomeEmpresa.Name = "label_nomeEmpresa";
            this.label_nomeEmpresa.Size = new System.Drawing.Size(0, 32);
            this.label_nomeEmpresa.TabIndex = 1;
            this.label_nomeEmpresa.Click += new System.EventHandler(this.label_nomeEmpresa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Painel de Controlo  -";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tab11
            // 
            this.tab11.BackColor = System.Drawing.Color.Transparent;
            this.tab11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab11.Location = new System.Drawing.Point(317, 80);
            this.tab11.Name = "tab11";
            this.tab11.Size = new System.Drawing.Size(1607, 863);
            this.tab11.TabIndex = 11;
            this.tab11.Load += new System.EventHandler(this.tab11_Load);
            // 
            // button_historico
            // 
            this.button_historico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(246)))));
            this.button_historico.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_historico.FlatAppearance.BorderSize = 0;
            this.button_historico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_historico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_historico.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_historico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.button_historico.Image = global::ITICH.Properties.Resources.biography;
            this.button_historico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_historico.Location = new System.Drawing.Point(22, 481);
            this.button_historico.Name = "button_historico";
            this.button_historico.Size = new System.Drawing.Size(280, 39);
            this.button_historico.TabIndex = 13;
            this.button_historico.Text = "Histórico Simulações";
            this.button_historico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_historico.UseVisualStyleBackColor = false;
            this.button_historico.Click += new System.EventHandler(this.button_historico_Click);
            // 
            // button_ValidarContas
            // 
            this.button_ValidarContas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(246)))));
            this.button_ValidarContas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_ValidarContas.FlatAppearance.BorderSize = 0;
            this.button_ValidarContas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_ValidarContas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ValidarContas.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ValidarContas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.button_ValidarContas.Image = global::ITICH.Properties.Resources.cards;
            this.button_ValidarContas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ValidarContas.Location = new System.Drawing.Point(22, 637);
            this.button_ValidarContas.Name = "button_ValidarContas";
            this.button_ValidarContas.Size = new System.Drawing.Size(280, 39);
            this.button_ValidarContas.TabIndex = 12;
            this.button_ValidarContas.Text = "Validar Contas";
            this.button_ValidarContas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_ValidarContas.UseVisualStyleBackColor = false;
            this.button_ValidarContas.Visible = false;
            this.button_ValidarContas.Click += new System.EventHandler(this.button_ValidarContas_Click);
            // 
            // button_sair
            // 
            this.button_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(246)))));
            this.button_sair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_sair.FlatAppearance.BorderSize = 0;
            this.button_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sair.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.button_sair.Image = global::ITICH.Properties.Resources.exit3;
            this.button_sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sair.Location = new System.Drawing.Point(22, 715);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(280, 39);
            this.button_sair.TabIndex = 9;
            this.button_sair.Text = "Sair";
            this.button_sair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_sair.UseVisualStyleBackColor = false;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(246)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::ITICH.Properties.Resources.logotipo;
            this.pictureBox2.Location = new System.Drawing.Point(0, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(302, 173);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button_addParque
            // 
            this.button_addParque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(246)))));
            this.button_addParque.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_addParque.FlatAppearance.BorderSize = 0;
            this.button_addParque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_addParque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addParque.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addParque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.button_addParque.Image = global::ITICH.Properties.Resources.add_location2;
            this.button_addParque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_addParque.Location = new System.Drawing.Point(22, 559);
            this.button_addParque.Name = "button_addParque";
            this.button_addParque.Size = new System.Drawing.Size(280, 39);
            this.button_addParque.TabIndex = 7;
            this.button_addParque.Text = "Adicionar Parque";
            this.button_addParque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_addParque.UseVisualStyleBackColor = false;
            this.button_addParque.Click += new System.EventHandler(this.button_addParque_Click);
            // 
            // button_simulacao
            // 
            this.button_simulacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(246)))));
            this.button_simulacao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_simulacao.FlatAppearance.BorderSize = 0;
            this.button_simulacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_simulacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_simulacao.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_simulacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.button_simulacao.Image = global::ITICH.Properties.Resources.simulation3;
            this.button_simulacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_simulacao.Location = new System.Drawing.Point(22, 403);
            this.button_simulacao.Name = "button_simulacao";
            this.button_simulacao.Size = new System.Drawing.Size(280, 39);
            this.button_simulacao.TabIndex = 6;
            this.button_simulacao.Text = "Iniciar Simulação";
            this.button_simulacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_simulacao.UseVisualStyleBackColor = false;
            this.button_simulacao.Click += new System.EventHandler(this.button_simulacao_Click);
            // 
            // button2_parques
            // 
            this.button2_parques.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(246)))));
            this.button2_parques.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button2_parques.FlatAppearance.BorderSize = 0;
            this.button2_parques.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button2_parques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_parques.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2_parques.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.button2_parques.Image = global::ITICH.Properties.Resources.search_location;
            this.button2_parques.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2_parques.Location = new System.Drawing.Point(22, 325);
            this.button2_parques.Name = "button2_parques";
            this.button2_parques.Size = new System.Drawing.Size(280, 39);
            this.button2_parques.TabIndex = 5;
            this.button2_parques.Text = "Pesquisar Parques";
            this.button2_parques.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2_parques.UseVisualStyleBackColor = false;
            this.button2_parques.Click += new System.EventHandler(this.button2_parques_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(246)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.button1.Image = global::ITICH.Properties.Resources.profile;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(22, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dados da Empresa";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ITICH.Properties.Resources.funMenu1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 943);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 943);
            this.Controls.Add(this.button_historico);
            this.Controls.Add(this.button_ValidarContas);
            this.Controls.Add(this.tab11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button_addParque);
            this.Controls.Add(this.button_simulacao);
            this.Controls.Add(this.button2_parques);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "PaginaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel de Controlo";
            this.Load += new System.EventHandler(this.PaginaInicial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2_parques;
        private System.Windows.Forms.Button button_simulacao;
        private System.Windows.Forms.Button button_addParque;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private tab1 tab11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_nomeEmpresa;
        private System.Windows.Forms.Button button_ValidarContas;
        private System.Windows.Forms.Button button_historico;
    }
}