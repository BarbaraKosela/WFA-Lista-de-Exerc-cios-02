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
    public partial class Exercicio04 : Form
    {
        int numero = 0;

        public Exercicio04()
        {
            InitializeComponent();
        }

        private void BTNPAR_Click(object sender, EventArgs e)
        {
            ArmazenarNumero();
            if (numero % 2 == 0)
            {
                MessageBox.Show("Parabéns, seu número é par! :D");
            }

            else if (numero % 2 != 0)
            {
                MessageBox.Show("Ops! Seu número é impar");
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
                MessageBox.Show("Por favor, digite um número real");
                TXTNUMERO.Focus();
                return;
            }
        }
    }
}
