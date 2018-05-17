using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeExercicios02
{
    public partial class Exercicio13 : Form
    {
        int numero1 = 0, numero2 = 0;
        public Exercicio13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ArmazenarInformacao();
            if (numero1 < numero2)
            {
                MessageBox.Show("O primeiro número é menor que o segundo número");

            }

            else if (numero2 < numero1)
            {
                MessageBox.Show("Segundo número é menor que o primeiro número");
            }
        }

        private void ArmazenarInformacao()
        {
            try
            {
                numero1 = Convert.ToInt32(txtNumero1.Text);
            }

            catch
            {
                MessageBox.Show("Digite um número real");
            }

            try
            {
                numero2 = Convert.ToInt32(txtNumero2.Text);
            }
            catch
            {
                MessageBox.Show("Digite um número real");
            }
        }
    }
}
