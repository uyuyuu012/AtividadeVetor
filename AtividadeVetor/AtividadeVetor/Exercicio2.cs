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


        double[] A = new double[10];
        double[] B = new double[10]; // variável global
        int i = 0;

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
            if (i <= 9)
            {
                A[i] = Convert.ToDouble(txtNum1.Text);
                B[i] = -A[i];

                txtNum1.Clear();
                txtNum1.Focus();

                i++;
            }

            if (i > 9)
            {
                btnAdd.Enabled = false;
                txtNum1.Enabled = false;

                // habilita botão de mostrar (caso exista)
                btnCalc.Enabled = true;
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            txtMatA.Clear();
            txtMatB.Clear();

            for (int k = 0; k < 10; k++)
            {
                txtMatA.Text += A[k].ToString() + "\r\n";
                txtMatB.Text += B[k].ToString() + "\r\n";
            }

            btnCalc.Enabled = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMatA.Enabled = false;
            txtMatB.Enabled = false;
            txtNum1.Enabled = true;
            txtMatA.Clear();
            txtMatB.Clear();
            txtNum1.Focus();
            btnAdd.Enabled = true;
            btnCalc.Enabled = false;
        }
    }
}
