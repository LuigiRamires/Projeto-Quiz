namespace Projeto_Quiz
{
    partial class frmInformações
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformações));
            this.lblInformações = new System.Windows.Forms.Label();
            this.lblPerguntas = new System.Windows.Forms.Label();
            this.lblRelacionadasTecnologia = new System.Windows.Forms.Label();
            this.lblDivirtase = new System.Windows.Forms.Label();
            this.btnCliqueAqui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInformações
            // 
            this.lblInformações.AutoSize = true;
            this.lblInformações.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformações.Location = new System.Drawing.Point(140, 9);
            this.lblInformações.Name = "lblInformações";
            this.lblInformações.Size = new System.Drawing.Size(139, 25);
            this.lblInformações.TabIndex = 1;
            this.lblInformações.Text = "Informações";
            // 
            // lblPerguntas
            // 
            this.lblPerguntas.AutoSize = true;
            this.lblPerguntas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerguntas.Location = new System.Drawing.Point(30, 49);
            this.lblPerguntas.Name = "lblPerguntas";
            this.lblPerguntas.Size = new System.Drawing.Size(376, 20);
            this.lblPerguntas.TabIndex = 2;
            this.lblPerguntas.Text = "Esse quiz contém 10 perguntas de múltipla escolha";
            // 
            // lblRelacionadasTecnologia
            // 
            this.lblRelacionadasTecnologia.AutoSize = true;
            this.lblRelacionadasTecnologia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelacionadasTecnologia.Location = new System.Drawing.Point(30, 70);
            this.lblRelacionadasTecnologia.Name = "lblRelacionadasTecnologia";
            this.lblRelacionadasTecnologia.Size = new System.Drawing.Size(382, 20);
            this.lblRelacionadasTecnologia.TabIndex = 3;
            this.lblRelacionadasTecnologia.Text = "a tecnologia. Todas as perguntas contém apenas 1";
            // 
            // lblDivirtase
            // 
            this.lblDivirtase.AutoSize = true;
            this.lblDivirtase.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivirtase.Location = new System.Drawing.Point(92, 91);
            this.lblDivirtase.Name = "lblDivirtase";
            this.lblDivirtase.Size = new System.Drawing.Size(228, 20);
            this.lblDivirtase.TabIndex = 4;
            this.lblDivirtase.Text = "alternativa correta. Divirta-se.";
            // 
            // btnCliqueAqui
            // 
            this.btnCliqueAqui.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliqueAqui.Location = new System.Drawing.Point(161, 117);
            this.btnCliqueAqui.Name = "btnCliqueAqui";
            this.btnCliqueAqui.Size = new System.Drawing.Size(107, 30);
            this.btnCliqueAqui.TabIndex = 5;
            this.btnCliqueAqui.Text = "Vamos começar!";
            this.btnCliqueAqui.UseVisualStyleBackColor = true;
            this.btnCliqueAqui.Click += new System.EventHandler(this.BtnCliqueAqui_Click);
            // 
            // frmInformações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 164);
            this.Controls.Add(this.btnCliqueAqui);
            this.Controls.Add(this.lblDivirtase);
            this.Controls.Add(this.lblRelacionadasTecnologia);
            this.Controls.Add(this.lblPerguntas);
            this.Controls.Add(this.lblInformações);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInformações";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformações;
        private System.Windows.Forms.Label lblPerguntas;
        private System.Windows.Forms.Label lblRelacionadasTecnologia;
        private System.Windows.Forms.Label lblDivirtase;
        private System.Windows.Forms.Button btnCliqueAqui;
    }
}