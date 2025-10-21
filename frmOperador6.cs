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
    public partial class frmOperador6 : Form
    {
        public frmOperador6()
        {
            InitializeComponent();
        }

        private void frmOperador6_Load(object sender, EventArgs e)
        {
            lblSemMulta.Visible = false;
            lbl3Pontos.Visible = false;
            lbl5Pontos.Visible = false;
            lbl10Pontos.Visible = false;
            lbl15Pontos.Visible = false;
            lbl18Pontos.Visible = false;
            lbl20Pontos.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtVelocidade.Text.Trim() == string.Empty)
                MessageBox.Show("Preencher o campo VELOCIDADE!");

            else
            {
                try
                {
                    double velocidade;

                    velocidade = Convert.ToDouble(txtVelocidade.Text);

                    if(velocidade >= 0 && velocidade <= 50)
                    {
                        lblSemMulta.Visible = true;
                        lbl3Pontos.Visible = false;
                        lbl5Pontos.Visible = false;
                        lbl10Pontos.Visible = false;
                        lbl15Pontos.Visible = false;
                        lbl18Pontos.Visible = false;
                        lbl20Pontos.Visible = false;
                        lblSemMulta.ForeColor = Color.Green;
                    }
                    else if(velocidade <= 60)
                    {
                        lblSemMulta.Visible = false;
                        lbl3Pontos.Visible = true;
                        lbl5Pontos.Visible = false;
                        lbl10Pontos.Visible = false;
                        lbl15Pontos.Visible = false;
                        lbl18Pontos.Visible = false;
                        lbl20Pontos.Visible = false;
                        lblSemMulta.ForeColor = Color.Orange;
                    }
                    else if(velocidade <= 70)
                    {
                        lblSemMulta.Visible = false;
                        lbl3Pontos.Visible = false;
                        lbl5Pontos.Visible = true;
                        lbl10Pontos.Visible = false;
                        lbl15Pontos.Visible = false;
                        lbl18Pontos.Visible = false;
                        lbl20Pontos.Visible = false;
                        lblSemMulta.ForeColor = Color.OrangeRed;
                    }
                    else if(velocidade <= 80)
                    {
                        lblSemMulta.Visible = false;
                        lbl3Pontos.Visible = false;
                        lbl5Pontos.Visible = false;
                        lbl10Pontos.Visible = true;
                        lbl15Pontos.Visible = false;
                        lbl18Pontos.Visible = false;
                        lbl20Pontos.Visible = false;
                        lblSemMulta.ForeColor = Color.DarkOrange;
                    }
                    else if(velocidade <= 90)
                    {
                        lblSemMulta.Visible = false;
                        lbl3Pontos.Visible = false;
                        lbl5Pontos.Visible = false;
                        lbl10Pontos.Visible = false;
                        lbl15Pontos.Visible = true;
                        lbl18Pontos.Visible = false;
                        lbl20Pontos.Visible = false;
                        lblSemMulta.ForeColor = Color.Red;
                    }
                    else if( velocidade <= 100)
                    {
                        lblSemMulta.Visible = false;
                        lbl3Pontos.Visible = false;
                        lbl5Pontos.Visible = false;
                        lbl10Pontos.Visible = false;
                        lbl15Pontos.Visible = false;
                        lbl18Pontos.Visible = true;
                        lbl20Pontos.Visible = false;
                        lblSemMulta.ForeColor = Color.DarkRed;
                    }
                    else if(velocidade > 100)
                    {
                        lblSemMulta.Visible = false;
                        lbl3Pontos.Visible = false;
                        lbl5Pontos.Visible = false;
                        lbl10Pontos.Visible = false;
                        lbl15Pontos.Visible = false;
                        lbl18Pontos.Visible = false;
                        lbl20Pontos.Visible = true;
                        lblSemMulta.ForeColor = Color.DarkSalmon;
                    }

                }
                catch 
                {
                    MessageBox.Show("Número(s) Inválido(s)!");
                    txtVelocidade.Clear();
                    lblSemMulta.Visible = false;
                    lbl3Pontos.Visible = false;
                    lbl5Pontos.Visible = false;
                    lbl10Pontos.Visible = false;
                    lbl15Pontos.Visible = false;
                    lbl18Pontos.Visible = false;
                    lbl20Pontos.Visible = false;
                    txtVelocidade.Focus();
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVelocidade.Clear();
            lblSemMulta.Visible = false;
            lbl3Pontos.Visible = false;
            lbl5Pontos.Visible = false;
            lbl10Pontos.Visible = false;
            lbl15Pontos.Visible = false;
            lbl18Pontos.Visible = false;
            lbl20Pontos.Visible = false;
            txtVelocidade.Focus();
        }


    }
}
