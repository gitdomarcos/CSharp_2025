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
    public partial class frmLinq2 : Form
    {
        public frmLinq2()
        {
            InitializeComponent();
        }

        private enum Validacao
        {
            Adicao,
            Pesquisa
        }

        private enum Genero
        {
            Ficcao,
            NaoFiccao,
            Romance
        }

        private enum Posicao
        {
            ACIMA,
            IGUAL,
            ABAIXO
        }

        List<int> lstFiccao = new List<int>();
        List<int> lstNaoFiccao = new List<int>();
        List<int> lstRomance = new List<int>();


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidarCampos(Validacao.Adicao))
            {
                int paginas = Convert.ToInt32(txtPaginas.Text);
                Genero genero = (Genero)cbGeneroAdd.SelectedIndex;

                try
                {
                    AddLista(genero, paginas);
                    CarregarLista(genero);
                }
                catch 
                {
                    MessageBox.Show("Informações inválidas!");
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
                    int paginas = Convert.ToInt32(txtPagPesq.Text);
                    Genero genero = (Genero)cbGeneroPesq.SelectedIndex;
                    Posicao posicao = (Posicao)cbPosicao.SelectedIndex;

                    CarregarFiltro(genero, paginas, posicao);
                }
                catch 
                {
                    MessageBox.Show("Informações inválidas!");
                }
            }
        }

        private bool ValidarCampos(Validacao validacao)
        {
            bool flag = true;

            switch (validacao)
            {
                case Validacao.Adicao:
                    if (txtPaginas.Text.Trim() == string.Empty || cbGeneroAdd.SelectedIndex == -1)
                        flag = false;
                    break;

                case Validacao.Pesquisa:
                    if (txtPagPesq.Text.Trim() == string.Empty || cbGeneroPesq.SelectedIndex == -1 || cbPosicao.SelectedIndex == -1)
                        flag = false;
                    break;
            }

            if (!flag)
                MessageBox.Show("Preencher os campos!");

            return flag;
        }

        private void AddLista(Genero genero, int paginas)
        {
            switch (genero)
            {
                case Genero.Ficcao:
                    lstFiccao.Add(paginas);
                    break;

                case Genero.NaoFiccao:
                    lstNaoFiccao.Add(paginas);
                    break;

                case Genero.Romance:
                    lstRomance.Add(paginas);
                    break;
            }
        }

        private void CarregarLista(Genero genero)
        {
            switch (genero)
            {
                case Genero.Ficcao:
                    listBoxFiccao.DataSource = null;
                    listBoxFiccao.DataSource = lstFiccao;
                    break;

                case Genero.NaoFiccao:
                    listBoxNaoFiccao.DataSource = null;
                    listBoxNaoFiccao.DataSource = lstNaoFiccao;
                    break;

                case Genero.Romance:
                    listBoxRomance.DataSource = null;
                    listBoxRomance.DataSource = lstRomance;
                    break;
            }
        }

        private void CarregarFiltro(Genero genero, int paginas, Posicao posicao)
        {
            switch (genero)
            {
                case Genero.Ficcao:
                    switch (posicao)
                    {
                        case Posicao.ACIMA:
                            listBoxFiccao.DataSource = lstFiccao.Where(item => item > paginas).ToList();
                            break;

                        case Posicao.IGUAL:
                            listBoxFiccao.DataSource = lstFiccao.Where(item => item == paginas).ToList();
                            break;

                        case Posicao.ABAIXO:
                            listBoxFiccao.DataSource = lstFiccao.Where(item => item < paginas).ToList();
                            break;
                    }
                    break;

                case Genero.NaoFiccao:
                    switch (posicao)
                    {
                        case Posicao.ACIMA:
                            listBoxNaoFiccao.DataSource = lstFiccao.Where(item => item > paginas).ToList();
                            break;

                        case Posicao.IGUAL:
                            listBoxNaoFiccao.DataSource = lstFiccao.Where(item => item == paginas).ToList();
                            break;

                        case Posicao.ABAIXO:
                            listBoxNaoFiccao.DataSource = lstFiccao.Where(item => item < paginas).ToList();
                            break;
                    }
                    break;

                case Genero.Romance:
                    switch (posicao)
                    {
                        case Posicao.ACIMA:
                            listBoxRomance.DataSource = lstRomance.Where(item => item > paginas).ToList();
                            break;

                        case Posicao.IGUAL:
                            listBoxRomance.DataSource = lstRomance.Where(item => item == paginas).ToList();
                            break;

                        case Posicao.ABAIXO:
                            listBoxRomance.DataSource = lstRomance.Where(item => item < paginas).ToList();
                            break;
                    }
                    break;
            }
        }
    }
}
