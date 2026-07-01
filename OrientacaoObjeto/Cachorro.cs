using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto
{
    namespace OrientacaoAObjeto
    {
        public class Cachorro : Animal
        {
            public Cachorro(
                string nome,
                double altura,
                bool adestrado,
                DateTime dataDeNascimento,
                string raca)
            {
                Nome = nome;
                Altura = altura;
                Adestrado = adestrado;
                DataDeNascimento = dataDeNascimento;
                Raca = raca;
            }

            public string Raca { get; private set; }

            public bool Adestrado { get; set; }

            public bool IsVacinado { get; set; }

            public override void SeComunicar()
            {
                Console.WriteLine($"Au au");
            }

            public void Caminhar()
            {
                Console.WriteLine("Cachorro caminhando...");
            }

            public void FazerTruque(string truque)
            {
                Console.WriteLine($"Truque: {truque}");
            }
        }
    }
}