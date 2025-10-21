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
    public partial class frmOperador5 : Form
    {
        public frmOperador5()
        {
            InitializeComponent();
        }

        private void frmOperador5_Load(object sender, EventArgs e)
        {
            lblRuim.Visible = false;
            lblBom.Visible = false;
            lblRazoavel.Visible = false;
            lblOtimo.Visible = false;
            lblExcelente.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtSal.Text.Trim() == string.Empty)
                MessageBox.Show("Preencher o campos 'SALARIO ATUAL'");

            else
            {
                try
                {
                    decimal sal, aumento15, aumento18, salAtual, totalAumento;

                    sal = Convert.ToDecimal(txtSal.Text);

                    aumento15 = (sal * 15) / 100;
                    txtAumento15.Text = Convert.ToString(aumento15);

                    aumento18 = (sal * 18) / 100;
                    txtAumento18.Text = Convert.ToString(aumento18);

                    salAtual = aumento15 + aumento18 + sal;
                    txtSalAtual.Text = Convert.ToString(salAtual);

                    totalAumento = aumento15 + aumento18;
                    txtTotalAumento.Text = Convert.ToString(totalAumento);

                    if(totalAumento >= 0 && totalAumento <= 100)
                    {
                        lblRuim.Visible = true;
                        lblBom.Visible = false;
                        lblRazoavel.Visible = false;
                        lblOtimo.Visible = false;
                        lblExcelente.Visible = false;
                    }
                    else if(totalAumento >= 101 && totalAumento <= 200)
                    {
                        lblRuim.Visible = false;
                        lblBom.Visible = true;
                        lblRazoavel.Visible = false;
                        lblOtimo.Visible = false;
                        lblExcelente.Visible = false;
                    }
                    else if(totalAumento >= 201 && totalAumento <= 300)
                    {
                        lblRuim.Visible = false;
                        lblBom.Visible = false;
                        lblRazoavel.Visible = true;
                        lblOtimo.Visible = false;
                        lblExcelente.Visible = false;
                    }
                    else if(totalAumento >= 301 && totalAumento <= 400)
                    {
                        lblRuim.Visible = false;
                        lblBom.Visible = false;
                        lblRazoavel.Visible = false;
                        lblOtimo.Visible = true;
                        lblExcelente.Visible = false;
                    }
                    else if(totalAumento > 400)
                    {
                        lblRuim.Visible = false;
                        lblBom.Visible = false;
                        lblRazoavel.Visible = false;
                        lblOtimo.Visible = false;
                        lblExcelente.Visible = true;
                    }

                }
                catch 
                {
                    MessageBox.Show("Preencher corretamente o campo!");
                    txtSal.Clear();
                    txtAumento15.Clear();
                    txtAumento18.Clear();
                    txtSalAtual.Clear();
                    txtTotalAumento.Clear();
                    lblRuim.Visible = false;
                    lblBom.Visible = false;
                    lblRazoavel.Visible = false;
                    lblOtimo.Visible = false;
                    lblExcelente.Visible = false;
                    txtSal.Focus();
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSal.Clear();
            txtAumento15.Clear();
            txtAumento18.Clear();
            txtSalAtual.Clear();
            txtTotalAumento.Clear();
            lblRuim.Visible = false;
            lblBom.Visible = false;
            lblRazoavel.Visible = false;
            lblOtimo.Visible = false;
            lblExcelente.Visible = false;
            txtSal.Focus();
        }
    }
}
