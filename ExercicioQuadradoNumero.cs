using System;

namespace ExercicioQuadradoNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número: ");
            int n = int.Parse(Console.ReadLine());
            n = n * n;
            Console.Write("O resultado é: "+n);
        }
    }
}
