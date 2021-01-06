namespace ITICH
{
    partial class Simulacao
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
            this.button1_back4 = new System.Windows.Forms.Button();
            this.label1Simulacao = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1_back4);
            this.panel1.Controls.Add(this.label1Simulacao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 67);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.button1_back4.TabIndex = 12;
            this.button1_back4.UseVisualStyleBackColor = false;
            this.button1_back4.Click += new System.EventHandler(this.button1_back4_Click);
            // 
            // label1Simulacao
            // 
            this.label1Simulacao.AutoSize = true;
            this.label1Simulacao.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Simulacao.ForeColor = System.Drawing.Color.White;
            this.label1Simulacao.Location = new System.Drawing.Point(137, 11);
            this.label1Simulacao.Name = "label1Simulacao";
            this.label1Simulacao.Size = new System.Drawing.Size(152, 38);
            this.label1Simulacao.TabIndex = 0;
            this.label1Simulacao.Text = "Simulação";
            this.label1Simulacao.Click += new System.EventHandler(this.label1Simulacao_Click);
            // 
            // Simulacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1924, 903);
            this.Controls.Add(this.panel1);
            this.Name = "Simulacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulação";
            this.Load += new System.EventHandler(this.Simulacao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1Simulacao;
        private System.Windows.Forms.Button button1_back4;
    }
}