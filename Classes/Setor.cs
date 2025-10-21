using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_2025.Classes
{
    public class Setor
    {
        public Setor(string coordenador, string lider, string setores, string colaboradores)
        {
            this.Coordenador = coordenador;
            this.Lider = lider;
            this.Setores = setores;
            this.Colaboradores = colaboradores;
        }

        public Setor() { }

            public string Coordenador { get; set; }
            public string Lider { get; set; }
            public string Setores { get; set; }
            public string Colaboradores { get; set; }
    }
}
