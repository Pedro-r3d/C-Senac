namespace MeuPrimeiroProjetoC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("textoahahaha");
            int idade = 26;
            string nome = "Guilherme";
            string sobrenome = "Walter";
            bool ehProfessor = true;
            double altura = 1.75;

            //Console.WriteLine($"Meu nome é {nome} {sobrenome}.");
            //Console.WriteLine($"Tenho {idade} anos de idade. ");
            //Console.WriteLine($"Sou professor: {ehProfessor}.");
            //Console.WriteLine($"Tenho {altura} de altura.");

            string nomeCompleto = ObterNomeCompleto(nome, sobrenome);
            Console.WriteLine($"Meu nome é {nomeCompleto}");
            ExibirSeEhProfessorEaltura(ehProfessor, altura);
        }
        static string ObterNomeCompleto(string nome, string sobrenome)
        {
            string nomeCompleto = $"{nome} {sobrenome}";
            return nomeCompleto; 
        }

        static void ExibirSeEhProfessorEaltura(bool ehProfessor, double altura)
        {
            Console.WriteLine($"Sou professor: {ehProfessor}.");
            Console.WriteLine($"Tenho {altura} de altura.");
        }
    }
}
