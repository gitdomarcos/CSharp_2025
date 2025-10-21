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
    public partial class frmMetodo3 : Form
    {
        public frmMetodo3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(ValidarCampos() == true)
            {
                try
                {
                    double qntd1, qntd2, qntd3, qntd4, qntd5, vlrUnit1, vlrUnit2, vlrUnit3, vlrUnit4, vlrUnit5,
                        vlrTotal1, vlrTotal2, vlrTotal3, vlrTotal4, vlrTotal5, totalPedido;

                    //Declarar as variaveis
                    qntd1 = Convert.ToDouble(txtQntd1.Text);
                    qntd2 = Convert.ToDouble(txtQntd2.Text);
                    qntd3 = Convert.ToDouble(txtQntd3.Text);
                    qntd4 = Convert.ToDouble(txtQntd4.Text);
                    qntd5 = Convert.ToDouble(txtQntd5.Text);
                    vlrUnit1 = Convert.ToDouble(txtVlrTotal1.Text);
                    vlrUnit2 = Convert.ToDouble(txtVlrTotal2.Text);
                    vlrUnit3 = Convert.ToDouble(txtVlrTotal3.Text);
                    vlrUnit4 = Convert.ToDouble(txtVlrTotal4.Text);
                    vlrUnit5 = Convert.ToDouble(txtVlrTotal5.Text);

                    //Calculos
                    vlrTotal1 = Calculo(qntd1, vlrUnit1);
                    vlrTotal2 = Calculo(qntd2, vlrUnit2);
                    vlrTotal3 = Calculo(qntd3, vlrUnit3);
                    vlrTotal4 = Calculo(qntd4, vlrUnit4);
                    vlrTotal5 = Calculo(qntd5, vlrUnit5);
                    totalPedido = TotalPedido(vlrTotal1, vlrTotal2, vlrTotal3, vlrTotal4, vlrTotal5);

                    //Exibir
                    txtVlrTotal1.Text = Convert.ToString(vlrTotal1);
                    txtVlrTotal2.Text = Convert.ToString(vlrTotal2);
                    txtVlrTotal3.Text = Convert.ToString(vlrTotal3);
                    txtVlrTotal4.Text = Convert.ToString(vlrTotal4);
                    txtVlrTotal5.Text = Convert.ToString(vlrTotal5);

                    txtTotalPedido.Text = Convert.ToString(totalPedido);
                }
                catch 
                {
                    MessageBox.Show("Valores Incorretos!");
                    LimparCampos();
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private double Calculo(double qntd, double valor)
        {
            double vlrTotal;
            vlrTotal = qntd * valor;
            return vlrTotal;
        }

        private double TotalPedido(double total1, double total2, double total3, double total4, double total5)
        {
            double totalPedido;
            totalPedido = total1 + total2 + total3 + total4 + total5;
            return totalPedido;
        }

        private bool ValidarCampos()
        {
            bool ret;

            if(txtProd1.Text.Trim() == string.Empty || Text.Trim() == string.Empty || txtProd3.Text.Trim() == string.Empty ||
                txtProd4.Text.Trim() == string.Empty || txtProd5.Text.Trim() == string.Empty || txtQntd1.Text.Trim() == string.Empty ||
                txtQntd2.Text.Trim() == string.Empty || txtQntd3.Text.Trim() == string.Empty || txtQntd4.Text.Trim() == string.Empty ||
                txtQntd5.Text.Trim() == string.Empty || txtVlrUnit1.Text.Trim() == string.Empty || txtVlrUnit2.Text.Trim() == string.Empty ||
                txtVlrUnit2.Text.Trim() == string.Empty || txtVlrUnit3.Text.Trim() == string.Empty || txtVlrUnit4.Text.Trim() == string.Empty||
                txtVlrUnit5.Text.Trim() == string.Empty)
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
            txtProd1.Clear();
            txtProd2.Clear();
            txtProd3.Clear();
            txtProd4.Clear();
            txtProd5.Clear();
            txtQntd1.Clear();
            txtQntd2.Clear();
            txtQntd3.Clear();
            txtQntd4.Clear();
            txtQntd5.Clear();
            txtVlrUnit1.Clear();
            txtVlrUnit2.Clear();
            txtVlrUnit3.Clear();
            txtVlrUnit4.Clear();
            txtVlrUnit5.Clear();
            txtVlrTotal1.Clear();
            txtVlrTotal2.Clear();
            txtVlrTotal3.Clear();
            txtVlrTotal4.Clear();
            txtVlrTotal5.Clear();
            txtTotalPedido.Clear();
            txtProd1.Focus();
        }

        private void frmMetodo3_Load(object sender, EventArgs e)
        {

        }
    }
}
