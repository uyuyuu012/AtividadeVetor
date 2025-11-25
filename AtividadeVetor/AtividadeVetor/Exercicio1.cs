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
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        int[] matrizA = new int[15];
        int contador = 0;   

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            Hide();
            menu.Show();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (contador != matrizA.Length)
            {
                MessageBox.Show("Erro! Adicione 15 números à matriz!");
            }
            else
            {
                int i;

                int[] matrizB = new int[15];

                for (i = 0; i < matrizA.Length; i++)
                {
                    matrizB[i] = matrizA[i] * matrizA[i];
                    txtMatrizB.Text += Convert.ToString(matrizB[i]) + "\r\n";
                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (contador == matrizA.Length)
            {
                MessageBox.Show("Matriz cheia! Clique em calcular.");
            }
            else
            {
                matrizA[contador] = Convert.ToInt32(txtMatrizA.Text);
                contador++;
                txtMatrizA.Clear();
                txtMatrizA.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMatrizA.Clear();
            txtMatrizA.Focus();
            txtMatrizB.Clear();
            contador = 0;
        }
    }
}
