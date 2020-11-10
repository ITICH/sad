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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contacto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Palavra - Passe";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_nomeEmpresa
            // 
            this.textBox_nomeEmpresa.Location = new System.Drawing.Point(367, 221);
            this.textBox_nomeEmpresa.Name = "textBox_nomeEmpresa";
            this.textBox_nomeEmpresa.Size = new System.Drawing.Size(100, 22);
            this.textBox_nomeEmpresa.TabIndex = 4;
            // 
            // textBox_contacto
            // 
            this.textBox_contacto.Location = new System.Drawing.Point(367, 259);
            this.textBox_contacto.Name = "textBox_contacto";
            this.textBox_contacto.Size = new System.Drawing.Size(100, 22);
            this.textBox_contacto.TabIndex = 5;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(367, 297);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(100, 22);
            this.textBox_email.TabIndex = 6;
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.Location = new System.Drawing.Point(367, 337);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.Size = new System.Drawing.Size(100, 22);
            this.textBox_pwd.TabIndex = 7;
            this.textBox_pwd.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ITICH.Properties.Resources.logotipo;
            this.pictureBox1.Location = new System.Drawing.Point(318, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button_registar
            // 
            this.button_registar.Location = new System.Drawing.Point(379, 385);
            this.button_registar.Name = "button_registar";
            this.button_registar.Size = new System.Drawing.Size(75, 28);
            this.button_registar.TabIndex = 9;
            this.button_registar.Text = "Registar";
            this.button_registar.UseVisualStyleBackColor = true;
            // 
            // Registo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}