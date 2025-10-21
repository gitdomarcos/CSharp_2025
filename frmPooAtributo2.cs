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

        List<Escola> lstLista = new List<Escola>();

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
            grdListaCadastro.DataSource = null;
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
    }
}
