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
    public partial class Exercicio07 : Form
    {
        int numero = 0;
        public Exercicio07()
        {
            InitializeComponent();
        }

        private void BTNDIFERENTE_Click(object sender, EventArgs e)
        {
            ArmazenarDados();

            if (RBPARIMPARNEUTRO.Checked)
            {
                ParImparNeutro();
            }

            else if (RBPOSITIVONEGATIVO.Checked)
            {
                PositivoNegativo();
            }

            else if (RBMAIORDEZ.Checked)
            {
                MaiorQueDez();
            }

            else if (RBMENORIGUAL50.Checked)
            {
                MenorIgualCinquenta();
            }

            else if (RBMENORMENOS10.Checked)
            {
                MenorMenosDez();
            }

            else if (RBIGUALMENOR30.Checked)
            {
                MenorIgualTrinta();
            }

            else if (RBDIFERENTE1.Checked)
            {
                DiferenteUm();
            }
        }

        private void ArmazenarDados()
        {
            try
            {
                numero = Convert.ToInt32(TXTNUMERO.Text);
            }

            catch
            {
                MessageBox.Show("Favor digite um número que seja real");
            }
        }

        public void ParImparNeutro()
        {
            if (numero % 2 != 0)
            {
                MessageBox.Show("Seu número é ímpar");
            }

            else if (numero == 0)
            {
                MessageBox.Show("Seu número é neutro");
            }

            else if (numero % 2 != 1)
            {
                MessageBox.Show("Seu número é par");
            }
        }

        public void PositivoNegativo()
        {

            if (numero < 0)
            {
                MessageBox.Show("Seu número é negativo");
            }

            else if (numero > 0)
            {
                MessageBox.Show("Seu número é positivo");
            }

            else
            {
                MessageBox.Show("Seu número é neutro");
            }
        }

        public void MaiorQueDez()
        {
            if (numero > 10)
            {
                MessageBox.Show("Seu número é maior que 10");
            }

            else if (numero < 10)
            {
                MessageBox.Show("Seu número é menor que 10");
            }

            else
            {
                MessageBox.Show("Seu número é igual a 10");
            }
        }

        public void MenorIgualCinquenta()
        {
            if (numero < 50)
            {
                MessageBox.Show("Seu número é menor que 50");
            }

            else if (numero > 50)
            {
                MessageBox.Show("Seu número é maior que 50");
            }

            else if (numero == 50)
            {
                MessageBox.Show("Seu número é igual a 50");
            }
        }

        public void MenorMenosDez()
        {
            if (numero < -10)
            {
                MessageBox.Show("Seu número é menor que -10");
            }

            else if (numero > -10)
            {
                MessageBox.Show("Seu número é maior que -10");
            }

            else
            {
                MessageBox.Show("Seu número é igual a -10");
            }
        }

        public void MenorIgualTrinta()
        {
            if (numero < 30)
            {
                MessageBox.Show("Seu número é menor que 30");
            }

            else if (numero > 30)
            {
                MessageBox.Show("Seu número é maior que 30");
            }

            else if (numero == 30)
            {
                MessageBox.Show("Seu número é igual a 30");
            }
        }

        public void DiferenteUm()
        {
            if (numero != 1)
            {
                MessageBox.Show("Seu número é diferente de 1");
            }
            else if (numero == 1)
            {
                MessageBox.Show("Seu número é igual a 1");
            }

        }

    }
}
