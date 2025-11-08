using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_2025.Classes
{
    public class Boletim
    {
        public Boletim(string nome, decimal nota1, decimal nota2, decimal nota3, decimal nota4)
        {
            this.Nome = nome;
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.Nota3 = nota3;
            this.Nota4 = nota4;
            this.Media = CalcularMedia(nota1, nota2, nota3, nota4);
            this.Classificacao = VerClassificacao(this.Media);

        }

        public Boletim()
        {

        }

        #region Propriedades
        public string Nome { get; set; }

        public decimal Nota1 { get; set; }

        public decimal Nota2 { get; set; }

        public decimal Nota3 { get; set; }

        public decimal Nota4 { get; set; }

        public decimal Media { get; set; }

        public string Classificacao { get; set; }

        #endregion

        #region Metodo

        public decimal CalcularMedia(decimal nota1, decimal nota2, decimal nota3, decimal nota4)
        {
            decimal media = (nota1 + nota2 + nota3 + nota4) / 4;

            return media;
        }

        public string VerClassificacao(decimal media)
        {
            string classificacao = string.Empty;

            if (media >= 0 && media < 40)
            {
                classificacao = "REPROVADO";
            }

            else if (media >= 40 && media < 60)
            {
                classificacao = "EXAME";
            }

            else if (media >= 60)
            {
                classificacao = "APROVADO";
            }

            return classificacao;
        }

        #endregion

    }
}
