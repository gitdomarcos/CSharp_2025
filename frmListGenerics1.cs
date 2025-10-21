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
    public partial class frmListGenerics1 : Form
    {
        public frmListGenerics1()
        {
            InitializeComponent();
        }

        List<string> lstNomePrato = new List<string>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(ValidarCampo() == true)
            {
                string nome;

                try
                {
                    nome = txtNomePrato.Text;
                    AddNome(nome);
                    MostrarNome();
                    Limpar();
                }
                catch 
                {
                    MessageBox.Show("Deu PAUUUUU");
                    Limpar();
                }

            }
        }

        private bool ValidarCampo()
        {
            bool flag = true;

            if(txtNomePrato.Text.Trim() == string.Empty)
            {
                flag = false;
            }
            else
            {
                flag = true;
            }
            if (flag == false)
            {
                MessageBox.Show("Preencher todos os campos!");
            }

            return flag;
        }

        private void AddNome(string nome)
        {
            lstNomePrato.Add(nome);
        }

        private void MostrarNome()
        {
            listBoxNomePrato.DataSource = null;
            listBoxNomePrato.DataSource = lstNomePrato;
        }

        private void Limpar()
        {
            txtNomePrato.Clear();
        }
    }
}
