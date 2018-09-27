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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        FrmPropriedadesCheckBox segundoForm = new FrmPropriedadesCheckBox(); //criação e execução do objeto segundoForm
        FrmVisualizadorImagens terceiroForm = new FrmVisualizadorImagens(); //criação e execução do objeto terceiroForm
        FrmTabuada quartoForm = new FrmTabuada(); //criação e execução do objeto quartoForm

        private void btnCheckBox_Click(object sender, EventArgs e)
        {
            segundoForm.Show();
        }

        private void btnImagens_Click(object sender, EventArgs e)
        {
            terceiroForm.Show();
        }

        private void Tabuada_Click(object sender, EventArgs e)
        {
            quartoForm.Show();
        }

        private void btnMostrarMensagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado por usa nosso programa, feito por Filipe Augusto, futuro maior paraense de todos os tempos", "Mensagens,");
        }
       
    }
}
