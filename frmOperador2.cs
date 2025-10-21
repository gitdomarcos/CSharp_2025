using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_2025
{
    public partial class frmOperador2 : Form
    {
        public frmOperador2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(txtN1.Text.Trim() == string.Empty || txtN2.Text.Trim() == string.Empty
                || txtN3.Text.Trim() == string.Empty || txtN4.Text.Trim() == string.Empty ||
                txtN5.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher todos os campos!");
            }
            else
            {
                try
                {
                    double n1, n2, n3, n4, n5, res;
                    n1 = Convert.ToDouble(txtN1.Text);
                    n2 = Convert.ToDouble(txtN2.Text);
                    n3 = Convert.ToDouble(txtN3.Text);
                    n4 = Convert.ToDouble(txtN4.Text);
                    n5 = Convert.ToDouble(txtN5.Text);

                    res = (n1 * n2) + (n3 * n4 * n5);

                    lblResultado.Text = Convert.ToString(res);

                    if(res > 100)
                    {
                        MessageBox.Show("Número acima de 100!");
                    }
                    else if(res < 100)
                    {
                        MessageBox.Show("Número abaixo de 100!");
                    }
                    else if (res == 100)
                    {
                        MessageBox.Show("Número igual a 100!");
                    }
                }
                catch
                {
                    MessageBox.Show("Número(s) incorreto(s)!");
                    txtN1.Clear();
                    txtN2.Clear();
                    txtN3.Clear();
                    txtN4.Clear();
                    txtN5.Clear();
                    lblResultado.Visible = false;
                    txtN1.Focus();

                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
            txtN4.Clear();
            txtN5.Clear();
            lblResultado.Visible = false;
            txtN1.Focus();
        }
    }
}
