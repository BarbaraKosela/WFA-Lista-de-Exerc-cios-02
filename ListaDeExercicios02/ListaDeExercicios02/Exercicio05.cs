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
    public partial class Exercicio05 : Form
    {
        int numero = 0;
        public Exercicio05()
        {
            InitializeComponent();
        }

        private void BTNIMPAR_Click(object sender, EventArgs e)
        {
            ArmazenarNumero();
            if (numero % 2 != 0)
            {
                MessageBox.Show("Parabéns, seu número é ímpar! :D");
            }

            else if (numero % 2 == 0)
            {
                MessageBox.Show("Ops! Seu número é par");
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
                
            }
        }
        }
    }

