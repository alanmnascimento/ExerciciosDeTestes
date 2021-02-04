using System;

namespace ExercicioNumeroPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Favor digitar o número a ser analisado: ");
            int num = int.Parse(Console.ReadLine());
            int cont = 0;
            for (int i=1; i<=num; i++)
            {
                if (num % i == 0)
                {
                    cont++;
                }
            }
            if (cont == 2)
            {
                Console.WriteLine("O numero é primo.");
            }
            else
            {
                Console.WriteLine("O numero não é primo.");
            }
        }
    }
}
