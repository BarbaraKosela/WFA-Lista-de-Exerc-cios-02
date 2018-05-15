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
    public partial class Exercicio02 : Form
    {
        int numero = 0;
        public Exercicio02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArmazenarNumero();
            if (numero < 0)
            {
                MessageBox.Show("Parabéns, seu número é negativo!");
            }

            else if (numero > 0)
            {
                MessageBox.Show("Não, seu número não é negativo :C");
            }
        }

        private void ArmazenarNumero()
        {
            try
            {
            numero = Convert.ToInt32(TXTNUMERO.Text);

            }
            catch
            {
                MessageBox.Show("Você pode apenas digitar números reais neste campo, tente novamente");
                TXTNUMERO.Focus();
                return; 
            }

        }
    }
}
