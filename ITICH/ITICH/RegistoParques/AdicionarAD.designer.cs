
namespace ITICH.RegistoParques
{
    partial class AdicionarAD
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
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.button_Confirmar = new System.Windows.Forms.Button();
            this.label_Descricao = new System.Windows.Forms.Label();
            this.textBox_AdicionarAD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancelar.Location = new System.Drawing.Point(116, 51);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 11;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            // 
            // button_Confirmar
            // 
            this.button_Confirmar.Location = new System.Drawing.Point(197, 51);
            this.button_Confirmar.Name = "button_Confirmar";
            this.button_Confirmar.Size = new System.Drawing.Size(75, 23);
            this.button_Confirmar.TabIndex = 10;
            this.button_Confirmar.Text = "Confirmar";
            this.button_Confirmar.UseVisualStyleBackColor = true;
            this.button_Confirmar.Click += new System.EventHandler(this.button_Confirmar_Click);
            // 
            // label_Descricao
            // 
            this.label_Descricao.AutoSize = true;
            this.label_Descricao.Location = new System.Drawing.Point(12, 9);
            this.label_Descricao.Name = "label_Descricao";
            this.label_Descricao.Size = new System.Drawing.Size(30, 13);
            this.label_Descricao.TabIndex = 9;
            this.label_Descricao.Text = "desc";
            // 
            // textBox_AdicionarAD
            // 
            this.textBox_AdicionarAD.Location = new System.Drawing.Point(15, 25);
            this.textBox_AdicionarAD.Name = "textBox_AdicionarAD";
            this.textBox_AdicionarAD.Size = new System.Drawing.Size(257, 20);
            this.textBox_AdicionarAD.TabIndex = 8;
            // 
            // AdicionarAD
            // 
            this.AcceptButton = this.button_Confirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancelar;
            this.ClientSize = new System.Drawing.Size(279, 81);
            this.ControlBox = false;
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.button_Confirmar);
            this.Controls.Add(this.label_Descricao);
            this.Controls.Add(this.textBox_AdicionarAD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdicionarAD";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdicionarAD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.Button button_Confirmar;
        private System.Windows.Forms.Label label_Descricao;
        private System.Windows.Forms.TextBox textBox_AdicionarAD;
    }
}