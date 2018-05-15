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
    public partial class Exercicio01 : Form
    {
        int numero = 0;
        public Exercicio01()
        {
            InitializeComponent();
        }

        private void BTNPOSITIVO_Click(object sender, EventArgs e)
        {
            ArmazenarNumero();
            if (numero > 0)
            {
                MessageBox.Show("Sim, ele é positivo!");
            }

            else if (numero < 0)
            {
                MessageBox.Show("Não, seu número não é positivo");
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
                MessageBox.Show("Por favor, digite apenas números reais neste campo");
            }
        }
    }
}
