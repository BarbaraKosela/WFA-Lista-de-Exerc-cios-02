namespace ListaDeExercicios02
{
    partial class Exercicio01
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
            this.TXTNUMERO = new System.Windows.Forms.TextBox();
            this.BTNPOSITIVO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIGITE UM NÚMERO DE SUA ESCOLHA:";
            // 
            // TXTNUMERO
            // 
            this.TXTNUMERO.Location = new System.Drawing.Point(55, 32);
            this.TXTNUMERO.Name = "TXTNUMERO";
            this.TXTNUMERO.Size = new System.Drawing.Size(279, 20);
            this.TXTNUMERO.TabIndex = 1;
            // 
            // BTNPOSITIVO
            // 
            this.BTNPOSITIVO.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPOSITIVO.Location = new System.Drawing.Point(12, 58);
            this.BTNPOSITIVO.Name = "BTNPOSITIVO";
            this.BTNPOSITIVO.Size = new System.Drawing.Size(374, 48);
            this.BTNPOSITIVO.TabIndex = 2;
            this.BTNPOSITIVO.Text = "DESCUBRA SE SEU NÚMERO É OU NÃO POSITIVO";
            this.BTNPOSITIVO.UseVisualStyleBackColor = true;
            this.BTNPOSITIVO.Click += new System.EventHandler(this.BTNPOSITIVO_Click);
            // 
            // Exercicio01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 116);
            this.Controls.Add(this.BTNPOSITIVO);
            this.Controls.Add(this.TXTNUMERO);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTNUMERO;
        private System.Windows.Forms.Button BTNPOSITIVO;
    }
}