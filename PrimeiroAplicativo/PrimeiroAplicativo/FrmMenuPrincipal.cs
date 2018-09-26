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
        // ainda não está em uso. FrmTabuada segundoForm = new FrmTabuadaCheckBox(); //criação e execução do objeto SegundoForm

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

        }

        private void btnMostrarMensagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado por usa nosso programa, feito por Filipe Augusto, futuro maior paraense de todos os tempos", "Mensagens,");
        }
       
    }
}
