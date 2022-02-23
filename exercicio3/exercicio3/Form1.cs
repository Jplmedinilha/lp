using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal result = ((decimal.Parse(txtP1.Text) * 3 +
                decimal.Parse(txtP2.Text) * 4 +
                decimal.Parse(txtTCD.Text) * 3)) /10;

            if (result >= 8)
            {
                MessageBox.Show("O resultado do aluno " + txtNome.Text + " foi MB, sendo aprovado com média " + result+".");
            }
            else if (result >= 6)
            {
                MessageBox.Show("O resultado do aluno " + txtNome.Text + " foi B, sendo aprovado com média " + result + ".");
            }
            else if (result >= 4)
            {
                MessageBox.Show("O resultado do aluno " + txtNome.Text + " foi R, sendo aprovado com média " + result + ".");
            }
            else if (result >= 0)
            {
                MessageBox.Show("O resultado do aluno " + txtNome.Text + " foi I, sendo aprovado com média " + result + ".");
            } else
            {
                MessageBox.Show("Erro");
            }


        }
    }
}
