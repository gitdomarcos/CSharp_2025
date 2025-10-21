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
    public partial class frmLinq1 : Form
    {
        public frmLinq1()
        {
            InitializeComponent();
        }

        private enum Validacao
        {
            Adicacao,
            Pesquisa
        }

        private enum Direcao
        {
            ACIMA,
            ABAIXO,
            IGUAL
        }

        private enum Marca
        {
            Adidas,
            Nike
        }

        List<int> lstAdidas = new List<int>();
        List<int> lstNike = new List<int>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidarCampos(Validacao.Adicacao))
            {
                int tamanho = Convert.ToInt32(txtNumCalcado.Text);
                Marca marca = (Marca)cbMarcaAdd.SelectedIndex;

                try
                {
                    AddLista(marca, tamanho);
                    CarregarLista(marca);

                }
                catch 
                {
                    MessageBox.Show("ERROUUUUU");
                }
               
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos(Validacao.Pesquisa))
            {
                try
                {
                    int tamanho = Convert.ToInt32(txtNumPesquisa.Text);
                    Marca marca = (Marca)cbMarcaPesquisa.SelectedIndex;
                    Direcao direcao = (Direcao)cbDirecao.SelectedIndex;

                    CarregarFiltro(marca, tamanho, direcao);
                }
                catch 
                {
                    MessageBox.Show("ERROU DENOVO");
                }
            }
        }

        private bool ValidarCampos(Validacao validacao)
        {
            bool flag = true;

            switch (validacao)
            {
                case Validacao.Adicacao:
                    if(txtNumCalcado.Text.Trim() == string.Empty || cbMarcaAdd.SelectedIndex == -1)
                        flag = false;
                    break;
                case Validacao.Pesquisa:
                    if (cbMarcaPesquisa.SelectedIndex == -1 || txtNumPesquisa.Text.Trim() == string.Empty
                        || cbDirecao.SelectedIndex == -1)
                        flag = false;
                    break;
       
            }

            if (!flag)
                MessageBox.Show("Preencher os campos!");

            return flag;
        }

        private void AddLista(Marca marca, int tamanho)
        {
            switch (marca)
            {
                case Marca.Adidas:
                    lstAdidas.Add(tamanho);
                    break;

                case Marca.Nike:
                    lstNike.Add(tamanho);
                    break;

            }
        }

        private void CarregarLista(Marca marca)
        {
            switch (marca)
            {
                case Marca.Adidas:
                    listBoxAdidas.DataSource = null;
                    listBoxAdidas.DataSource = lstAdidas;
                    break;

                case Marca.Nike:
                    listBoxNike.DataSource = null;
                    listBoxNike.DataSource = lstNike;
                    break;
            }
        }

        private void CarregarFiltro(Marca marcaPesquisa, int tamanho, Direcao direcao)
        {
            switch (marcaPesquisa)
            {
                case Marca.Adidas:

                    switch (direcao)
                    {
                        case Direcao.ACIMA:
                            listBoxAdidas.DataSource = lstAdidas.Where(item => item > tamanho).ToList();
                            break;

                        case Direcao.ABAIXO:
                            listBoxAdidas.DataSource = lstAdidas.Where(item => item < tamanho).ToList();
                            break;

                        case Direcao.IGUAL:
                            listBoxAdidas.DataSource = lstAdidas.Where(item => item == tamanho).ToList();
                            break;

                    }

                    break;

                case Marca.Nike:
                    switch (direcao)
                    {
                        case Direcao.ACIMA:
                            listBoxNike.DataSource = lstNike.Where(item => item > tamanho).ToList();
                            break;

                        case Direcao.ABAIXO:
                            listBoxNike.DataSource = lstNike.Where(item => item < tamanho).ToList();
                            break;

                        case Direcao.IGUAL:
                            listBoxNike.DataSource = lstNike.Where(item => item == tamanho).ToList();
                            break;
                    }

                    break;

            }
        }
    }
}
