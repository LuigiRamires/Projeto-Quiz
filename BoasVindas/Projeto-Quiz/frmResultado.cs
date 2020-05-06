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
    public partial class frmResultado : Form
    {
        public frmResultado()
        {
            InitializeComponent();
        }

        private void FrmResultado_Load(object sender, EventArgs e)
        {
            if ((ClasseDados.Acertos >= 4) && (ClasseDados.Acertos <= 7))
            {
                rcbResultado.Text = "Acertos: " + ClasseDados.Acertos + "\nErros: " + ClasseDados.Erros +
               "\nPrecisa melhorar...";
            }
            else if ((ClasseDados.Acertos >= 0) && (ClasseDados.Acertos <= 3))
            {
                rcbResultado.Text = "Acertos: " + ClasseDados.Acertos + "\nErros: " + ClasseDados.Erros +
               "\nVocê realmente precisa melhorar...";
            }
            else if ((ClasseDados.Acertos >= 7) && (ClasseDados.Acertos <= 9))
            {
                rcbResultado.Text = "Acertos: " + ClasseDados.Acertos + "\nErros: " + ClasseDados.Erros +
               "\nMuito bem Está em um bom nivel";
            }
            else
            {
                rcbResultado.Text = "Acertos: " + ClasseDados.Acertos + "\nErros: " + ClasseDados.Erros +
               "\nExcelente! Você acertou todas as questões!";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
