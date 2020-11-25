namespace ITICH
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
            this.groupBox_pesqParque = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_pesquisa = new System.Windows.Forms.TextBox();
            this.label_nomeParque = new System.Windows.Forms.Label();
            this.button_addParque2 = new System.Windows.Forms.Button();
            this.button_pesquisaP = new System.Windows.Forms.Button();
            this.button_pedirAcesso2 = new System.Windows.Forms.Button();
            this.groupBox_pesqParque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_pesqParque
            // 
            this.groupBox_pesqParque.Controls.Add(this.dataGridView1);
            this.groupBox_pesqParque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_pesqParque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_pesqParque.Location = new System.Drawing.Point(48, 109);
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.textBox_pesquisa.Location = new System.Drawing.Point(240, 63);
            this.textBox_pesquisa.Name = "textBox_pesquisa";
            this.textBox_pesquisa.Size = new System.Drawing.Size(265, 22);
            this.textBox_pesquisa.TabIndex = 1;
            this.textBox_pesquisa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_nomeParque
            // 
            this.label_nomeParque.AutoSize = true;
            this.label_nomeParque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nomeParque.Location = new System.Drawing.Point(45, 64);
            this.label_nomeParque.Name = "label_nomeParque";
            this.label_nomeParque.Size = new System.Drawing.Size(175, 18);
            this.label_nomeParque.TabIndex = 2;
            this.label_nomeParque.Text = "Pesquise por um Parque:";
            this.label_nomeParque.Click += new System.EventHandler(this.label_nomeParque_Click);
            // 
            // button_addParque2
            // 
            this.button_addParque2.BackColor = System.Drawing.Color.White;
            this.button_addParque2.Enabled = false;
            this.button_addParque2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_addParque2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_addParque2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addParque2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addParque2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.button_addParque2.Image = global::ITICH.Properties.Resources.add_location;
            this.button_addParque2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_addParque2.Location = new System.Drawing.Point(1142, 89);
            this.button_addParque2.Name = "button_addParque2";
            this.button_addParque2.Size = new System.Drawing.Size(249, 44);
            this.button_addParque2.TabIndex = 8;
            this.button_addParque2.Text = "Adicionar Parque";
            this.button_addParque2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_addParque2.UseVisualStyleBackColor = false;
            this.button_addParque2.Click += new System.EventHandler(this.button_addParque2_Click);
            // 
            // button_pesquisaP
            // 
            this.button_pesquisaP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_pesquisaP.FlatAppearance.BorderSize = 0;
            this.button_pesquisaP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_pesquisaP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pesquisaP.Image = global::ITICH.Properties.Resources.loupe_pequeno;
            this.button_pesquisaP.Location = new System.Drawing.Point(511, 56);
            this.button_pesquisaP.Name = "button_pesquisaP";
            this.button_pesquisaP.Size = new System.Drawing.Size(41, 36);
            this.button_pesquisaP.TabIndex = 3;
            this.button_pesquisaP.UseVisualStyleBackColor = true;
            this.button_pesquisaP.Click += new System.EventHandler(this.button_pesquisaP_Click);
            // 
            // button_pedirAcesso2
            // 
            this.button_pedirAcesso2.BackColor = System.Drawing.Color.White;
            this.button_pedirAcesso2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_pedirAcesso2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_pedirAcesso2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pedirAcesso2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pedirAcesso2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.button_pedirAcesso2.Image = global::ITICH.Properties.Resources.admin;
            this.button_pedirAcesso2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_pedirAcesso2.Location = new System.Drawing.Point(1142, 32);
            this.button_pedirAcesso2.Name = "button_pedirAcesso2";
            this.button_pedirAcesso2.Size = new System.Drawing.Size(249, 44);
            this.button_pedirAcesso2.TabIndex = 9;
            this.button_pedirAcesso2.Text = "Acesso Administrador";
            this.button_pedirAcesso2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_pedirAcesso2.UseVisualStyleBackColor = false;
            this.button_pedirAcesso2.Click += new System.EventHandler(this.button_pedirAcesso2_Click);
            // 
            // PesquisarParques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1406, 683);
            this.Controls.Add(this.button_pedirAcesso2);
            this.Controls.Add(this.button_addParque2);
            this.Controls.Add(this.button_pesquisaP);
            this.Controls.Add(this.label_nomeParque);
            this.Controls.Add(this.textBox_pesquisa);
            this.Controls.Add(this.groupBox_pesqParque);
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
        private System.Windows.Forms.Button button_addParque2;
        private System.Windows.Forms.Button button_pedirAcesso2;
    }
}