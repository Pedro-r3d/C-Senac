namespace Contador_1_a_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (double i = 0; i <= 10; i++)
            {
                double raiz = Math.Sqrt(i);
               
                Console.WriteLine($"{i} Raiz quadrada: {raiz:F2}");
            // "raiz:C2" Mostra com R$, F2 Para todos números terem duas casas decimais
            }
        }
      
    }
}
