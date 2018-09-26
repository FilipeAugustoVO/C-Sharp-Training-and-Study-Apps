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
    public partial class FrmPropriedadesCheckBox : Form
    {
        public FrmPropriedadesCheckBox()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Checkbox Pessoa Fisica
        private void chkPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            pnlPessoaFisica.Visible = true;
            pnlPessoaJuridica.Visible = false;
        }
        

        //Checkbox Pessoa Juridica
        private void chkPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            pnlPessoaJuridica.Visible = true;
            pnlPessoaFisica.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlPessoaJuridica_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlPessoaFisica_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
