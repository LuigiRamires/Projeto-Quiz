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
    public partial class frmQuiz01 : Form
    {
        public frmQuiz01()
        {
            InitializeComponent();
        }

        private void BtnConfirmar01_Click(object sender, EventArgs e)
        {
            if (rdbResposta03.Checked)
            {
                ClasseDados.Acertou();
            }
            else
            {
                ClasseDados.Errou();
            }

            frmQuiz02 frmQuiz02 = new frmQuiz02();
            frmQuiz02.Show();
            this.Hide();
        }
    }
}
