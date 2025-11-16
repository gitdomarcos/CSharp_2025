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
    public partial class frmListGenerics2 : Form
    {
        public frmListGenerics2()
        {
            InitializeComponent();
        }

        private enum Validacao
        {
            Adicao,
            Filtro
        }

        private enum Categoria
        {
            MoscaLigeiro,
            Mosca,
            Galo,
            Pena,
            Leve
        }

        List<string> lstNome = new List<string>();
        List<double> lstPeso = new List<double>();
        List<string> lstCategoria = new List<string>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (VerificarCampos(Validacao.Adicao))
            {
                string nome; //categoria;
                double peso;


                try
                {
                    nome = Convert.ToString(txtNome.Text);
                    peso = Convert.ToDouble(txtPeso.Text);
                    //AddLista(nome, peso);
                    AddCategoria(Categoria.MoscaLigeiro, peso, nome);
                    AddCategoria(Categoria.Mosca, peso, nome);
                    AddCategoria(Categoria.Galo, peso, nome);
                    AddCategoria(Categoria.Pena, peso, nome);
                    AddCategoria(Categoria.Leve, peso, nome);
                    CarregarLista();
                    LimparCampos();

                }
                catch
                {
                    MessageBox.Show("Preencher os campos corretamente!");
                }

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private bool VerificarCampos(Validacao validacao)
        {
            bool flag = true;

            switch (validacao)
            {
                case Validacao.Adicao:
                    if (txtNome.Text.Trim() == string.Empty || txtPeso.Text.Trim() == string.Empty)
                    {
                        flag = false;
                        MessageBox.Show("Preencher todos os campos!");
                    }
                    break;
                case Validacao.Filtro:
                    if (cbPesquisa.SelectedIndex == -1)
                    {
                        flag = false;
                        MessageBox.Show("Selecionar alguma das opções!");
                    }
                    break;

            }

            return flag;
        }

        private void AddLista(string nome, double peso)
        {
            lstNome.Add(nome);
            lstPeso.Add(peso);
            //lstCategoria.Add();
        }

        private void CarregarLista()
        {
            listBoxNome.DataSource = null;
            listBoxNome.DataSource = lstNome;

            listBoxPeso.DataSource = null;
            listBoxPeso.DataSource = lstPeso;

            listBoxCategoria.DataSource = null;
            listBoxCategoria.DataSource = lstCategoria;
        }

        private void AddCategoria(Categoria categoria, double peso, string nome)
        {
            switch (categoria)
            {
                case Categoria.MoscaLigeiro:
                    if (peso >= 0 || peso <= 48)
                    {
                        lstCategoria.Add("Mosca Ligeiro");
                        lstNome.Add(nome);
                        lstPeso.Add(peso);
                    }
                    break;
                case Categoria.Mosca:
                    if (peso > 49 || peso <= 51)
                    {
                        lstCategoria.Add("Mosca");
                        lstNome.Add(nome);
                        lstPeso.Add(peso);
                    }
                    break;
                case Categoria.Galo:
                    if (peso > 52 || peso <= 54)
                    {
                        lstCategoria.Add("Galo");
                        lstNome.Add(nome);
                        lstPeso.Add(peso);
                    }
                    break;
                case Categoria.Pena:
                    if (peso > 55 || peso <= 57)
                    {
                        lstCategoria.Add("Pena");
                        lstNome.Add(nome);
                        lstPeso.Add(peso);
                    }
                    break;
                case Categoria.Leve:
                    if (peso > 58 || peso <= 60)
                    {
                        lstCategoria.Add("Leve");
                        lstNome.Add(nome);
                        lstPeso.Add(peso);
                    }
                    break;

                default:
                    if (peso > 60)
                    {
                        MessageBox.Show("Lutador acima do peso permitido!");
                    }
                    break;

            }

        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtPeso.Clear();
            txtNome.Focus();
        }
    }
}
