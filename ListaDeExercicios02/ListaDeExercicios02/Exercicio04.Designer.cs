﻿namespace ListaDeExercicios02
{
    partial class Exercicio04
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
            this.BTNPAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIGITE UM NÚMERO ABAIXO: ";
            // 
            // TXTNUMERO
            // 
            this.TXTNUMERO.Location = new System.Drawing.Point(12, 31);
            this.TXTNUMERO.Name = "TXTNUMERO";
            this.TXTNUMERO.Size = new System.Drawing.Size(275, 20);
            this.TXTNUMERO.TabIndex = 1;
            // 
            // BTNPAR
            // 
            this.BTNPAR.Font = new System.Drawing.Font("Square721 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPAR.Location = new System.Drawing.Point(32, 57);
            this.BTNPAR.Name = "BTNPAR";
            this.BTNPAR.Size = new System.Drawing.Size(231, 43);
            this.BTNPAR.TabIndex = 2;
            this.BTNPAR.Text = "CHECAR SE SEU NÚMERO É PAR OU NÃO";
            this.BTNPAR.UseVisualStyleBackColor = true;
            this.BTNPAR.Click += new System.EventHandler(this.BTNPAR_Click);
            // 
            // Exercicio04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 110);
            this.Controls.Add(this.BTNPAR);
            this.Controls.Add(this.TXTNUMERO);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio04";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio04";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTNUMERO;
        private System.Windows.Forms.Button BTNPAR;
    }
}