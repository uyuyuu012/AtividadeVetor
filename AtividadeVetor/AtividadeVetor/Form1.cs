using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeVetor
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void tsmi1_Click(object sender, EventArgs e)
        {
            frm1 exercicio1 = new frm1();
            Hide();
            exercicio1.Show();
        }

        private void tsmiSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsm2_Click(object sender, EventArgs e)
        {
            frm2 exercicio2 = new frm2();
            Hide();
            exercicio2.Show();
        }

        private void tsmi3_Click(object sender, EventArgs e)
        {
            frm3 exercicio3 = new frm3();
            Hide();
            exercicio3.Show();
        }
    }
}
