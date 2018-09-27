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
    public partial class FrmVisualizadorImagens : Form
    {
        public FrmVisualizadorImagens()
        {
            InitializeComponent();
        }


        private void btnMostrarImagem_Click(object sender, EventArgs e)
        {
            if (ofdImagens.ShowDialog() == DialogResult.OK) // se o resultado da janela aberta pelo ofdimagens for uma ação de con
            {
                pboxImagem.Load(ofdImagens.FileName); //imagem selecionada será exibida na Picturebox.
            }
        }
        

        private void btnLimparImagem_Click(object sender, EventArgs e)
        {
            pboxImagem.Image = null;
            btnMostrarImagem.Enabled = false; //desabilita o botão btnMostrarImagem 
        }

        private void rdbStretch_CheckedChanged(object sender, EventArgs e) //se p RadioButton Stretch estiver maracado
        {
            if (rdbStretch.Checked == true)
            {
                pboxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void rdbNormal_CheckedChanged(object sender, EventArgs e) //se o Radiobutton Normal estiver marcado
        {
            if (rdbNormal.Checked == true)
            {
                pboxImagem.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void pboxImagem_Click(object sender, EventArgs e)
        {

        }

        private void pboxRetrato_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog ofdImagens = new OpenFileDialog();
        }

    }
}
