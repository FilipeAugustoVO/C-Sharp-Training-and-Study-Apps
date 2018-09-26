namespace PrimeiroAplicativo
{
    partial class FrmMenuPrincipal
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
            this.btnCheckBox = new System.Windows.Forms.Button();
            this.btnImagens = new System.Windows.Forms.Button();
            this.Tabuada = new System.Windows.Forms.Button();
            this.btnMostrarMensagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCheckBox
            // 
            this.btnCheckBox.Location = new System.Drawing.Point(12, 12);
            this.btnCheckBox.Name = "btnCheckBox";
            this.btnCheckBox.Size = new System.Drawing.Size(75, 23);
            this.btnCheckBox.TabIndex = 0;
            this.btnCheckBox.Text = "CheckBox";
            this.btnCheckBox.UseVisualStyleBackColor = true;
            this.btnCheckBox.Click += new System.EventHandler(this.btnCheckBox_Click);
            // 
            // btnImagens
            // 
            this.btnImagens.Location = new System.Drawing.Point(93, 12);
            this.btnImagens.Name = "btnImagens";
            this.btnImagens.Size = new System.Drawing.Size(75, 23);
            this.btnImagens.TabIndex = 0;
            this.btnImagens.Text = "Imagens";
            this.btnImagens.UseVisualStyleBackColor = true;
            this.btnImagens.Click += new System.EventHandler(this.btnImagens_Click);
            // 
            // Tabuada
            // 
            this.Tabuada.Location = new System.Drawing.Point(174, 12);
            this.Tabuada.Name = "Tabuada";
            this.Tabuada.Size = new System.Drawing.Size(75, 23);
            this.Tabuada.TabIndex = 0;
            this.Tabuada.Text = "Tabuada";
            this.Tabuada.UseVisualStyleBackColor = true;
            this.Tabuada.Click += new System.EventHandler(this.Tabuada_Click);
            // 
            // btnMostrarMensagem
            // 
            this.btnMostrarMensagem.Location = new System.Drawing.Point(73, 177);
            this.btnMostrarMensagem.Name = "btnMostrarMensagem";
            this.btnMostrarMensagem.Size = new System.Drawing.Size(117, 23);
            this.btnMostrarMensagem.TabIndex = 1;
            this.btnMostrarMensagem.Text = "Mostrar Mensagem";
            this.btnMostrarMensagem.UseVisualStyleBackColor = true;
            this.btnMostrarMensagem.Click += new System.EventHandler(this.btnMostrarMensagem_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(263, 247);
            this.Controls.Add(this.btnMostrarMensagem);
            this.Controls.Add(this.Tabuada);
            this.Controls.Add(this.btnImagens);
            this.Controls.Add(this.btnCheckBox);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckBox;
        private System.Windows.Forms.Button btnImagens;
        private System.Windows.Forms.Button Tabuada;
        private System.Windows.Forms.Button btnMostrarMensagem;
    }
}