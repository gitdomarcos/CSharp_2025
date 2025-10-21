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
    public partial class frmOperador4 : Form
    {
        public frmOperador4()
        {
            InitializeComponent();
        }

        private void frmOperador4_Load(object sender, EventArgs e)
        {
            pbMagro.Visible = false;
            pbIdeal.Visible = false;
            pbAcima.Visible = false;
            pbObeso.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtAlt.Text.Trim() == string.Empty || txtPeso.Text.Trim() == string.Empty)
                MessageBox.Show("Preencher todos os campos!");

            else
            {
                try
                {
                    decimal altura, peso, imc;

                    altura = Convert.ToDecimal(txtAlt.Text);
                    peso = Convert.ToDecimal(txtPeso.Text);

                    imc = (peso / (altura * altura));

                    txtImc.Text = Convert.ToString(imc);

                    if(imc >= 0 && imc < 21)
                    {
                        pbMagro.Visible = true;
                        pbIdeal.Visible = false;
                        pbAcima.Visible = false;
                        pbObeso.Visible = false;
                    }
                    else if(imc >= 21 && imc < 26)
                    {
                        pbMagro.Visible = false;
                        pbIdeal.Visible = true;
                        pbAcima.Visible = false;
                        pbObeso.Visible = false;
                    }
                    else if(imc >= 26 && imc < 31)
                    {
                        pbMagro.Visible = false;
                        pbIdeal.Visible = false;
                        pbAcima.Visible = true;
                        pbObeso.Visible = false;
                    }
                    else if(imc > 30)
                    {
                        pbMagro.Visible = false;
                        pbIdeal.Visible = false;
                        pbAcima.Visible = false;
                        pbObeso.Visible = true;
                    }
                }
                catch 
                {
                    MessageBox.Show("Número(s) Inválido(s)!");
                    txtAlt.Clear();
                    txtPeso.Clear();
                    txtImc.Clear();
                    pbMagro.Visible = false;
                    pbIdeal.Visible = false;
                    pbAcima.Visible = false;
                    pbObeso.Visible = false;
                    txtAlt.Focus();
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAlt.Clear();
            txtPeso.Clear();
            txtImc.Clear();
            pbMagro.Visible = false;
            pbIdeal.Visible = false;
            pbAcima.Visible = false;
            pbObeso.Visible = false;
            txtAlt.Focus();
        }

    }
}
