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
    public partial class frm2 : Form
    {
        double areatot = 0.0;
        DialogResult resposta;

        public frm2()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            Hide();
            menu.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
           


        }
    }
}
