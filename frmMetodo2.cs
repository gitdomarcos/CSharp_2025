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
    public partial class frmMetodo2 : Form
    {
        public frmMetodo2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(ValidarCampos() == true)
            {
                try
                {
                    //declarar as variaveis
                    double metragem, custo, total;

                    metragem = Convert.ToDouble(txtMetro.Text);
                    custo = Convert.ToDouble(txtCusto.Text);

                    //calculo
                    total = CalcularCustoTotal(metragem, custo);

                    //exibir
                    lblTotalRes.Text = total.ToString();
                }
                catch 
                {
                    MessageBox.Show("Erro na digitação dos valores!");
                    LimparCampos();
                }
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }


        private Double CalcularCustoTotal(double metragem, double custo)
        {
            double total;
            total = metragem * custo;
            return total;
        }

        private bool ValidarCampos()
        {
            bool ret;

            if (txtMetro.Text.Trim() == string.Empty || txtCusto.Text.Trim() == string.Empty)
            {
                ret = false;
            }
            else
            {
                ret = true;
            }
            if (ret == false)
            {
                MessageBox.Show("Preencher todos os campos!");
            }

            return ret;
        }

        private void LimparCampos()
        {
            txtCusto.Clear();
            txtMetro.Clear();
            lblTotalRes.Visible = false;
            txtCusto.Focus();
        }
    }
}


