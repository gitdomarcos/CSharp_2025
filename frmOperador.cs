using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_2025
{
    public partial class frmOperador : Form
    {
        public frmOperador()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txtN1.Text.Trim() == string.Empty ||
                txtN2.Text.Trim() == string.Empty ||
                txtN3.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher todos os campos!");
            }

            else
            {
                double n1, n2, n3, res;

                try
                {
                    n1 = Convert.ToDouble(txtN1.Text);
                    n2 = Convert.ToDouble(txtN2.Text);
                    n3 = Convert.ToDouble(txtN3.Text);

                    //Calculo
                    res = n2 / 2;
                    txtResultado.Text = Convert.ToString(res);
                    if (res <= n1 && res <= n3 || res <= n1 && res >= n3)
                        MessageBox.Show("O valor 02 esta dentro dos números fornecidos nos campos 01 e 03");
                    else
                        MessageBox.Show("O VALOR 02 esta fora dos numeros fornecidos no campo VALOR 01 e 03");

                    //falta fazer verificação se for números negativos!
                }
                catch
                {
                    MessageBox.Show("Números incorretos!");
                    txtN1.Clear();
                    txtN2.Clear();
                    txtN3.Clear();
                    txtResultado.Clear();
                    txtN1.Focus();
                }

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
            txtResultado.Clear();
            txtN1.Focus();
        }
    }
}
