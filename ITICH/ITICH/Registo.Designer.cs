namespace ITICH
{
    partial class Registo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_nomeEmpresa = new System.Windows.Forms.TextBox();
            this.textBox_contacto = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_pwd = new System.Windows.Forms.TextBox();
            this.button_registar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.textBox_pwd2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1_pwd = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contacto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Palavra - Passe";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_nomeEmpresa
            // 
            this.textBox_nomeEmpresa.Location = new System.Drawing.Point(312, 187);
            this.textBox_nomeEmpresa.Name = "textBox_nomeEmpresa";
            this.textBox_nomeEmpresa.Size = new System.Drawing.Size(172, 22);
            this.textBox_nomeEmpresa.TabIndex = 4;
            // 
            // textBox_contacto
            // 
            this.textBox_contacto.Location = new System.Drawing.Point(312, 225);
            this.textBox_contacto.Name = "textBox_contacto";
            this.textBox_contacto.Size = new System.Drawing.Size(172, 22);
            this.textBox_contacto.TabIndex = 5;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(312, 263);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(172, 22);
            this.textBox_email.TabIndex = 6;
            this.textBox_email.TextChanged += new System.EventHandler(this.textBox_email_TextChanged);
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.Location = new System.Drawing.Point(312, 303);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.Size = new System.Drawing.Size(172, 22);
            this.textBox_pwd.TabIndex = 7;
            this.textBox_pwd.UseSystemPasswordChar = true;
            // 
            // button_registar
            // 
            this.button_registar.BackColor = System.Drawing.Color.White;
            this.button_registar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_registar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_registar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_registar.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_registar.ForeColor = System.Drawing.Color.Black;
            this.button_registar.Location = new System.Drawing.Point(251, 418);
            this.button_registar.Name = "button_registar";
            this.button_registar.Size = new System.Drawing.Size(98, 33);
            this.button_registar.TabIndex = 9;
            this.button_registar.Text = "Registar";
            this.button_registar.UseVisualStyleBackColor = false;
            this.button_registar.Click += new System.EventHandler(this.button_registar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.BackColor = System.Drawing.Color.White;
            this.button_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(31)))));
            this.button_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancelar.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar.ForeColor = System.Drawing.Color.Black;
            this.button_cancelar.Location = new System.Drawing.Point(374, 418);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(99, 33);
            this.button_cancelar.TabIndex = 10;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = false;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // textBox_pwd2
            // 
            this.textBox_pwd2.Location = new System.Drawing.Point(312, 343);
            this.textBox_pwd2.Name = "textBox_pwd2";
            this.textBox_pwd2.Size = new System.Drawing.Size(172, 22);
            this.textBox_pwd2.TabIndex = 12;
            this.textBox_pwd2.UseSystemPasswordChar = true;
            this.textBox_pwd2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Repita a palavra-passe";
            // 
            // checkBox1_pwd
            // 
            this.checkBox1_pwd.AutoSize = true;
            this.checkBox1_pwd.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1_pwd.Font = new System.Drawing.Font("Nirmala UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1_pwd.Location = new System.Drawing.Point(342, 374);
            this.checkBox1_pwd.Name = "checkBox1_pwd";
            this.checkBox1_pwd.Size = new System.Drawing.Size(174, 21);
            this.checkBox1_pwd.TabIndex = 13;
            this.checkBox1_pwd.Text = "Mostrar a palavra-passe";
            this.checkBox1_pwd.UseVisualStyleBackColor = false;
            this.checkBox1_pwd.CheckedChanged += new System.EventHandler(this.checkBox1_pwd_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ITICH.Properties.Resources.logotipo;
            this.pictureBox1.Location = new System.Drawing.Point(277, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Registo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(716, 479);
            this.Controls.Add(this.checkBox1_pwd);
            this.Controls.Add(this.textBox_pwd2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_registar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_pwd);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_contacto);
            this.Controls.Add(this.textBox_nomeEmpresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Registo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registo";
            this.Load += new System.EventHandler(this.Registo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_nomeEmpresa;
        private System.Windows.Forms.TextBox textBox_contacto;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_pwd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_registar;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.TextBox textBox_pwd2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1_pwd;
    }
}