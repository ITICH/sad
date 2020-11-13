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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_registar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.textBox_pwd2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1_pwd = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contacto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Palavra - Passe";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_nomeEmpresa
            // 
            this.textBox_nomeEmpresa.Location = new System.Drawing.Point(312, 197);
            this.textBox_nomeEmpresa.Name = "textBox_nomeEmpresa";
            this.textBox_nomeEmpresa.Size = new System.Drawing.Size(172, 22);
            this.textBox_nomeEmpresa.TabIndex = 4;
            // 
            // textBox_contacto
            // 
            this.textBox_contacto.Location = new System.Drawing.Point(312, 235);
            this.textBox_contacto.Name = "textBox_contacto";
            this.textBox_contacto.Size = new System.Drawing.Size(172, 22);
            this.textBox_contacto.TabIndex = 5;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(312, 273);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(172, 22);
            this.textBox_email.TabIndex = 6;
            this.textBox_email.TextChanged += new System.EventHandler(this.textBox_email_TextChanged);
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.Location = new System.Drawing.Point(312, 313);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.Size = new System.Drawing.Size(172, 22);
            this.textBox_pwd.TabIndex = 7;
            this.textBox_pwd.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ITICH.Properties.Resources.logotipo;
            this.pictureBox1.Location = new System.Drawing.Point(277, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button_registar
            // 
            this.button_registar.Location = new System.Drawing.Point(274, 423);
            this.button_registar.Name = "button_registar";
            this.button_registar.Size = new System.Drawing.Size(75, 28);
            this.button_registar.TabIndex = 9;
            this.button_registar.Text = "Registar";
            this.button_registar.UseVisualStyleBackColor = true;
            this.button_registar.Click += new System.EventHandler(this.button_registar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(374, 423);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(79, 28);
            this.button_cancelar.TabIndex = 10;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // textBox_pwd2
            // 
            this.textBox_pwd2.Location = new System.Drawing.Point(312, 353);
            this.textBox_pwd2.Name = "textBox_pwd2";
            this.textBox_pwd2.Size = new System.Drawing.Size(172, 22);
            this.textBox_pwd2.TabIndex = 12;
            this.textBox_pwd2.UseSystemPasswordChar = true;
            this.textBox_pwd2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Repita a palavra-passe";
            // 
            // checkBox1_pwd
            // 
            this.checkBox1_pwd.AutoSize = true;
            this.checkBox1_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.checkBox1_pwd.Location = new System.Drawing.Point(342, 384);
            this.checkBox1_pwd.Name = "checkBox1_pwd";
            this.checkBox1_pwd.Size = new System.Drawing.Size(142, 17);
            this.checkBox1_pwd.TabIndex = 13;
            this.checkBox1_pwd.Text = "Mostrar a palavra-passe";
            this.checkBox1_pwd.UseVisualStyleBackColor = true;
            this.checkBox1_pwd.CheckedChanged += new System.EventHandler(this.checkBox1_pwd_CheckedChanged);
            // 
            // Registo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "Registo";
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