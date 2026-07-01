using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto
{
    public class Animal
    {
        public string Nome { get; protected set; }

        public DateTime DataDeNascimento { get; protected set; }

        public double Altura { get; set; }

        public double Peso { get; set; }

        public bool IsAtivo { get; set; }

        public virtual void SeComunicar()
        {
            Console.WriteLine("Fala genérica...");
        }

        public void SeAlimentar()
        {
            Console.WriteLine("Animal se alimentando...");
        }


    }
}

