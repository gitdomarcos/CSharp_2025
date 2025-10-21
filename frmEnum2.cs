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
    public partial class frmEnum2 : Form
    {
        public frmEnum2()
        {
            InitializeComponent();
        }

        private enum Prioridade
        {
            Baixa = 0,
            Media = 1,
            Alta = 2
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string retorno = RetornarCalculoData(dtpData.Value.Date, (Prioridade)cbPrioridades.SelectedIndex);
            MessageBox.Show($"Resultado final: {retorno}");
        }

        private string RetornarCalculoData(DateTime data, Prioridade prioridade)
        {

            string resposta = string.Empty;

            switch (prioridade)
            {
                case Prioridade.Baixa:
                    resposta = data.AddDays(3).ToShortDateString();
                    break;
                case Prioridade.Media:
                    resposta = data.AddDays(7).ToShortDateString();
                    break;
                case Prioridade.Alta:
                    resposta = data.AddDays(12).ToShortDateString();
                    break;
            }

            return resposta;
        }
    }
}
