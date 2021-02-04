using System;

namespace ExercicioFatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor desejado: ");
            int n = int.Parse(Console.ReadLine());
            if (n == 1 || n == 0)
            {
                Console.Write("O resultado é: "+1);
            }
            else
            {
                int aux = n;
                for(int i = n-1; i>1; i--)
                {
                    aux = aux * i;
                }
                Console.Write("O resultado é: "+aux);
            }
        }
    }
}
