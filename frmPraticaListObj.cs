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

        List<Boletim> lstBoletim = new List<Boletim>();

        int posicaoIndex = 0;

        private void frmPraticaListObj_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
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
                ConfiguarEstadoTela(EstadoTela.Edicao);
            }
        }

        private void ConfiguarEstadoTela(EstadoTela edicao)
        {
            
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

        private void Alterar()
        {

        }
    }
}
