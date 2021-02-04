using System;

namespace ExercicioOrdem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] {30, 17, 6, 23, 1, 9, 11, 19};
            for (int i = 0; i < num.Length; i++) {
                Console.Write(" "+num[i]);
            }
            int aux = 0;
            for (int i = num.Length-1;i>=0; i--)
            {
                for (int x=0; x<i; x++)
                {
                    if (num[x]>num[i]) {
                        aux = num[i];
                        num[i] = num[x];
                        num[x] = aux;
                    }
                }
            }
            Console.WriteLine("");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(" " + num[i]);
            }
        }
    }
}
