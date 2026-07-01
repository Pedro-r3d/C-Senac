

namespace ParOuImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escreva um número para saber se é par ou impar");
            while (true)
            {
                string sair = Console.ReadLine();
                if (sair.Trim().ToLower() == "sair")
                {
                    break;
                }
                if (!double.TryParse(sair, out double numero))
                {
                    Console.WriteLine("Não é um número");
                    continue;
                }             
                ParImpar(numero);
            }
        }


        public static void ParImpar(double numero)
        {
            
            if (numero % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }
        }
    }
}
