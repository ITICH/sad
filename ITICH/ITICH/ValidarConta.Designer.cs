namespace ITICH
{
    partial class ValidarConta
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_elim = new System.Windows.Forms.Button();
            this.button_validar = new System.Windows.Forms.Button();
            this.table_main = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox_contas = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_contactoEmpresa = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_emailEmpresa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_nomeEmpresa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.table_main.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "Contas por validar";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button_cancel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_validar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_elim, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(871, 378);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(180, 156);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.White;
            this.button_cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.button_cancel.Location = new System.Drawing.Point(4, 108);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(172, 44);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Voltar atrás";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_elim
            // 
            this.button_elim.BackColor = System.Drawing.Color.White;
            this.button_elim.Enabled = false;
            this.button_elim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_elim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_elim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_elim.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_elim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.button_elim.Location = new System.Drawing.Point(4, 4);
            this.button_elim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_elim.Name = "button_elim";
            this.button_elim.Size = new System.Drawing.Size(172, 44);
            this.button_elim.TabIndex = 5;
            this.button_elim.Text = "Eliminar conta";
            this.button_elim.UseVisualStyleBackColor = false;
            this.button_elim.Click += new System.EventHandler(this.button_elim_Click);
            // 
            // button_validar
            // 
            this.button_validar.BackColor = System.Drawing.Color.White;
            this.button_validar.Enabled = false;
            this.button_validar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_validar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_validar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_validar.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_validar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.button_validar.Location = new System.Drawing.Point(4, 56);
            this.button_validar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_validar.Name = "button_validar";
            this.button_validar.Size = new System.Drawing.Size(172, 44);
            this.button_validar.TabIndex = 6;
            this.button_validar.Text = "Validar conta";
            this.button_validar.UseVisualStyleBackColor = false;
            this.button_validar.Click += new System.EventHandler(this.button_validar_Click);
            // 
            // table_main
            // 
            this.table_main.ColumnCount = 2;
            this.table_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 407F));
            this.table_main.Controls.Add(this.groupBox2, 0, 0);
            this.table_main.Controls.Add(this.groupBox1, 1, 0);
            this.table_main.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.table_main.ForeColor = System.Drawing.Color.White;
            this.table_main.Location = new System.Drawing.Point(33, 85);
            this.table_main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.table_main.Name = "table_main";
            this.table_main.RowCount = 1;
            this.table_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.table_main.Size = new System.Drawing.Size(813, 449);
            this.table_main.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox_contas);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(4, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(315, 441);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de empresas";
            // 
            // listBox_contas
            // 
            this.listBox_contas.FormattingEnabled = true;
            this.listBox_contas.ItemHeight = 23;
            this.listBox_contas.Location = new System.Drawing.Point(8, 47);
            this.listBox_contas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_contas.Name = "listBox_contas";
            this.listBox_contas.Size = new System.Drawing.Size(297, 372);
            this.listBox_contas.TabIndex = 0;
            this.listBox_contas.Click += new System.EventHandler(this.listBox_contas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_contactoEmpresa);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label_emailEmpresa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label_nomeEmpresa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(410, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(399, 441);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da empresa";
            // 
            // label_contactoEmpresa
            // 
            this.label_contactoEmpresa.AutoSize = true;
            this.label_contactoEmpresa.Location = new System.Drawing.Point(65, 343);
            this.label_contactoEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_contactoEmpresa.Name = "label_contactoEmpresa";
            this.label_contactoEmpresa.Size = new System.Drawing.Size(0, 23);
            this.label_contactoEmpresa.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 288);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Contacto";
            // 
            // label_emailEmpresa
            // 
            this.label_emailEmpresa.AutoSize = true;
            this.label_emailEmpresa.Location = new System.Drawing.Point(65, 233);
            this.label_emailEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_emailEmpresa.Name = "label_emailEmpresa";
            this.label_emailEmpresa.Size = new System.Drawing.Size(0, 23);
            this.label_emailEmpresa.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email";
            // 
            // label_nomeEmpresa
            // 
            this.label_nomeEmpresa.AutoSize = true;
            this.label_nomeEmpresa.Location = new System.Drawing.Point(65, 122);
            this.label_nomeEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nomeEmpresa.Name = "label_nomeEmpresa";
            this.label_nomeEmpresa.Size = new System.Drawing.Size(0, 23);
            this.label_nomeEmpresa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // ValidarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.table_main);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ValidarConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ValidarConta";
            this.Load += new System.EventHandler(this.ValidarConta_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.table_main.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_elim;
        private System.Windows.Forms.Button button_validar;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TableLayoutPanel table_main;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox_contas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_contactoEmpresa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_emailEmpresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_nomeEmpresa;
        private System.Windows.Forms.Label label2;
    }
}