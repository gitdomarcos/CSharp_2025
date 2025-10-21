using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_2025.Classes
{
    internal class Calculo
    {
        /// <summary>
        /// Calcula o valor final do aumento
        /// </summary>
        /// <param name="valor">Valor do usuario</param>
        /// <param name="porcentagem">Valor da porcentagem de aumento</param>
        /// <returns>Retorna o valor final do aumento</returns>
        public double CalcularAumentoPorcentagem(double valor, double porcentagem)
        {
            double resposta;

            resposta = valor + (valor + porcentagem) / 100;

            return resposta;
        }

        /// <summary>
        /// Calcula o valor final do desconto
        /// </summary>
        /// <param name="valor">Valor do usuario</param>
        /// <param name="porcentagem">Valor da porcentagem de desconto</param>
        /// <returns>Retorna o valor final com desconto</returns>
        public double CalcularDescontoPorcentagem(double valor, double porcentagem)
        {
            double resposta;

            resposta = valor - (valor + porcentagem) / 100;

            return resposta;
        }
    }
}
