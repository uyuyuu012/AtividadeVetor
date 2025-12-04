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
    public partial class frm3 : Form
    {

        double[] A = new double[30];
        double[] B = new double[30];
        int i = 0;
        public frm3()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (i < 30)
            {
                A[i] = Convert.ToDouble(txtNum.Text);
                B[i] = Math.Pow(A[i], 3);

                txtNum.Clear();
                txtNum.Focus();

                txtMatA.Text = (i + 1).ToString();

                i++;
            }

            if (i > 29)
            {
                btnAdd.Enabled = false;
                txtNum.Enabled = false;
                txtPesquisa.Focus();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int s;
            s = Convert.ToInt32(txtPesquisa.Text);

            if (s < i)
            {
                txtMatB.Text = B[s].ToString();
                txtNum.Text = A[s].ToString();
            }
            else
            {
                MessageBox.Show("Número não encontrado");

                txtPesquisa.Clear();
                txtPesquisa.Focus();
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            txtMatA.Clear();
            txtMatB.Clear();

            for (int j = 0; j < 30; j++)
            {
                txtMatA.Text += A[j].ToString() + "\r\n";
                txtMatB.Text += B[j].ToString() + "\r\n";
            }

            btnCalc.Enabled = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            Hide();
            menu.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMatA.Clear();
            txtPesquisa.Clear() ;
            txtMatB.Clear();
            txtNum.Clear();
            txtNum.Focus();
        }
    }
}
