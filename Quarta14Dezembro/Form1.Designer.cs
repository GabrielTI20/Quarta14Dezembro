namespace Quarta14Dezembro
{
    partial class Form1
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
            this.Limpar1 = new System.Windows.Forms.Button();
            this.Mensagem1 = new System.Windows.Forms.Label();
            this.Senha1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Limpar1
            // 
            this.Limpar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Limpar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Limpar1.Location = new System.Drawing.Point(330, 64);
            this.Limpar1.Name = "Limpar1";
            this.Limpar1.Size = new System.Drawing.Size(120, 44);
            this.Limpar1.TabIndex = 0;
            this.Limpar1.Text = "Limpar";
            this.Limpar1.UseVisualStyleBackColor = false;
            this.Limpar1.Click += new System.EventHandler(this.Limpar1_Click);
            // 
            // Mensagem1
            // 
            this.Mensagem1.AutoSize = true;
            this.Mensagem1.Location = new System.Drawing.Point(48, 112);
            this.Mensagem1.Name = "Mensagem1";
            this.Mensagem1.Size = new System.Drawing.Size(35, 13);
            this.Mensagem1.TabIndex = 1;
            this.Mensagem1.Text = "label1";
            this.Mensagem1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Senha1
            // 
            this.Senha1.Location = new System.Drawing.Point(51, 76);
            this.Senha1.Name = "Senha1";
            this.Senha1.Size = new System.Drawing.Size(241, 20);
            this.Senha1.TabIndex = 2;
            this.Senha1.TextChanged += new System.EventHandler(this.Senha1_TextChanged);
            this.Senha1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 171);
            this.Controls.Add(this.Senha1);
            this.Controls.Add(this.Mensagem1);
            this.Controls.Add(this.Limpar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Limpar1;
        private System.Windows.Forms.Label Mensagem1;
        private System.Windows.Forms.TextBox Senha1;
    }
}

