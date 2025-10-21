using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_2025.Classes
{
    public class Viagem
    {
        public Viagem(string destino)
        {
           this.Destino = destino;
        }

        public Viagem() { }

        public string Passageiro {  get; set; }

        public string Destino { get; set; }

        public string Data { get; set; }

        public string Valor { get; set; }
    }
}
