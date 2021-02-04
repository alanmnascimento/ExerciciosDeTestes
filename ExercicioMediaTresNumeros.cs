using System;

namespace ExercicioMediaTresNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor: ");
            double v3 = double.Parse(Console.ReadLine());

            v1 = (v1+v2+v3) / 3;

            Console.Write("O resultado é: "+v1);
        }
    }
}
