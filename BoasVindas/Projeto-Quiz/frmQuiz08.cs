using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Quiz
{
    public partial class frmQuiz08 : Form
    {
        public frmQuiz08()
        {
            InitializeComponent();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (rdbResposta01.Checked)
            {
                ClasseDados.Acertou();
            }
            else
            {
                ClasseDados.Errou();
            }

            frmQuiz09 frmQuiz09 = new frmQuiz09();
            frmQuiz09.Show();
            this.Hide();
        }
    }
}
