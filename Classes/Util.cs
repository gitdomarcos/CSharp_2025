using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_2025.Classes
{
    public static class Util
    {
        public enum EstadoTela
        {
            Novo,
            Edicao
        }

        public static void ConfigurarEstadoTela(Util.EstadoTela tela, Button btnCadastrar, Button btnCancelar, Button btnAlterar, Button btnExcluir)
        {
            switch (tela)
            {
                case EstadoTela.Novo:
                    btnCadastrar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                    break;

                case EstadoTela.Edicao:
                    btnCadastrar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnAlterar.Enabled = true;
                    btnExcluir.Enabled = true;
                    break;
            }
        }

        public static string pathFileXml = @"C:\Users\marca\OneDrive\Área de Trabalho\C Sharp\2025\LogicaProgramação\Arquivo XML\Armazenagem.xml";
    }
}
