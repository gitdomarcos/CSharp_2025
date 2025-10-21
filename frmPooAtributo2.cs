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
    public partial class frmPooAtributo2 : Form
    {
        public frmPooAtributo2()
        {
            InitializeComponent();
        }

        private enum EstadoTela
        {
            Novo,
            Edicao
        }

        List<Escola> lstLista = new List<Escola>();

        int posicaoIndex = 0;

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(ValidarCampos() == true)
            {
                try
                {
                    string escola, diretor;
                    int qntdProf, qntdAluno;

                    escola = txtNomeEscola.Text;
                    diretor = txtNomeDiretor.Text;
                    qntdProf = Convert.ToInt32(txtQntdProf.Text);
                    qntdAluno = Convert.ToInt32(txtQntdAlunos.Text);

                    Cadastrar(escola, diretor, qntdProf, qntdAluno);

                }
                catch 
                {
                    MessageBox.Show("Informações incorretas!");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            ConfigurarEstadoTela(EstadoTela.Novo);
            //grdListaCadastro.DataSource = null;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Alterar();
                CarregarLista();
                LimparCampos();
                ConfigurarEstadoTela(EstadoTela.Novo);
            }
        }

        private void ConfigurarEstadoTela(EstadoTela tela)
        {
            switch (tela)
            {
                case EstadoTela.Novo:
                    btnCadastrar.Enabled = true;
                    btnAlterar.Enabled = false;
                    break;

                case EstadoTela.Edicao:
                    btnCadastrar.Enabled = false;
                    btnAlterar.Enabled = true;
                    break;
            }
        }

        private bool ValidarCampos()
        {
            bool ret;

            if (txtNomeEscola.Text.Trim() == string.Empty || txtNomeDiretor.Text.Trim() == string.Empty
                || txtQntdProf.Text.Trim() == string.Empty || txtQntdAlunos.Text.Trim() == string.Empty)
                ret = false;
            else 
                ret = true;

            if (ret == false)
                MessageBox.Show("Preencher todos os campos!");

                return ret;
        }

        private void LimparCampos()
        {
            txtNomeEscola.Clear();
            txtNomeDiretor.Clear();
            txtQntdProf.Clear();
            txtQntdAlunos.Clear();
            txtNomeEscola.Focus();
        }

        private void Cadastrar(string escola, string diretor, int qntdProf, int qntdAluno)
        {
            Escola objLista = new Escola();

            objLista.NomeEscola = escola;
            objLista.NomeDiretor = diretor;
            objLista.QntdProf = qntdProf;
            objLista.QntdAluno = qntdAluno;

            lstLista.Add(objLista);
            CarregarLista();
            LimparCampos();
        }

        private void CarregarLista()
        {
            grdListaCadastro.DataSource = null;
            grdListaCadastro.DataSource = lstLista;
        }

        private void grdListaCadastro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Verifica se tem item dentro da grd
            if(grdListaCadastro.RowCount > 0)
            {
                Escola objCadastro = (Escola) grdListaCadastro.CurrentRow.DataBoundItem;

                txtNomeEscola.Text = objCadastro.NomeEscola;
                txtNomeDiretor.Text = objCadastro.NomeDiretor;
                txtQntdProf.Text = Convert.ToString(objCadastro.QntdProf);
                txtQntdAlunos.Text = Convert.ToString(objCadastro.QntdAluno);
                //Marca o index na linha clicada
                posicaoIndex = e.RowIndex;
                ConfigurarEstadoTela(EstadoTela.Edicao);
            }
        }

        private void Alterar()
        {
            lstLista[posicaoIndex].NomeEscola = txtNomeEscola.Text;
            lstLista[posicaoIndex].NomeDiretor = txtNomeDiretor.Text;
            lstLista[posicaoIndex].QntdProf = Convert.ToInt32(txtQntdProf.Text);
            lstLista[posicaoIndex].QntdAluno = Convert.ToInt32(txtQntdAlunos.Text);

        }

        private void frmPooAtributo2_Load(object sender, EventArgs e)
        {
            ConfigurarEstadoTela(EstadoTela.Novo);
        }
    }
}
