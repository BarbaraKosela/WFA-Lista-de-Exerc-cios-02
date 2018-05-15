namespace ListaDeExercicios02
{
    partial class Principal
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
            this.BTNEXERCICIO01 = new System.Windows.Forms.Button();
            this.BTNEXERCICIO02 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNEXERCICIO01
            // 
            this.BTNEXERCICIO01.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEXERCICIO01.Location = new System.Drawing.Point(12, 12);
            this.BTNEXERCICIO01.Name = "BTNEXERCICIO01";
            this.BTNEXERCICIO01.Size = new System.Drawing.Size(153, 64);
            this.BTNEXERCICIO01.TabIndex = 0;
            this.BTNEXERCICIO01.Text = "EXERCÍCIO 01";
            this.BTNEXERCICIO01.UseVisualStyleBackColor = true;
            this.BTNEXERCICIO01.Click += new System.EventHandler(this.BTNEXERCICIO01_Click);
            // 
            // BTNEXERCICIO02
            // 
            this.BTNEXERCICIO02.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEXERCICIO02.Location = new System.Drawing.Point(12, 82);
            this.BTNEXERCICIO02.Name = "BTNEXERCICIO02";
            this.BTNEXERCICIO02.Size = new System.Drawing.Size(153, 64);
            this.BTNEXERCICIO02.TabIndex = 1;
            this.BTNEXERCICIO02.Text = "EXERCÍCIO 02";
            this.BTNEXERCICIO02.UseVisualStyleBackColor = true;
            this.BTNEXERCICIO02.Click += new System.EventHandler(this.BTNEXERCICIO02_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 428);
            this.Controls.Add(this.BTNEXERCICIO02);
            this.Controls.Add(this.BTNEXERCICIO01);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNEXERCICIO01;
        private System.Windows.Forms.Button BTNEXERCICIO02;
    }
}

