using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_2025.Classes
{
    public class Boletim
    {
        /// <summary>
        /// Calcula média anul do aluno
        /// </summary>
        /// <param name="nota1">Nota referente ao primeiro bim</param>
        /// <param name="nota2">Nota referente ao segundo bim</param>
        /// <param name="nota3">Nota referente ao terceiro bim</param>
        /// <param name="nota4">Nota referente ao quarto bim</param>
        /// <returns>Retorna a média anual do aluno</returns>
        public decimal CalcularMedia(decimal nota1, decimal nota2, decimal nota3, decimal nota4)
        {
            decimal media;

            media = nota1 + nota2 + nota3 + nota4 / 4;

            return media;
        }
        /// <summary>
        /// Get e Set valores DataGridView
        /// </summary>
        public string Nome {  get; set; }

        public decimal Media { get; set; }

        public decimal Nota1 { get; set; }

        public decimal Nota2 { get; set; }

        public decimal Nota3 { get; set; }

        public decimal Nota4 { get; set; }

        public string Resultado { get; set; }

    }
}
