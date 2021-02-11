namespace ITICH.Simulacoes
{
    partial class Historico
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
            this.groupBox_pesqParque = new System.Windows.Forms.GroupBox();
            this.button1_back4 = new System.Windows.Forms.Button();
            this.label_titulo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_abrir = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox_pesqParque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_pesqParque
            // 
            this.groupBox_pesqParque.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_pesqParque.Controls.Add(this.richTextBox1);
            this.groupBox_pesqParque.Controls.Add(this.button_abrir);
            this.groupBox_pesqParque.Controls.Add(this.dataGridView1);
            this.groupBox_pesqParque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_pesqParque.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_pesqParque.ForeColor = System.Drawing.Color.White;
            this.groupBox_pesqParque.Location = new System.Drawing.Point(55, 99);
            this.groupBox_pesqParque.Name = "groupBox_pesqParque";
            this.groupBox_pesqParque.Size = new System.Drawing.Size(1292, 514);
            this.groupBox_pesqParque.TabIndex = 1;
            this.groupBox_pesqParque.TabStop = false;
            this.groupBox_pesqParque.Text = "Histórico de Simulações";
            this.groupBox_pesqParque.Enter += new System.EventHandler(this.groupBox_pesqParque_Enter);
            // 
            // button1_back4
            // 
            this.button1_back4.BackColor = System.Drawing.Color.Transparent;
            this.button1_back4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1_back4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1_back4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_back4.Image = global::ITICH.Properties.Resources.undo2;
            this.button1_back4.Location = new System.Drawing.Point(31, 16);
            this.button1_back4.Name = "button1_back4";
            this.button1_back4.Size = new System.Drawing.Size(47, 37);
            this.button1_back4.TabIndex = 13;
            this.button1_back4.UseVisualStyleBackColor = false;
            this.button1_back4.Click += new System.EventHandler(this.button1_back4_Click);
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.ForeColor = System.Drawing.Color.White;
            this.label_titulo.Location = new System.Drawing.Point(137, 14);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(330, 38);
            this.label_titulo.TabIndex = 14;
            this.label_titulo.Text = "Histórico de Simulações";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(19, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1252, 450);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_abrir
            // 
            this.button_abrir.BackColor = System.Drawing.Color.White;
            this.button_abrir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_abrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_abrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_abrir.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_abrir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.button_abrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_abrir.Location = new System.Drawing.Point(877, 39);
            this.button_abrir.Name = "button_abrir";
            this.button_abrir.Size = new System.Drawing.Size(162, 47);
            this.button_abrir.TabIndex = 38;
            this.button_abrir.Text = "Ver Parque";
            this.button_abrir.UseVisualStyleBackColor = false;
            this.button_abrir.Click += new System.EventHandler(this.button_abrir_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(877, 126);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(394, 363);
            this.richTextBox1.TabIndex = 39;
            this.richTextBox1.Text = "";
            // 
            // Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1406, 683);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.button1_back4);
            this.Controls.Add(this.groupBox_pesqParque);
            this.Name = "Historico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historico de Simulações";
            this.Load += new System.EventHandler(this.Historico_Load);
            this.groupBox_pesqParque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_pesqParque;
        private System.Windows.Forms.Button button1_back4;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_abrir;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}