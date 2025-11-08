using CSharp_2025.Classes;
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
    public partial class frmPraticaListObj : Form
    {
        public frmPraticaListObj()
        {
            InitializeComponent();
        }

        private enum EstadoTela
        {
            Novo,
            Edicao
        }

        private enum Filtro
        {
            SemFiltro = 0,
            Reprovado = 1,
            Exame = 2,
            Aprovado = 3
        }

        List<Boletim> lstBoletim = new List<Boletim>();

        int posicaoIndex = 0;


        #region Eventos do Formulário
        private void frmPraticaListObj_Load(object sender, EventArgs e)
        {
            ConfigurarEstadoTela(EstadoTela.Novo);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    string nome;
                    decimal nota1, nota2, nota3, nota4;

                    nome = txtNome.Text;
                    nota1 = Convert.ToDecimal(txtNota1.Text);
                    nota2 = Convert.ToDecimal(txtNota2.Text);
                    nota3 = Convert.ToDecimal(txtNota3.Text);
                    nota4 = Convert.ToDecimal(txtNota4.Text);
                    MessageBox.Show("Boletim cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cadastrar(nome, nota1, nota2, nota3, nota4);

                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro ao cadastrar o aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            ConfigurarEstadoTela(EstadoTela.Novo);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string nome;
                decimal nota1, nota2, nota3, nota4;

                try
                {
                    nome = txtNome.Text;
                    nota1 = Convert.ToDecimal(txtNota1.Text);
                    nota2 = Convert.ToDecimal(txtNota2.Text);
                    nota3 = Convert.ToDecimal(txtNota3.Text);
                    nota4 = Convert.ToDecimal(txtNota4.Text);
                    Alterar(nome, nota1, nota2, nota3, nota4);
                    MessageBox.Show("Boletim alterado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro ao cadastrar o aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {


        }

        private void grdAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdAlunos.Rows.Count > 0)
            {
                Boletim objLinhaClicada = (Boletim)grdAlunos.CurrentRow.DataBoundItem;

                txtNome.Text = objLinhaClicada.Nome;
                txtNota1.Text = objLinhaClicada.Nota1.ToString();
                txtNota2.Text = objLinhaClicada.Nota2.ToString();
                txtNota3.Text = objLinhaClicada.Nota3.ToString();
                txtNota4.Text = objLinhaClicada.Nota4.ToString();

                posicaoIndex = e.RowIndex;
                ConfigurarEstadoTela(EstadoTela.Edicao);
            }
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrar(cbFiltro.SelectedIndex);
        }

        #endregion

        #region Métodos Privados

        private void ConfigurarEstadoTela(EstadoTela estado)
        {
            switch (estado)
            {
                case EstadoTela.Novo:
                    btnCadastrar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                    break;

                case EstadoTela.Edicao:
                    btnCadastrar.Enabled = false;
                    btnAlterar.Enabled = true;
                    btnExcluir.Enabled = true;
                    break;
            }
        }

        private bool ValidarCampos()
        {
            bool ret = true;

            if (txtNome.Text.Trim() == string.Empty || txtNota1.Text.Trim() == string.Empty
                || txtNota2.Text.Trim() == string.Empty || txtNota3.Text.Trim() == string.Empty
                || txtNota4.Text.Trim() == string.Empty)

                ret = false;

            else

                ret = true;


            if (!ret)
                MessageBox.Show("Preencher todos os campos!");

            return ret;
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
            txtNome.Focus();
        }

        private void Alterar(string nome, decimal nota1, decimal nota2, decimal nota3, decimal nota4)
        {
            Boletim objBoletim = new Boletim();

            lstBoletim[posicaoIndex].Nome = nome;
            lstBoletim[posicaoIndex].Nota1 = nota1;
            lstBoletim[posicaoIndex].Nota2 = nota2;
            lstBoletim[posicaoIndex].Nota3 = nota3;
            lstBoletim[posicaoIndex].Nota4 = nota4;
            lstBoletim[posicaoIndex].Media = objBoletim.CalcularMedia(nota1, nota2, nota3, nota4);
            lstBoletim[posicaoIndex].Classificacao = objBoletim.VerClassificacao(lstBoletim[posicaoIndex].Media);

            CarregarBoletins();
            LimparCampos();
            ConfigurarEstadoTela(EstadoTela.Novo);
        }

        private void Cadastrar(string nome, decimal nota1, decimal nota2, decimal nota3, decimal nota4)
        {
            Boletim objBoletim = new Boletim(nome, nota1, nota2, nota3, nota4);

            objBoletim.Nome = nome;
            objBoletim.Nota1 = nota1;
            objBoletim.Nota2 = nota2;
            objBoletim.Nota3 = nota3;
            objBoletim.Nota4 = nota4;

            lstBoletim.Add(objBoletim);
            CarregarBoletins();
            LimparCampos();
            ConfigurarEstadoTela(EstadoTela.Novo);
        }

        private void CarregarBoletins()
        {
            grdAlunos.DataSource = null;
            grdAlunos.DataSource = lstBoletim;
        }

        private void Filtrar(int filtro)//pq passou como int e não passou o nome do Enum?
        {

            grdAlunos.DataSource = null;

            switch (filtro)
            {
                case (int)Filtro.Reprovado:
                    grdAlunos.DataSource = lstBoletim.Where(boletim => boletim.Classificacao == "REPROVADO").ToList();
                    break;


                case (int)Filtro.Exame:
                    grdAlunos.DataSource = lstBoletim.Where(boletim => boletim.Classificacao == "EXAME").ToList();
                    break;


                case (int)Filtro.Aprovado:
                    grdAlunos.DataSource = lstBoletim.Where(boletim => boletim.Classificacao == "APROVADO").ToList();
                    break;


                default:
                    grdAlunos.DataSource = lstBoletim;
                    break;
            }
        }

        #endregion


    }
}
