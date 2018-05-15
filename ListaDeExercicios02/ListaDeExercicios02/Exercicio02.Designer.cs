namespace ListaDeExercicios02
{
    partial class Exercicio02
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
            this.button1 = new System.Windows.Forms.Button();
            this.TXTNUMERO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIGITE UM NÚMERO DE SUA ESCOLHA:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(28, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "DESCUBRA SE SEU NÚMERO É NEGATIVO OU NÃO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TXTNUMERO
            // 
            this.TXTNUMERO.Location = new System.Drawing.Point(28, 33);
            this.TXTNUMERO.Name = "TXTNUMERO";
            this.TXTNUMERO.Size = new System.Drawing.Size(263, 20);
            this.TXTNUMERO.TabIndex = 2;
            // 
            // Exercicio02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 133);
            this.Controls.Add(this.TXTNUMERO);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TXTNUMERO;
    }
}