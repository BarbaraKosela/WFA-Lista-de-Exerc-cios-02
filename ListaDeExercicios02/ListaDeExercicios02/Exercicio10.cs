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
    public partial class Exercicio10 : Form
    {
        int numero1 = 0, numero2 = 0, numero3 = 0, numero4 = 0;

        public Exercicio10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArmazenarInformacao();

            if ((numero1 == numero2) && (numero3 == numero4))
            {
                MessageBox.Show("Seus números formaram um retângulo!");
            }

            else if ((numero1 != numero3) && (numero4 == numero2))
            {
                MessageBox.Show("Seus números não formaram um retângulo");
            }

            else if ((numero1 == numero3) && (numero4 != numero2))
            {
                MessageBox.Show("Seus números não formaram um retângulo");
            }

            else if ((numero1 != numero3) && (numero2 != numero4))
            {
                MessageBox.Show("Seus números não formaram um retângulo");
            }

        }

        private void ArmazenarInformacao()
        {
            try
            {
                numero1 = Convert.ToInt32(TXTNUMERO01.Text);
            }

            catch
            {
                MessageBox.Show("Digite um número que seja real");
                TXTNUMERO01.Focus();
                return;
            }

            try
            {
                numero2 = Convert.ToInt32(TXTNUMERO2.Text);
            }

            catch
            {
                MessageBox.Show("Digite um número que seja real");
                TXTNUMERO2.Focus();
                return;
            }

            try
            {
                numero3 = Convert.ToInt32(TXTNUMERO3.Text);
            }

            catch
            {
                MessageBox.Show("Digite um número que seja real");
                TXTNUMERO3.Focus();
                return;
            }

            try
            {
                numero4 = Convert.ToInt32(TXTNUMERO4.Text);
            }

            catch
            {
                MessageBox.Show("Digite um número que seja real");
                TXTNUMERO4.Focus();
                return;
            }
        }


    }
}
