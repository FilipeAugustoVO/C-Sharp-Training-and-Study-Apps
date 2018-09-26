namespace PrimeiroAplicativo
{
    partial class FrmPropriedadesCheckBox
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
            this.chkPessoaFisica = new System.Windows.Forms.CheckBox();
            this.chkPessoaJuridica = new System.Windows.Forms.CheckBox();
            this.pnlPessoaFisica = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPessoaJuridica = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlPessoaFisica.SuspendLayout();
            this.pnlPessoaJuridica.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkPessoaFisica
            // 
            this.chkPessoaFisica.AutoSize = true;
            this.chkPessoaFisica.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPessoaFisica.Location = new System.Drawing.Point(39, 100);
            this.chkPessoaFisica.Name = "chkPessoaFisica";
            this.chkPessoaFisica.Size = new System.Drawing.Size(120, 21);
            this.chkPessoaFisica.TabIndex = 2;
            this.chkPessoaFisica.Text = "Pessoa Física";
            this.chkPessoaFisica.UseVisualStyleBackColor = true;
            this.chkPessoaFisica.CheckedChanged += new System.EventHandler(this.chkPessoaFisica_CheckedChanged);
            // 
            // chkPessoaJuridica
            // 
            this.chkPessoaJuridica.AutoSize = true;
            this.chkPessoaJuridica.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPessoaJuridica.Location = new System.Drawing.Point(39, 143);
            this.chkPessoaJuridica.Name = "chkPessoaJuridica";
            this.chkPessoaJuridica.Size = new System.Drawing.Size(131, 21);
            this.chkPessoaJuridica.TabIndex = 3;
            this.chkPessoaJuridica.Text = "Pessoa Jurídica";
            this.chkPessoaJuridica.UseVisualStyleBackColor = true;
            this.chkPessoaJuridica.CheckedChanged += new System.EventHandler(this.chkPessoaJuridica_CheckedChanged);
            // 
            // pnlPessoaFisica
            // 
            this.pnlPessoaFisica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPessoaFisica.Controls.Add(this.textBox2);
            this.pnlPessoaFisica.Controls.Add(this.textBox1);
            this.pnlPessoaFisica.Controls.Add(this.label2);
            this.pnlPessoaFisica.Controls.Add(this.label1);
            this.pnlPessoaFisica.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPessoaFisica.Location = new System.Drawing.Point(320, 12);
            this.pnlPessoaFisica.Name = "pnlPessoaFisica";
            this.pnlPessoaFisica.Size = new System.Drawing.Size(225, 105);
            this.pnlPessoaFisica.TabIndex = 4;
            this.pnlPessoaFisica.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPessoaFisica_Paint);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(110, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(101, 25);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(110, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 25);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // pnlPessoaJuridica
            // 
            this.pnlPessoaJuridica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPessoaJuridica.Controls.Add(this.textBox3);
            this.pnlPessoaJuridica.Controls.Add(this.textBox4);
            this.pnlPessoaJuridica.Controls.Add(this.label3);
            this.pnlPessoaJuridica.Controls.Add(this.label4);
            this.pnlPessoaJuridica.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPessoaJuridica.Location = new System.Drawing.Point(320, 143);
            this.pnlPessoaJuridica.Name = "pnlPessoaJuridica";
            this.pnlPessoaJuridica.Size = new System.Drawing.Size(225, 105);
            this.pnlPessoaJuridica.TabIndex = 5;
            this.pnlPessoaJuridica.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPessoaJuridica_Paint);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(110, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(101, 25);
            this.textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(110, 19);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(101, 25);
            this.textBox4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "CNPJ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome:";
            // 
            // FrmPropriedadesCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 280);
            this.Controls.Add(this.pnlPessoaJuridica);
            this.Controls.Add(this.pnlPessoaFisica);
            this.Controls.Add(this.chkPessoaJuridica);
            this.Controls.Add(this.chkPessoaFisica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPropriedadesCheckBox";
            this.Text = "Propriedades do Check-Box";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlPessoaFisica.ResumeLayout(false);
            this.pnlPessoaFisica.PerformLayout();
            this.pnlPessoaJuridica.ResumeLayout(false);
            this.pnlPessoaJuridica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkPessoaFisica;
        private System.Windows.Forms.CheckBox chkPessoaJuridica;
        private System.Windows.Forms.Panel pnlPessoaFisica;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPessoaJuridica;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

