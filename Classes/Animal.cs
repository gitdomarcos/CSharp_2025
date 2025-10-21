using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_2025.Classes
{
    public class Animal
    {
        public string Nome {  get; set; }

        public string Especie { get; private set; }

        public double Peso {  get; private set; }

        public bool InserirPeso(double peso)
        {
            if(peso <= 0)
                return false;

            Peso = peso;
            return true;
        }

        public void InserirEspecie(string especie)
        {
            if(especie.Length > 3)
            {
                this.Especie = especie;
            }
            else
            {
                Especie = "(Não informado)";
            }
        }
    }
}
