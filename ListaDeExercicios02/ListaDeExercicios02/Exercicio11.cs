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
    public partial class Exercicio11 : Form
    {   string nomeAluno = "";
        double nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0, nota5 = 0;
        public Exercicio11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = "";
            ArmazenarInformacoes();

            double media = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

            if ((media >= 0) && (media <= 5.99))
            {
                texto = texto + string.Format("Você foi reprovado, com média de: " + media);
                TXTRESULTADO.Text = texto;
            }

            else if ((media >= 6) && (media <= 7.99))
            {
                texto = texto + string.Format("Você passará pela recuperação, com média de: " + media);
                TXTRESULTADO.Text = texto;
            }

            else if (media >= 8)
            {
                texto = texto + string.Format("Você passou! Com a média de: " + media);
                TXTRESULTADO.Text = texto;
            }
        }

        private void ArmazenarInformacoes()
        {
            try
            {
                nomeAluno = TXTNOMEALUNO.Text;
            }
            catch
            {
                MessageBox.Show("Digite um nome válido, com apenas letras inseridas");
            }

            try
            {
                nota1 = Convert.ToDouble(TXTNOTA1.Text);

            }

            catch
            {
                MessageBox.Show("Digite apenas números reais");
            }

            try
            {
                nota2 = Convert.ToDouble(TXTNOTA2.Text);
            }

            catch
            {
                MessageBox.Show("Digite apenas números reais");
            }

            try
            {
                nota3 = Convert.ToDouble(TXTNOTA3.Text);
            }
            catch
            {
                MessageBox.Show("Digite apenas números reais");
            }

            try
            {
                nota4 = Convert.ToDouble(TXTNOTA4.Text);
            }
            catch
            {
                MessageBox.Show("Digite apenas números reais");
            }
            
            try
            {
                nota5 = Convert.ToDouble(TXTNOTA5.Text);
            }
            catch
            {
                MessageBox.Show("Digite apenas números reais");
            }


        }
    }
}
