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
    public partial class Exercicio14 : Form
    {
        int numero1 = 0, numero2 = 0, numero3 = 0;
        public Exercicio14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArmazenarInformacao();

            if ((numero3 > numero1) && (numero3 < numero2))
            {

                MessageBox.Show(string.Format("Primeiro número: {0} \r\nSegundo número: {1} \r\nterceiro número: {2}", numero2, numero3, numero1));
                
            }

            else if ((numero2 > numero1) && (numero2 < numero3))
            {
                MessageBox.Show(string.Format("Primeiro número: {0} \r\nSegundo número: {1} \r\nterceiro número: {2}", numero3, numero2, numero1));
                
            }

            else if ((numero1 > numero2) && (numero3 < numero2))
            {
                MessageBox.Show(string.Format("Primeiro número: {0} \r\nSegundo número: {1} \r\nterceiro número: {2}", numero1, numero2, numero3));
               
            }

            else if ((numero1 > numero3) && (numero2 < numero3))
            {
                MessageBox.Show(string.Format("Primeiro número: {0} \r\nSegundo número: {1} \r\nterceiro número: {2}", numero1, numero3, numero2));
                
            }

            else
            {
                MessageBox.Show(string.Format("Primeiro número: {0} \r\nSegundo número: {1} \r\nterceiro número: {2}", numero3, numero1, numero2));
               
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

            try
            {
                numero3 = Convert.ToInt32(TXTNUMERO3.Text);
            }

            catch
            {
                MessageBox.Show("Digite um número real");
            }
        }
    }
}
