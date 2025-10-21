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
    public partial class frmMetodo1 : Form
    {
        public frmMetodo1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(ValidarCampos() == true)
            {
                try
                {
                    double vlr1, vlr2, vlr3, vlr4, vlr5, calculo1, calculo2, total;

                    //declarando as variaveis
                    vlr1 = Convert.ToDouble(txtVlr1.Text);
                    vlr2 = Convert.ToDouble(txtVlr2.Text);
                    vlr3 = Convert.ToDouble(txtVlr3.Text);
                    vlr4 = Convert.ToDouble(txtVlr4.Text);
                    vlr5 = Convert.ToDouble(txtVlr5.Text);

                    //calculos
                    calculo1 = Calculo1(vlr1, vlr2, vlr3);
                    calculo2 = Calculo2(vlr4, vlr5);
                    total = ValorFinal(calculo1, calculo2);

                    //exibir
                    txtTotal.Text = Convert.ToString(total);
                }
                catch 
                {
                    MessageBox.Show("Erro na digitação!");
                    LimparCampos();
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private Double Calculo1(double vlr1, double vlr2, double vlr3)
        {
            double resultado;
            resultado = vlr1 + vlr2 + vlr3;
            return resultado;
        }

        private Double Calculo2(double vlr4, double vlr5)
        {
            double resultado;
            resultado = vlr4 + vlr5;
            return resultado;
        }

        private Double ValorFinal(double calculo1, double calculo2)
        {
            double totalmult;
            totalmult = calculo1 * calculo2;
            return totalmult;
        }

        private bool ValidarCampos()
        {
            bool ret;
            if(txtVlr1.Text.Trim() == string.Empty ||
                txtVlr2.Text.Trim() == string.Empty ||
                txtVlr3.Text.Trim() == string.Empty ||
                txtVlr4.Text.Trim() == string.Empty ||
                txtVlr5.Text.Trim() == string.Empty)
            {
                ret = false;
            }
            else
            {
                ret = true;
            }
            if(ret == false)
            {
                MessageBox.Show("Preencher todos os campos!");
            }

            return ret;
        }

        private void LimparCampos()
        {
            txtVlr1.Clear();
            txtVlr2.Clear();
            txtVlr3.Clear();
            txtVlr4.Clear();
            txtVlr5.Clear();
            txtTotal.Clear();
            txtVlr1.Focus();
        }
    }
}
