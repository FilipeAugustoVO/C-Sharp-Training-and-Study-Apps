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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMostrarImagem = new System.Windows.Forms.Button();
            this.btnLimparImagem = new System.Windows.Forms.Button();
            this.rdbStretch = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(597, 387);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(496, 396);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 20);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Normal";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(597, 387);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // FrmVisualizadorImagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(598, 428);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rdbStretch);
            this.Controls.Add(this.btnLimparImagem);
            this.Controls.Add(this.btnMostrarImagem);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmVisualizadorImagens";
            this.Text = "FormVisualizadorImagens";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMostrarImagem;
        private System.Windows.Forms.Button btnLimparImagem;
        private System.Windows.Forms.RadioButton rdbStretch;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}