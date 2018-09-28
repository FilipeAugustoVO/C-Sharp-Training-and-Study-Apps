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

        private void textoVazioOuBranco()
        {
            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                MessageBox.Show("Você precisa digitar o número para calcular uma tabuada");
            }
        }



        private void btnCalcular_Click(object sender, EventArgs e) //botão que faz o calculo
        {
            double numero, resultado;
            numero = double.Parse(txtNumero.Text); //conversão de string da textbox dos números pra double.

            for (int i = 0; i <=10; i++) //repete a conta dez vezes, mostrando dez vezes a tabuada do numero digitado
            {
                resultado = numero * i; //resultado da tabuada é igual á numero digitado no txtNumero * variável i.
                txtTabuada.Text += numero + "x" + i + "=" + resultado + "\r\n"; //Faz a conta e diz pra exibir no txtTabuada a conta, 
                //ou seja, numero x i (que vai de 0 á 10) = resultado e depois pula pra uma nova linha.
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = ""; //apaga a txtbox de número
            txtTabuada.Text = ""; //apaga a txtbox da tabuada
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTabuada_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
