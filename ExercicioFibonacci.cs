using System;

namespace ExercicioFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor: ");
            int num = int.Parse(Console.ReadLine());
            
            string str = "1 ";
            int n1 = 1, n2 = 0;

            for (int i = 1; i < num; i++)
            {

                n1 = n1 + n2;
                n2 = n1 - n2;
                str += n1.ToString()+" ";
            }

            Console.Write(str);
        }
    }
}
