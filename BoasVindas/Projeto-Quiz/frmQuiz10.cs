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
    public partial class frmQuiz10 : Form
    {
        public frmQuiz10()
        {
            InitializeComponent();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (rdbResposta03.Checked)
            {
                ClasseDados.Acertou();
            }
            else
            {
                ClasseDados.Errou();
            }

            frmResultado frmResultado = new frmResultado();
            frmResultado.Show();
            this.Hide();
        }
    }
}
