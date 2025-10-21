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
    public partial class frmOperador3 : Form
    {
        public frmOperador3()
        {
            InitializeComponent();
        }
        private void frmOperador3_Load(object sender, EventArgs e)
        {
            lblNivel1.Visible = false;
            lblNivel2.Visible = false;
            lblNivel3.Visible = false;
            lblNivel4.Visible = false;
            lblNivel5.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtSalAtual.Text.Trim() == string.Empty || txtPorc.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher todos os campos!");
            }
            else
            //TERIA ALGUMA FORMA DE NÃO DEIXAR COLOCAR A PORCETAGEM NEGATIVA NEM O SALARIO?
            {
                try
                {
                    decimal sal, porc, salFinal, valorAumento;

                    sal = Convert.ToDecimal(txtSalAtual.Text);
                    porc = Convert.ToDecimal(txtPorc.Text);

                    salFinal = sal + (sal * porc / 100);
                    txtSalAtualizado.Text = Convert.ToString(salFinal);

                    valorAumento = salFinal - sal;

                    if (valorAumento <= 100)
                    {
                        lblNivel1.Visible = true;
                        lblNivel2.Visible = false;
                        lblNivel3.Visible = false;
                        lblNivel4.Visible = false;
                        lblNivel5.Visible = false;
                    }
                        
                    else if (valorAumento <= 200)
                    {
                        lblNivel1.Visible = false;
                        lblNivel2.Visible = true;
                        lblNivel3.Visible = false;
                        lblNivel4.Visible = false;
                        lblNivel5.Visible = false;
                    }

                    else if(valorAumento <= 300)
                    {
                        lblNivel1.Visible = false;
                        lblNivel2.Visible = false;
                        lblNivel3.Visible = true;
                        lblNivel4.Visible = false;
                        lblNivel5.Visible = false;
                    }

                    else if (valorAumento <= 400)
                    {
                        lblNivel1.Visible = false;
                        lblNivel2.Visible = false;
                        lblNivel3.Visible = false;
                        lblNivel4.Visible = true;
                        lblNivel5.Visible = false;
                    }

                    else if (valorAumento > 400)
                    {
                        lblNivel1.Visible = false;
                        lblNivel2.Visible = false;
                        lblNivel3.Visible = false;
                        lblNivel4.Visible = false;
                        lblNivel5.Visible = true;
                    }
                }
                catch 
                {
                    MessageBox.Show("Número inválidos!");
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSalAtual.Clear();
            txtPorc.Clear();
            txtSalAtualizado.Clear();
            lblNivel1.Visible = false;
            lblNivel2.Visible = false;
            lblNivel3.Visible = false;
            lblNivel4.Visible = false;
            lblNivel5.Visible = false;
            txtSalAtual.Focus();
        }

    }
}
