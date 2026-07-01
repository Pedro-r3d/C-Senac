using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto
{
    
        public class Pessoa : Animal
        {
            public Pessoa(
                string nome,
                DateTime dataDeNascimento,
                double altura,
                string cpf,
                bool isAtivo)
            {
                Nome = nome;
                DataDeNascimento = dataDeNascimento;
                Altura = altura;
                Cpf = cpf;
                IsAtivo = isAtivo;
            }

            public string Cpf { get; private set; }

            public string RG { get; private set; }

            public string Telefone { get; set; }

            public string Email { get; set; }

            public override void SeComunicar()
            {
                Console.WriteLine($"Olá, meu nome é {Nome}");
            }

            public void Caminhar()
            {
                Console.WriteLine("Pessoa caminhando...");
            }
        }
    }

