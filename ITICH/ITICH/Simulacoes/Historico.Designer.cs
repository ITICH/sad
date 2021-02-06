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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox_pesqParque = new System.Windows.Forms.GroupBox();
            this.dataGridView_simulacao = new System.Windows.Forms.DataGridView();
            this.button1_back4 = new System.Windows.Forms.Button();
            this.groupBox_pesqParque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_simulacao)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_pesqParque
            // 
            this.groupBox_pesqParque.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_pesqParque.Controls.Add(this.dataGridView_simulacao);
            this.groupBox_pesqParque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_pesqParque.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_pesqParque.ForeColor = System.Drawing.Color.White;
            this.groupBox_pesqParque.Location = new System.Drawing.Point(55, 99);
            this.groupBox_pesqParque.Name = "groupBox_pesqParque";
            this.groupBox_pesqParque.Size = new System.Drawing.Size(959, 474);
            this.groupBox_pesqParque.TabIndex = 1;
            this.groupBox_pesqParque.TabStop = false;
            this.groupBox_pesqParque.Text = "Histórico de Simulações";
            this.groupBox_pesqParque.Enter += new System.EventHandler(this.groupBox_pesqParque_Enter);
            // 
            // dataGridView_simulacao
            // 
            this.dataGridView_simulacao.AllowUserToAddRows = false;
            this.dataGridView_simulacao.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dataGridView_simulacao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_simulacao.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_simulacao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_simulacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_simulacao.Location = new System.Drawing.Point(19, 38);
            this.dataGridView_simulacao.Name = "dataGridView_simulacao";
            this.dataGridView_simulacao.ReadOnly = true;
            this.dataGridView_simulacao.RowHeadersWidth = 51;
            this.dataGridView_simulacao.RowTemplate.Height = 24;
            this.dataGridView_simulacao.Size = new System.Drawing.Size(921, 415);
            this.dataGridView_simulacao.TabIndex = 0;
            this.dataGridView_simulacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_simulacao_CellContentClick);
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
            // Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1406, 683);
            this.Controls.Add(this.button1_back4);
            this.Controls.Add(this.groupBox_pesqParque);
            this.Name = "Historico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historico de Simulações";
            this.groupBox_pesqParque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_simulacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_pesqParque;
        private System.Windows.Forms.DataGridView dataGridView_simulacao;
        private System.Windows.Forms.Button button1_back4;
    }
}