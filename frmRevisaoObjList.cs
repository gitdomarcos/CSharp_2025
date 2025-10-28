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
    public partial class frmRevisaoObjList : Form
    {
        public frmRevisaoObjList()
        {
            InitializeComponent();
        }

        List<Animal> lstAnimais = new List<Animal>();

        int posicaoIndex = 0;

        private enum EstadoTela
        {
            Novo,
            Edicao
        }


        private void frmRevisaoObjList_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeAnimal.Text;
            string especie = txtEspecie.Text;
            double peso = Convert.ToDouble(txtPeso.Text);

            Cadastrar(nome, especie, peso);
            CarregarLista();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            ConfigurarEstadoTela(EstadoTela.Novo);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
            ConfigurarEstadoTela(EstadoTela.Novo);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeAnimal.Text;
            string especie = txtEspecie.Text;
            double peso = Convert.ToDouble(txtPeso.Text);

            Alterar(nome, especie, peso);
            LimparCampos();
            CarregarLista();
            ConfigurarEstadoTela(EstadoTela.Novo);
        }

        private void grdLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Verifica se existe linha
            if (grdLista.RowCount > 0)
            {
                //Recupera o obj da linha clicada
                var objLinhaClicada = (Animal)grdLista.CurrentRow.DataBoundItem;

                //Preencher os campos (primeiro identifica o campo que cada obj vai popular e depois recupera a informação)
                txtNomeAnimal.Text = objLinhaClicada.Nome;
                txtEspecie.Text = objLinhaClicada.Especie;
                txtPeso.Text = Convert.ToString(objLinhaClicada.Peso);

                //Marca o Index
                posicaoIndex = e.RowIndex;

                ConfigurarEstadoTela(EstadoTela.Edicao);
            }
        }



        #region Métodos

        private void Cadastrar(string nome, string especie, double peso)
        {
            Animal objAnimal = new Animal();

            objAnimal.Nome = nome;

            objAnimal.InserirEspecie(especie);
            //bool validarPeso = objAnimal.InserirPeso(peso);

            if (objAnimal.InserirPeso(peso))
                lstAnimais.Add(objAnimal);
            else
                MessageBox.Show("Peso incorreto!");
        }

        private void CarregarLista()
        {
            grdLista.DataSource = null;
            grdLista.DataSource = lstAnimais;
        }

        private void LimparCampos()
        {
            txtNomeAnimal.Clear();
            txtEspecie.Clear();
            txtPeso.Clear();
            txtNomeAnimal.Clear();
        }

        private void Alterar(string nome, string especie, double peso)
        {
            if (lstAnimais[posicaoIndex].InserirPeso(peso))
            {
                lstAnimais[posicaoIndex].Nome = nome;
                lstAnimais[posicaoIndex].InserirEspecie(especie);
            }
        }

        private void Excluir()
        {
            lstAnimais.RemoveAt(posicaoIndex);
        }

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
        #endregion

    }
}
