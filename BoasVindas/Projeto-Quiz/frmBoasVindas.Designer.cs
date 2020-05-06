namespace Projeto_Quiz
{
    partial class frmBoasVindas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBoasVindas));
            this.lblSejaBemVindo = new System.Windows.Forms.Label();
            this.lblParaIniciar = new System.Windows.Forms.Label();
            this.btnCliqueAqui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSejaBemVindo
            // 
            this.lblSejaBemVindo.AutoSize = true;
            this.lblSejaBemVindo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSejaBemVindo.Location = new System.Drawing.Point(47, 65);
            this.lblSejaBemVindo.Name = "lblSejaBemVindo";
            this.lblSejaBemVindo.Size = new System.Drawing.Size(329, 24);
            this.lblSejaBemVindo.TabIndex = 0;
            this.lblSejaBemVindo.Text = "Seja bem-vindo ao Projeto Quiz";
            // 
            // lblParaIniciar
            // 
            this.lblParaIniciar.AutoSize = true;
            this.lblParaIniciar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParaIniciar.Location = new System.Drawing.Point(12, 89);
            this.lblParaIniciar.Name = "lblParaIniciar";
            this.lblParaIniciar.Size = new System.Drawing.Size(401, 21);
            this.lblParaIniciar.TabIndex = 1;
            this.lblParaIniciar.Text = "para iniciar o questionário clique no botão abaixo.";
            // 
            // btnCliqueAqui
            // 
            this.btnCliqueAqui.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliqueAqui.Location = new System.Drawing.Point(163, 120);
            this.btnCliqueAqui.Name = "btnCliqueAqui";
            this.btnCliqueAqui.Size = new System.Drawing.Size(107, 30);
            this.btnCliqueAqui.TabIndex = 2;
            this.btnCliqueAqui.Text = "Clique Aqui!";
            this.btnCliqueAqui.UseVisualStyleBackColor = true;
            this.btnCliqueAqui.Click += new System.EventHandler(this.BtnCliqueAqui_Click);
            // 
            // frmBoasVindas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 189);
            this.Controls.Add(this.btnCliqueAqui);
            this.Controls.Add(this.lblParaIniciar);
            this.Controls.Add(this.lblSejaBemVindo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBoasVindas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seja bem-vindo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSejaBemVindo;
        private System.Windows.Forms.Label lblParaIniciar;
        private System.Windows.Forms.Button btnCliqueAqui;
    }
}

