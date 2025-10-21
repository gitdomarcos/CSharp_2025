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
        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeAnimal.Text;
            string especie = txtEspecie.Text;
            double peso = Convert.ToDouble(txtPeso.Text);
            
            Cadastrar(nome, especie, peso);
            CarregarLista();
        }

        private void Cadastrar(string nome, string especie, double peso)
        {
            Animal objAnimal = new Animal();

            objAnimal.Nome = nome;

            objAnimal.InserirEspecie(especie);
            bool validarPeso = objAnimal.InserirPeso(peso);

            if (validarPeso)
                lstAnimais.Add(objAnimal);
            else
                MessageBox.Show("Errado");
        }

        private void CarregarLista()
        {
            grdLista.DataSource = null;
            grdLista.DataSource = lstAnimais;
        }
    }
}
