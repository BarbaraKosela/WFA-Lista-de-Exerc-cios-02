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
    public partial class Exercicio06 : Form
    {
        int numero = 0;
        public Exercicio06()
        {
            InitializeComponent();
        }

        private void BTNDIFERENTE_Click(object sender, EventArgs e)
        {
            ArmazenarDados();
            if (numero == 1)
            {
                MessageBox.Show("Seu número é igual a 1");
            }

            else if (numero != 1)
            {
                MessageBox.Show("Seu número é diferente de 1");
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
                MessageBox.Show("Por favor, digite um número que seja real");
            }
        }
    }
}
