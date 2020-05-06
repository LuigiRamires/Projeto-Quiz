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
    public partial class frmQuiz07 : Form
    {
        public frmQuiz07()
        {
            InitializeComponent();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (rdbResposta05.Checked)
            {
                ClasseDados.Acertou();
            }
            else
            {
                ClasseDados.Errou();
            }

            frmQuiz08 frmQuiz08 = new frmQuiz08();
            frmQuiz08.Show();
            this.Hide();
        }
    }
}
