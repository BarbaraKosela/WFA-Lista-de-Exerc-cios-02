namespace ListaDeExercicios02
{
    partial class Exercicio07
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
            this.BTNCHECAR = new System.Windows.Forms.Button();
            this.TXTNUMERO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RBPARIMPARNEUTRO = new System.Windows.Forms.RadioButton();
            this.RBPOSITIVONEGATIVO = new System.Windows.Forms.RadioButton();
            this.RBMAIORDEZ = new System.Windows.Forms.RadioButton();
            this.RBMENORIGUAL50 = new System.Windows.Forms.RadioButton();
            this.RBMENORMENOS10 = new System.Windows.Forms.RadioButton();
            this.RBIGUALMENOR30 = new System.Windows.Forms.RadioButton();
            this.RBDIFERENTE1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // BTNCHECAR
            // 
            this.BTNCHECAR.Font = new System.Drawing.Font("Square721 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCHECAR.Location = new System.Drawing.Point(34, 230);
            this.BTNCHECAR.Name = "BTNCHECAR";
            this.BTNCHECAR.Size = new System.Drawing.Size(231, 43);
            this.BTNCHECAR.TabIndex = 11;
            this.BTNCHECAR.Text = "CHECAR RESULTADOS";
            this.BTNCHECAR.UseVisualStyleBackColor = true;
            this.BTNCHECAR.Click += new System.EventHandler(this.BTNDIFERENTE_Click);
            // 
            // TXTNUMERO
            // 
            this.TXTNUMERO.Location = new System.Drawing.Point(11, 31);
            this.TXTNUMERO.Name = "TXTNUMERO";
            this.TXTNUMERO.Size = new System.Drawing.Size(275, 20);
            this.TXTNUMERO.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "DIGITE UM NÚMERO ABAIXO: ";
            // 
            // RBPARIMPARNEUTRO
            // 
            this.RBPARIMPARNEUTRO.AutoSize = true;
            this.RBPARIMPARNEUTRO.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBPARIMPARNEUTRO.Location = new System.Drawing.Point(12, 57);
            this.RBPARIMPARNEUTRO.Name = "RBPARIMPARNEUTRO";
            this.RBPARIMPARNEUTRO.Size = new System.Drawing.Size(290, 20);
            this.RBPARIMPARNEUTRO.TabIndex = 12;
            this.RBPARIMPARNEUTRO.TabStop = true;
            this.RBPARIMPARNEUTRO.Text = "CHECAR SE É PAR ÍMPAR OU NEUTRO";
            this.RBPARIMPARNEUTRO.UseVisualStyleBackColor = true;
            // 
            // RBPOSITIVONEGATIVO
            // 
            this.RBPOSITIVONEGATIVO.AutoSize = true;
            this.RBPOSITIVONEGATIVO.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBPOSITIVONEGATIVO.Location = new System.Drawing.Point(12, 80);
            this.RBPOSITIVONEGATIVO.Name = "RBPOSITIVONEGATIVO";
            this.RBPOSITIVONEGATIVO.Size = new System.Drawing.Size(293, 20);
            this.RBPOSITIVONEGATIVO.TabIndex = 13;
            this.RBPOSITIVONEGATIVO.TabStop = true;
            this.RBPOSITIVONEGATIVO.Text = "CHECAR SE É POSITIVO OU NEGATIVO";
            this.RBPOSITIVONEGATIVO.UseVisualStyleBackColor = true;
            // 
            // RBMAIORDEZ
            // 
            this.RBMAIORDEZ.AutoSize = true;
            this.RBMAIORDEZ.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBMAIORDEZ.Location = new System.Drawing.Point(12, 103);
            this.RBMAIORDEZ.Name = "RBMAIORDEZ";
            this.RBMAIORDEZ.Size = new System.Drawing.Size(253, 20);
            this.RBMAIORDEZ.TabIndex = 14;
            this.RBMAIORDEZ.TabStop = true;
            this.RBMAIORDEZ.Text = "CHECAR SE É MAIOR DO QUE 10";
            this.RBMAIORDEZ.UseVisualStyleBackColor = true;
            // 
            // RBMENORIGUAL50
            // 
            this.RBMENORIGUAL50.AutoSize = true;
            this.RBMENORIGUAL50.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBMENORIGUAL50.Location = new System.Drawing.Point(12, 126);
            this.RBMENORIGUAL50.Name = "RBMENORIGUAL50";
            this.RBMENORIGUAL50.Size = new System.Drawing.Size(287, 20);
            this.RBMENORIGUAL50.TabIndex = 15;
            this.RBMENORIGUAL50.TabStop = true;
            this.RBMENORIGUAL50.Text = "CHECAR SE É MENOR OU IGUAL A 50";
            this.RBMENORIGUAL50.UseVisualStyleBackColor = true;
            // 
            // RBMENORMENOS10
            // 
            this.RBMENORMENOS10.AutoSize = true;
            this.RBMENORMENOS10.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBMENORMENOS10.Location = new System.Drawing.Point(12, 152);
            this.RBMENORMENOS10.Name = "RBMENORMENOS10";
            this.RBMENORMENOS10.Size = new System.Drawing.Size(262, 20);
            this.RBMENORMENOS10.TabIndex = 16;
            this.RBMENORMENOS10.TabStop = true;
            this.RBMENORMENOS10.Text = "CHECAR SE É MENOR DO QUE -10";
            this.RBMENORMENOS10.UseVisualStyleBackColor = true;
            // 
            // RBIGUALMENOR30
            // 
            this.RBIGUALMENOR30.AutoSize = true;
            this.RBIGUALMENOR30.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBIGUALMENOR30.Location = new System.Drawing.Point(11, 178);
            this.RBIGUALMENOR30.Name = "RBIGUALMENOR30";
            this.RBIGUALMENOR30.Size = new System.Drawing.Size(287, 20);
            this.RBIGUALMENOR30.TabIndex = 17;
            this.RBIGUALMENOR30.TabStop = true;
            this.RBIGUALMENOR30.Text = "CHECAR SE É MENOR OU IGUAL A 30";
            this.RBIGUALMENOR30.UseVisualStyleBackColor = true;
            // 
            // RBDIFERENTE1
            // 
            this.RBDIFERENTE1.AutoSize = true;
            this.RBDIFERENTE1.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBDIFERENTE1.Location = new System.Drawing.Point(11, 204);
            this.RBDIFERENTE1.Name = "RBDIFERENTE1";
            this.RBDIFERENTE1.Size = new System.Drawing.Size(240, 20);
            this.RBDIFERENTE1.TabIndex = 18;
            this.RBDIFERENTE1.TabStop = true;
            this.RBDIFERENTE1.Text = "CHECAR SE É DIFERENTE DE 1";
            this.RBDIFERENTE1.UseVisualStyleBackColor = true;
            // 
            // Exercicio07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 280);
            this.Controls.Add(this.RBDIFERENTE1);
            this.Controls.Add(this.RBIGUALMENOR30);
            this.Controls.Add(this.RBMENORMENOS10);
            this.Controls.Add(this.RBMENORIGUAL50);
            this.Controls.Add(this.RBMAIORDEZ);
            this.Controls.Add(this.RBPOSITIVONEGATIVO);
            this.Controls.Add(this.RBPARIMPARNEUTRO);
            this.Controls.Add(this.BTNCHECAR);
            this.Controls.Add(this.TXTNUMERO);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio07";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio07";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNCHECAR;
        private System.Windows.Forms.TextBox TXTNUMERO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RBPARIMPARNEUTRO;
        private System.Windows.Forms.RadioButton RBPOSITIVONEGATIVO;
        private System.Windows.Forms.RadioButton RBMAIORDEZ;
        private System.Windows.Forms.RadioButton RBMENORIGUAL50;
        private System.Windows.Forms.RadioButton RBMENORMENOS10;
        private System.Windows.Forms.RadioButton RBIGUALMENOR30;
        private System.Windows.Forms.RadioButton RBDIFERENTE1;
    }
}