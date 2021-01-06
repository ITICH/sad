namespace ITICH
{
    partial class EnviarPedidoEmail
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_emailDe = new System.Windows.Forms.TextBox();
            this.textBox_emailPara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1_back2 = new System.Windows.Forms.Button();
            this.button_enviarPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 220);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(628, 171);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "De:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_emailDe
            // 
            this.textBox_emailDe.Location = new System.Drawing.Point(124, 115);
            this.textBox_emailDe.Name = "textBox_emailDe";
            this.textBox_emailDe.Size = new System.Drawing.Size(573, 22);
            this.textBox_emailDe.TabIndex = 3;
            this.textBox_emailDe.TextChanged += new System.EventHandler(this.textBox_emailDe_TextChanged);
            // 
            // textBox_emailPara
            // 
            this.textBox_emailPara.Location = new System.Drawing.Point(124, 160);
            this.textBox_emailPara.Name = "textBox_emailPara";
            this.textBox_emailPara.Size = new System.Drawing.Size(573, 22);
            this.textBox_emailPara.TabIndex = 4;
            this.textBox_emailPara.TextChanged += new System.EventHandler(this.textBox_emailPara_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Para:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(64, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Pedido:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(64, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Envie o pedido para adicionar novo parque";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ITICH.Properties.Resources.mail3;
            this.pictureBox1.Location = new System.Drawing.Point(501, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // button1_back2
            // 
            this.button1_back2.BackColor = System.Drawing.Color.Transparent;
            this.button1_back2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1_back2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1_back2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_back2.Image = global::ITICH.Properties.Resources.undo2;
            this.button1_back2.Location = new System.Drawing.Point(12, 12);
            this.button1_back2.Name = "button1_back2";
            this.button1_back2.Size = new System.Drawing.Size(47, 37);
            this.button1_back2.TabIndex = 11;
            this.button1_back2.UseVisualStyleBackColor = false;
            this.button1_back2.Click += new System.EventHandler(this.button1_back2_Click);
            // 
            // button_enviarPedido
            // 
            this.button_enviarPedido.BackColor = System.Drawing.Color.White;
            this.button_enviarPedido.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_enviarPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_enviarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_enviarPedido.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_enviarPedido.Image = global::ITICH.Properties.Resources.paper_plane;
            this.button_enviarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_enviarPedido.Location = new System.Drawing.Point(556, 414);
            this.button_enviarPedido.Name = "button_enviarPedido";
            this.button_enviarPedido.Size = new System.Drawing.Size(141, 39);
            this.button_enviarPedido.TabIndex = 1;
            this.button_enviarPedido.Text = "Enviar Pedido";
            this.button_enviarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_enviarPedido.UseVisualStyleBackColor = false;
            this.button_enviarPedido.Click += new System.EventHandler(this.button1_Click);
            // 
            // EnviarPedidoEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(760, 477);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1_back2);
            this.Controls.Add(this.textBox_emailPara);
            this.Controls.Add(this.textBox_emailDe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_enviarPedido);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Name = "EnviarPedidoEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedir para adicionar novo parque";
            this.Load += new System.EventHandler(this.EnviarPedidoEmail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_enviarPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_emailDe;
        private System.Windows.Forms.TextBox textBox_emailPara;
        private System.Windows.Forms.Button button1_back2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}