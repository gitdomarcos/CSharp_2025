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
    public partial class frmLinqConsulta : Form
    {
        public frmLinqConsulta()
        {
            InitializeComponent();
        }

        private enum Validacao
        {
            Adicao,
            Filtro
        }

        private enum Filtro
        {
            Maior,
            Menor,
            Igual
        }

        List<double> lstSalarioFinal = new List<double>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidarCampos(Validacao.Adicao))
            {
                double salario, porcentagem, salarioFinal;

                try
                {
                    salario = Convert.ToDouble(txtValor.Text);
                    porcentagem = Convert.ToDouble(txtPorcentagem.Text);
                    salarioFinal = CalcularSalario(salario, porcentagem);
                    AddSalarioFinal(salarioFinal);
                    CarregarSalarios();
                    LimparCampos();
                }
                catch
                {
                    MessageBox.Show("Digitar os valores corretamente!");
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos(Validacao.Filtro))
            {
                double valorPesquisa;

                try
                {
                    valorPesquisa = Convert.ToDouble(txtPesquisa.Text);

                    switch (cbPesquisa.SelectedIndex)
                    {
                        case 0:
                            PesquisarLinqMetodo(Filtro.Maior, valorPesquisa);
                            break;

                        case 1:
                            PesquisarLinqMetodo(Filtro.Menor, valorPesquisa);
                            break;

                        case 2:
                            PesquisarLinqMetodo(Filtro.Igual, valorPesquisa);
                            break;
                    }
                }
                catch
                {
                    MessageBox.Show("Aconteceu algo errado que não esta certo!");
                }
            }
        }

        private void CarregarSalarios()
        {
            listBoxSalarios.DataSource = null;
            listBoxSalarios.DataSource = lstSalarioFinal;
        } 

        private void AddSalarioFinal(double salarioFinal)
        {
            lstSalarioFinal.Add(salarioFinal);
        }

        private double CalcularSalario(double salario, double porc)
        {
            double salarioFinal;

            salarioFinal = salario + (salario + porc) / 100;

            return salarioFinal;
        }

        private bool ValidarCampos(Validacao validacao)
        {
            bool flag = true;

            switch (validacao)
            {
                case Validacao.Adicao:
                    if(txtValor.Text.Trim() == string.Empty ||
                        txtPorcentagem.Text.Trim() == string.Empty)
                    {
                        flag = false;
                    }
                    break;


                case Validacao.Filtro:
                    if(txtPesquisa.Text.Trim() == string.Empty ||
                        cbPesquisa.SelectedIndex == -1)
                    {
                        flag = false;
                    }
                    break;

            }

            if (!flag)
                MessageBox.Show("Preencher todos os campos!");

            return flag;
        }

        private void LimparCampos()
        {
            txtValor.Clear();
            txtPorcentagem.Clear();
            txtValor.Focus();
            txtPesquisa.Clear();
            cbPesquisa.SelectedIndex = -1;

        }

        private void PesquisarLinq(Filtro filtro, double valorPesquisa)
        {
            listBoxSalarios.DataSource = null;

            switch (filtro)
            {
                case Filtro.Maior:
                    listBoxSalarios.DataSource = (from salario in lstSalarioFinal
                                                  where salario > valorPesquisa
                                                  select salario).ToList();
                    break;


                case Filtro.Menor:
                    listBoxSalarios.DataSource = (from salario in lstSalarioFinal
                                                  where salario < valorPesquisa
                                                  select salario).ToList();
                    break;


                case Filtro.Igual:
                    listBoxSalarios.DataSource = (from salario in lstSalarioFinal
                                                  where salario == valorPesquisa
                                                  select salario).ToList();
                    break;
            }
        }

        private void PesquisarLinqMetodo(Filtro filtro, double valorPesquisa)
        {
            listBoxSalarios.DataSource = null;

            switch (filtro)
            {
                case Filtro.Maior:
                    listBoxSalarios.DataSource = lstSalarioFinal
                        .Where(salario => salario > valorPesquisa).ToList();
                    break;


                case Filtro.Menor:
                    listBoxSalarios.DataSource = lstSalarioFinal
                         .Where(salario => salario < valorPesquisa).ToList();
                    break;


                case Filtro.Igual:
                    listBoxSalarios.DataSource = lstSalarioFinal
                                             .Where(salario => salario == valorPesquisa).ToList();
                    break;
            }
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            listBoxSalarios.DataSource = null;
        }
    }
}
