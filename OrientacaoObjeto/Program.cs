using OrientacaoObjeto.OrientacaoAObjeto;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

namespace OrientacaoObjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var pessoa1 = new Pessoa(
            //    "Guilherme", 
            //    new DateTime(1999, 6, 17), 
            //    1.75, 
            //    "03990095012", 
            //    true);

            //Console.WriteLine("Informações da Pessoa 1");
            //Console.WriteLine($"Nome {pessoa1.Nome}");
            //Console.WriteLine($"Data de Nascimento {pessoa1.DataDeNascimento}");
            //Console.WriteLine($"Altura {pessoa1.Altura}");
            //Console.WriteLine($"Cpf {pessoa1.Cpf}");
            //Console.WriteLine($"Está ativo {pessoa1.IsAtivo}");
            //pessoa1.SeComunicar();

            //pessoa1.SeAlimentar();

            //Console.WriteLine($"Novo nome pessoa 1 {pessoa1.Nome}");

            //var pessoa2 = new Pessoa(
            //    "Douglas",
            //    new DateTime(1996, 11, 20),
            //    1.77,
            //    "03890096031",
            //    true);

            //Console.WriteLine("Informações da Pessoa 2");
            //Console.WriteLine($"Nome {pessoa2.Nome}");
            //Console.WriteLine($"Data de Nascimento {pessoa2.DataDeNascimento}");
            //Console.WriteLine($"Altura {pessoa2.Altura}");
            //Console.WriteLine($"Cpf {pessoa2.Cpf}");
            //Console.WriteLine($"Está ativo {pessoa2.IsAtivo}");

            //pessoa2.SeComunicar();
            //pessoa2.SeAlimentar();

            //var junior = new Cachorro("Junior", 0.2, false, new DateTime(2016, 10, 10), "Pinscher");

            //Console.WriteLine("Informações do cachorro Junior");
            //Console.WriteLine($"Nome {junior.Nome}");
            //Console.WriteLine($"Data de nascimento {junior.DataDeNascimento}");
            //Console.WriteLine($"Raca {junior.Raca}");
            //junior.SeComunicar();

            //junior.SeAlimentar();

            //var pedido = new Pedido(pessoa1, DateTime.Now);

            //pedido.ValorTotal = 100.99;
            //pedido.Observacao = "Cliente vai buscar cachorro às 15:00h";

            //Console.WriteLine("Informações do pedido");
            //Console.WriteLine($"Cliente {pedido.Cliente.Nome}");
            //Console.WriteLine($"Observação do pedido {pedido.Observacao}");

            //Console.WriteLine("Criação do pedido 2");
            //var pedido2 = new Pedido(pessoa2, DateTime.Now, 199.90, "Sem observação");

            //Console.WriteLine("Informações do pedido 2");
            //Console.WriteLine($"Cliente {pedido2.Cliente.Nome}");
            //Console.WriteLine($"Observação do pedido {pedido2.Observacao}");

            Console.WriteLine("");
            Animal pessoa = new Pessoa("Gui", DateTime.Now, 175, "cpf", true);
            Animal cachorro = new Cachorro("JuJu", 30, true, DateTime.Now, "Raca");

            var lista = new List<Animal> { pessoa, cachorro };

            foreach (var animal in lista)
            {
                animal.SeComunicar();
            }
        }
    }
}