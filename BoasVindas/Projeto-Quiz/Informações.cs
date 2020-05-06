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
    public partial class frmInformações : Form
    {
        public frmInformações()
        {
            InitializeComponent();
        }

        private void BtnCliqueAqui_Click(object sender, EventArgs e)
        {
            frmQuiz01 frmQuiz01 = new frmQuiz01();
            frmQuiz01.Show();
            this.Hide();
        }
    }
}
