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
    public partial class frmPooAtributo1 : Form
    {
        public frmPooAtributo1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Setor obj = new Setor();

            try
            {
                string coordenador, lider, setores, colaboradores;

                coordenador = txtNomeCoordenador.Text;
                lider = txtNomeLider.Text;
                setores = txtNomeSetor.Text;
                colaboradores = txtQntdColaboradores.Text;

                MessageBox.Show($"Coordenador: {coordenador} \nLider: {lider} \nSetor: {setores} \nQnt Colaboradores: {colaboradores}");
            }
            catch 
            {
                MessageBox.Show("Algo deu errado!");
            }

        }
    }
}
