namespace Projeto_Quiz
{
    partial class frmQuiz01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuiz01));
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.lblQuestao = new System.Windows.Forms.Label();
            this.rdbResposta01 = new System.Windows.Forms.RadioButton();
            this.rdbResposta02 = new System.Windows.Forms.RadioButton();
            this.rdbResposta03 = new System.Windows.Forms.RadioButton();
            this.rdbResposta04 = new System.Windows.Forms.RadioButton();
            this.rdbResposta05 = new System.Windows.Forms.RadioButton();
            this.pctLogoBing = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoBing)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(418, 243);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(107, 30);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar01_Click);
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.Location = new System.Drawing.Point(251, 60);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(377, 20);
            this.lblPergunta.TabIndex = 7;
            this.lblPergunta.Text = "Quem é o dono da ferramenta de pesquisas Bing?";
            // 
            // lblQuestao
            // 
            this.lblQuestao.AutoSize = true;
            this.lblQuestao.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestao.Location = new System.Drawing.Point(355, 23);
            this.lblQuestao.Name = "lblQuestao";
            this.lblQuestao.Size = new System.Drawing.Size(128, 25);
            this.lblQuestao.TabIndex = 6;
            this.lblQuestao.Text = "Questão 01";
            // 
            // rdbResposta01
            // 
            this.rdbResposta01.AutoSize = true;
            this.rdbResposta01.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.rdbResposta01.Location = new System.Drawing.Point(255, 93);
            this.rdbResposta01.Name = "rdbResposta01";
            this.rdbResposta01.Size = new System.Drawing.Size(71, 24);
            this.rdbResposta01.TabIndex = 9;
            this.rdbResposta01.TabStop = true;
            this.rdbResposta01.Text = "Apple";
            this.rdbResposta01.UseVisualStyleBackColor = true;
            // 
            // rdbResposta02
            // 
            this.rdbResposta02.AutoSize = true;
            this.rdbResposta02.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.rdbResposta02.Location = new System.Drawing.Point(255, 123);
            this.rdbResposta02.Name = "rdbResposta02";
            this.rdbResposta02.Size = new System.Drawing.Size(84, 24);
            this.rdbResposta02.TabIndex = 10;
            this.rdbResposta02.TabStop = true;
            this.rdbResposta02.Text = "Bing S.A";
            this.rdbResposta02.UseVisualStyleBackColor = true;
            // 
            // rdbResposta03
            // 
            this.rdbResposta03.AutoSize = true;
            this.rdbResposta03.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.rdbResposta03.Location = new System.Drawing.Point(255, 153);
            this.rdbResposta03.Name = "rdbResposta03";
            this.rdbResposta03.Size = new System.Drawing.Size(96, 24);
            this.rdbResposta03.TabIndex = 11;
            this.rdbResposta03.TabStop = true;
            this.rdbResposta03.Text = "Microsoft";
            this.rdbResposta03.UseVisualStyleBackColor = true;
            // 
            // rdbResposta04
            // 
            this.rdbResposta04.AutoSize = true;
            this.rdbResposta04.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.rdbResposta04.Location = new System.Drawing.Point(255, 183);
            this.rdbResposta04.Name = "rdbResposta04";
            this.rdbResposta04.Size = new System.Drawing.Size(83, 24);
            this.rdbResposta04.TabIndex = 12;
            this.rdbResposta04.TabStop = true;
            this.rdbResposta04.Text = "Google";
            this.rdbResposta04.UseVisualStyleBackColor = true;
            // 
            // rdbResposta05
            // 
            this.rdbResposta05.AutoSize = true;
            this.rdbResposta05.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.rdbResposta05.Location = new System.Drawing.Point(255, 213);
            this.rdbResposta05.Name = "rdbResposta05";
            this.rdbResposta05.Size = new System.Drawing.Size(102, 24);
            this.rdbResposta05.TabIndex = 13;
            this.rdbResposta05.TabStop = true;
            this.rdbResposta05.Text = "Facebook";
            this.rdbResposta05.UseVisualStyleBackColor = true;
            // 
            // pctLogoBing
            // 
            this.pctLogoBing.Image = global::Projeto_Quiz.Properties.Resources.kisspng_bing_news_logo_microsoft_msn_hoodie_twitch_5b49d27f637831_3173094215315646714074;
            this.pctLogoBing.InitialImage = global::Projeto_Quiz.Properties.Resources.kisspng_bing_news_logo_microsoft_msn_hoodie_twitch_5b49d27f637831_3173094215315646714074;
            this.pctLogoBing.Location = new System.Drawing.Point(11, 47);
            this.pctLogoBing.Name = "pctLogoBing";
            this.pctLogoBing.Size = new System.Drawing.Size(213, 198);
            this.pctLogoBing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogoBing.TabIndex = 0;
            this.pctLogoBing.TabStop = false;
            // 
            // frmQuiz01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 288);
            this.Controls.Add(this.rdbResposta05);
            this.Controls.Add(this.rdbResposta04);
            this.Controls.Add(this.rdbResposta03);
            this.Controls.Add(this.rdbResposta02);
            this.Controls.Add(this.rdbResposta01);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblPergunta);
            this.Controls.Add(this.lblQuestao);
            this.Controls.Add(this.pctLogoBing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuiz01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuiz01";
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoBing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogoBing;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.Label lblQuestao;
        private System.Windows.Forms.RadioButton rdbResposta01;
        private System.Windows.Forms.RadioButton rdbResposta02;
        private System.Windows.Forms.RadioButton rdbResposta03;
        private System.Windows.Forms.RadioButton rdbResposta04;
        private System.Windows.Forms.RadioButton rdbResposta05;
    }
}