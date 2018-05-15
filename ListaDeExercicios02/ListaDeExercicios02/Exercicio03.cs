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
    public partial class Exercicio03 : Form
    {
        int numero = 0, numero1 = 0, numero2 = 0;
        public Exercicio03()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void BTNCHECAR_Click(object sender, EventArgs e)
        {
            ArmazenarNumero();
            if (numero == 1)
            {
                double soma = numero1 + numero2;
                MessageBox.Show("Sua soma é: " + soma);
            }

            else if (numero == 2)
            {
                double subtracao = numero1 - numero2;
                MessageBox.Show("Sua subtração é: " + subtracao);
            }

            else if (numero == 4)
            {
                double divisao = numero1 / numero2;
                MessageBox.Show("Sua divisão é: " + divisao);

            }

            else if (numero == 3)
            {
                double multiplicacao = numero1 * numero2;
                MessageBox.Show("Sua multiplicação é: " + multiplicacao);
            }
            else
            {
                MessageBox.Show("Você não digitou nenhum número referente ao menu, faça isto por favor!");
            }

            
        }

        private void ArmazenarNumero()
        {


            try
            {
                numero = Convert.ToInt32(TXTNUMEROMENU.Text);

            }

            catch
            {
                TXTNUMEROMENU.Focus();
                return;
            }

            try
            {
                numero1 = Convert.ToInt32(TXTNUMERO1.Text);
            }
            catch
            {
                MessageBox.Show("Por favor, digite um número real");
                TXTNUMERO1.Focus();
                return;
            }

            try
            {
                numero2 = Convert.ToInt32(TXTNUMERO2.Text);
            }

            catch
            {
                MessageBox.Show("Por favor digite um número real");
                TXTNUMERO2.Focus();
                return;
            }
        }
    }
}
