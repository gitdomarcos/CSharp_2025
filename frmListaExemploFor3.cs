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
    public partial class frmListaExemploFor3 : Form
    {
        public frmListaExemploFor3()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Aula 08.3 - Prática de List Generic com For - Exemplo 3
        /// Encerrada em 20:28
        /// </summary>

        private enum Validacao
        {
            Adicao,
            Filtro
        }

        private enum Filtro
        {
            Maior,
            Menor
        }

        List<double> lstSalariosFinal = new List<double>();
        List<string> lstResultadoFiltro = new List<string>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidarCampos(Validacao.Adicao))
            {
                double salario, porc, salarioFinal;
                try
                {
                    salario = Convert.ToDouble(txtValor.Text);
                    porc = Convert.ToDouble(txtPorc.Text);
                    salarioFinal = CalcularSalario(salario, porc);
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
                    valorPesquisa = Convert.ToDouble(txtValorPesquisar.Text);
                    if(cbFiltro.SelectedIndex == 0)
                    {
                        Pesquisar(Filtro.Maior, valorPesquisa);
                    }
                    else
                    {
                        Pesquisar(Filtro.Menor, valorPesquisa);
                    }
                    CarregarResultado();
                }
                catch
                {
                    MessageBox.Show("Digitar os valores corretamente!");
                }
            }
        }

        private bool ValidarCampos(Validacao validacao)
        {
            bool flag = true;

            switch (validacao)
            {
                case Validacao.Adicao:
                    if (txtPorc.Text.Trim() == string.Empty || txtValor.Text.Trim() == string.Empty)
                    {
                        flag = false;
                        
                    }

                    break;
                case Validacao.Filtro:
                    if(txtValorPesquisar.Text.Trim() == string.Empty || cbFiltro.SelectedIndex == -1)
                    {
                        flag = false;
                    }
                    break;

            }

            if (!flag)
            {
                MessageBox.Show("Preencher todos os campos!");
            }
            return flag;
        }

        private double CalcularSalario(double salario, double porc)
        {
            double salarioFinal;

            salarioFinal = salario + (salario * porc) / 100;

            return salarioFinal;
        }

        private void AddSalarioFinal(double salarioFinal)
        {
            lstSalariosFinal.Add(salarioFinal);
        }

        private void CarregarSalarios()
        {
            listSalarioBox.DataSource = null;
            listSalarioBox.DataSource = lstSalariosFinal;
        }

        private void LimparCampos()
        {
            txtPorc.Clear();
            txtValor.Clear();
            txtValor.Focus();
        }

        private void Pesquisar(Filtro filtro, double valorPesquisado)
        {
            switch (filtro)
            {
                case Filtro.Maior:
                    for (int i = 0; i < lstSalariosFinal.Count; i++)
                    {
                        if (lstSalariosFinal[i] > valorPesquisado)
                        {
                            AdicionarResultadoLista(i, lstSalariosFinal[i]);
                        }
                    }
                    break;
                case Filtro.Menor:
                    for (int i = 0; i < lstSalariosFinal.Count; i++)
                    {
                        if (lstSalariosFinal[i] < valorPesquisado)
                        {
                            AdicionarResultadoLista(i, lstSalariosFinal[i]);
                        }
                    }
                    break;
               
            }
            
        }

        private void AdicionarResultadoLista(int posicao, double valorEncontrado)
        {
            lstResultadoFiltro.Add($"Valor encontrado: {valorEncontrado} na posição {posicao}");
        }

        private void CarregarResultado()
        {
            if(lstResultadoFiltro.Count == 0)
            {
                MessageBox.Show("Não foi encontrado nenhum valor!");
            }

            listResultadoBox.DataSource = null;
            listResultadoBox.DataSource = lstResultadoFiltro;
            lstResultadoFiltro.Clear();
        }
    }
}
