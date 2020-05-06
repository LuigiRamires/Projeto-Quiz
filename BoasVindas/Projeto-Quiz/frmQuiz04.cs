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
    public partial class frmQuiz04 : Form
    {
        public frmQuiz04()
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

            frmQuiz05 frmQuiz05 = new frmQuiz05();
            frmQuiz05.Show();
            this.Hide();
        }
    }
}
