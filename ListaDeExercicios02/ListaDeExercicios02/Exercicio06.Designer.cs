namespace ListaDeExercicios02
{
    partial class Exercicio06
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
            this.BTNDIFERENTE = new System.Windows.Forms.Button();
            this.TXTNUMERO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNDIFERENTE
            // 
            this.BTNDIFERENTE.Font = new System.Drawing.Font("Square721 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDIFERENTE.Location = new System.Drawing.Point(34, 57);
            this.BTNDIFERENTE.Name = "BTNDIFERENTE";
            this.BTNDIFERENTE.Size = new System.Drawing.Size(231, 43);
            this.BTNDIFERENTE.TabIndex = 8;
            this.BTNDIFERENTE.Text = "CHECAR SE SEU NÚMERO É DIFERENTE DE 1 OU NÃO";
            this.BTNDIFERENTE.UseVisualStyleBackColor = true;
            this.BTNDIFERENTE.Click += new System.EventHandler(this.BTNDIFERENTE_Click);
            // 
            // TXTNUMERO
            // 
            this.TXTNUMERO.Location = new System.Drawing.Point(14, 31);
            this.TXTNUMERO.Name = "TXTNUMERO";
            this.TXTNUMERO.Size = new System.Drawing.Size(275, 20);
            this.TXTNUMERO.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "DIGITE UM NÚMERO ABAIXO: ";
            // 
            // Exercicio06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 110);
            this.Controls.Add(this.BTNDIFERENTE);
            this.Controls.Add(this.TXTNUMERO);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio06";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio06";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNDIFERENTE;
        private System.Windows.Forms.TextBox TXTNUMERO;
        private System.Windows.Forms.Label label1;
    }
}