using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroAplicativo
{
    public partial class FrmTabuada : Form
    {
        public FrmTabuada()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
            
        {
            MessageBox.Show("Você precisa digitar o número para calcular uma tabuada", "Informação,");
        }
            else
        {
            double numero, resultado;
            numero = double.Parse(txtNumero.Text); //conversão de string da textbox dos números pra double.

            for (int i = 0; i <=10; i++)
            {
                resultado = numero * i;
                txtTabuada.Text += numero + "x" + i + "=" + resultado + "\r\n";
            }
                
        } Desativado devido á erros estranhos. Possivelmente porque não defini txtTabuada? */

        {
            double numero, resultado;
            numero = double.Parse(txtNumero.Text); //conversão de string da textbox dos números pra double.

            for (int i = 0; i <=10; i++)
            {
                resultado = numero * i;
                txtTabuada.Text += numero + "x" + i + "=" + resultado + "\r\n";
            }
                
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = ""; //apaga a txtbox de número
            txtTabuada.Text = "";
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTabuada_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
