namespace ListaDeExercicios02
{
    partial class Exercicio05
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
            this.BTNIMPAR = new System.Windows.Forms.Button();
            this.TXTNUMERO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNIMPAR
            // 
            this.BTNIMPAR.Font = new System.Drawing.Font("Square721 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNIMPAR.Location = new System.Drawing.Point(35, 57);
            this.BTNIMPAR.Name = "BTNIMPAR";
            this.BTNIMPAR.Size = new System.Drawing.Size(231, 43);
            this.BTNIMPAR.TabIndex = 5;
            this.BTNIMPAR.Text = "CHECAR SE SEU NÚMERO É ÍMPAR OU NÃO";
            this.BTNIMPAR.UseVisualStyleBackColor = true;
            this.BTNIMPAR.Click += new System.EventHandler(this.BTNIMPAR_Click);
            // 
            // TXTNUMERO
            // 
            this.TXTNUMERO.Location = new System.Drawing.Point(15, 31);
            this.TXTNUMERO.Name = "TXTNUMERO";
            this.TXTNUMERO.Size = new System.Drawing.Size(275, 20);
            this.TXTNUMERO.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "DIGITE UM NÚMERO ABAIXO: ";
            // 
            // Exercicio05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 107);
            this.Controls.Add(this.BTNIMPAR);
            this.Controls.Add(this.TXTNUMERO);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio05";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNIMPAR;
        private System.Windows.Forms.TextBox TXTNUMERO;
        private System.Windows.Forms.Label label1;
    }
}