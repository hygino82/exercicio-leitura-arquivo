namespace LerEscrever
{
    partial class btnLerTxt
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEscrevertxt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtConteudo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnEscrevertxt
            // 
            this.btnEscrevertxt.BackColor = System.Drawing.Color.Salmon;
            this.btnEscrevertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscrevertxt.Location = new System.Drawing.Point(12, 378);
            this.btnEscrevertxt.Name = "btnEscrevertxt";
            this.btnEscrevertxt.Size = new System.Drawing.Size(208, 60);
            this.btnEscrevertxt.TabIndex = 1;
            this.btnEscrevertxt.Text = "Escrever TXT";
            this.btnEscrevertxt.UseVisualStyleBackColor = false;
            this.btnEscrevertxt.Click += new System.EventHandler(this.btnEscrevertxt_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(346, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ler TXT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtConteudo
            // 
            this.txtConteudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConteudo.Location = new System.Drawing.Point(12, 12);
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(650, 328);
            this.txtConteudo.TabIndex = 3;
            this.txtConteudo.Text = "";
            // 
            // btnLerTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEscrevertxt);
            this.Name = "btnLerTxt";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEscrevertxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtConteudo;
    }
}

