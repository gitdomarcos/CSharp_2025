using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharp_2025.Classes;

namespace CSharp_2025
{
    public partial class frmPooAtributo3 : Form
    {
        public frmPooAtributo3()
        {
            InitializeComponent();
        }

        List<Viagem> lstViagem = new List<Viagem>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string passageiro, destino, data, valor;

            passageiro = txtPassageiro.Text;
            destino = txtDestino.Text;
            data = dtpData.Text;
            //como deixar o campo valor somente para receber números com casa decimal
            valor = txtValor.Text;

            Cadastrar(passageiro, destino, data, valor);
           
        }

        private void Cadastrar(string passageiro, string destino, string data, string valor)
        {
            Viagem objViagem = new Viagem(destino);

            objViagem.Passageiro = passageiro;
            objViagem.Data = data;
            objViagem.Valor = valor;

            lstViagem.Add(objViagem);
            CarregarViagens();
            LimparCampos();
        }

        private void CarregarViagens()
        {
            grdViagens.DataSource = null;
            grdViagens.DataSource = lstViagem;
        }

        private void LimparCampos()
        {
            txtPassageiro.Clear();
            txtDestino.Clear();
            txtValor.Clear();
            txtPassageiro.Focus();
            //como fazer para voltar a data para o dia atual?
        }
    }
}
