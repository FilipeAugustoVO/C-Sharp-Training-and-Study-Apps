namespace PrimeiroAplicativo
{
    partial class FrmVisualizadorImagens
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMostrarImagem = new System.Windows.Forms.Button();
            this.btnLimparImagem = new System.Windows.Forms.Button();
            this.rdbStretch = new System.Windows.Forms.RadioButton();
            this.rdbNormal = new System.Windows.Forms.RadioButton();
            this.pboxImagem = new System.Windows.Forms.PictureBox();
            this.pboxRetrato = new System.Windows.Forms.PictureBox();
            this.ofdImagens = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRetrato)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarImagem
            // 
            this.btnMostrarImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarImagem.Location = new System.Drawing.Point(12, 392);
            this.btnMostrarImagem.Name = "btnMostrarImagem";
            this.btnMostrarImagem.Size = new System.Drawing.Size(116, 29);
            this.btnMostrarImagem.TabIndex = 1;
            this.btnMostrarImagem.Text = "Mostrar Imagem";
            this.btnMostrarImagem.UseVisualStyleBackColor = true;
            this.btnMostrarImagem.Click += new System.EventHandler(this.btnMostrarImagem_Click);
            // 
            // btnLimparImagem
            // 
            this.btnLimparImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparImagem.Location = new System.Drawing.Point(163, 392);
            this.btnLimparImagem.Name = "btnLimparImagem";
            this.btnLimparImagem.Size = new System.Drawing.Size(114, 29);
            this.btnLimparImagem.TabIndex = 2;
            this.btnLimparImagem.Text = "Limpar Imagem";
            this.btnLimparImagem.UseVisualStyleBackColor = true;
            this.btnLimparImagem.Click += new System.EventHandler(this.btnLimparImagem_Click);
            // 
            // rdbStretch
            // 
            this.rdbStretch.AutoSize = true;
            this.rdbStretch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbStretch.Location = new System.Drawing.Point(355, 396);
            this.rdbStretch.Name = "rdbStretch";
            this.rdbStretch.Size = new System.Drawing.Size(67, 20);
            this.rdbStretch.TabIndex = 3;
            this.rdbStretch.TabStop = true;
            this.rdbStretch.Text = "Stretch";
            this.rdbStretch.UseVisualStyleBackColor = true;
            this.rdbStretch.CheckedChanged += new System.EventHandler(this.rdbStretch_CheckedChanged);
            // 
            // rdbNormal
            // 
            this.rdbNormal.AutoSize = true;
            this.rdbNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNormal.Location = new System.Drawing.Point(496, 396);
            this.rdbNormal.Name = "rdbNormal";
            this.rdbNormal.Size = new System.Drawing.Size(70, 20);
            this.rdbNormal.TabIndex = 3;
            this.rdbNormal.TabStop = true;
            this.rdbNormal.Text = "Normal";
            this.rdbNormal.UseVisualStyleBackColor = true;
            // 
            // pboxImagem
            // 
            this.pboxImagem.Image = global::PrimeiroAplicativo.Properties.Resources.Big_turtle_big3name_archelon_ruling_turtlephonetic_arekellonnamed_by_gr_wieland_a48474_6345322;
            this.pboxImagem.Location = new System.Drawing.Point(69, 69);
            this.pboxImagem.Name = "pboxImagem";
            this.pboxImagem.Size = new System.Drawing.Size(462, 250);
            this.pboxImagem.TabIndex = 5;
            this.pboxImagem.TabStop = false;
            this.pboxImagem.Click += new System.EventHandler(this.pboxImagem_Click);
            // 
            // pboxRetrato
            // 
            this.pboxRetrato.Image = global::PrimeiroAplicativo.Properties.Resources.depositphotos_111026112_stock_illustration_decorative_black_rectangular_frame;
            this.pboxRetrato.Location = new System.Drawing.Point(-1, -1);
            this.pboxRetrato.Name = "pboxRetrato";
            this.pboxRetrato.Size = new System.Drawing.Size(599, 387);
            this.pboxRetrato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxRetrato.TabIndex = 4;
            this.pboxRetrato.TabStop = false;
            this.pboxRetrato.Click += new System.EventHandler(this.pboxRetrato_Click);
            // 
            // ofdImagens
            // 
            this.ofdImagens.FileName = " ";
            this.ofdImagens.Filter = "Image Files (*.BMP;*.JPG;*.GIF)|*.BMP;*JPG;*.GIF|All files (*.*) |*.*,";
            this.ofdImagens.InitialDirectory = "PrimeiroAplicativo\\imagens";
            this.ofdImagens.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // FrmVisualizadorImagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(598, 428);
            this.Controls.Add(this.pboxImagem);
            this.Controls.Add(this.pboxRetrato);
            this.Controls.Add(this.rdbNormal);
            this.Controls.Add(this.rdbStretch);
            this.Controls.Add(this.btnLimparImagem);
            this.Controls.Add(this.btnMostrarImagem);
            this.Name = "FrmVisualizadorImagens";
            this.Text = "FormVisualizadorImagens";
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRetrato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMostrarImagem;
        private System.Windows.Forms.Button btnLimparImagem;
        private System.Windows.Forms.RadioButton rdbStretch;
        private System.Windows.Forms.RadioButton rdbNormal;
        private System.Windows.Forms.PictureBox pboxRetrato;
        private System.Windows.Forms.PictureBox pboxImagem;
        private System.Windows.Forms.OpenFileDialog ofdImagens;
    }
}