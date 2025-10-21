using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_2025.Classes
{
    public class Escola
    {
        public Escola(string escola, string diretor, int qntdProf, int qntdAlunos)
        {
            this.NomeEscola = escola;
            this.NomeDiretor = diretor;
            this.QntdProf = qntdProf;
            this.QntdAluno = qntdAlunos;
        }

        public Escola()
        {

        }

        public string NomeEscola { get; set; }

        public string NomeDiretor { get; set; }

        public int QntdProf { get; set; }

        public int QntdAluno { get; set; }
    }
}
