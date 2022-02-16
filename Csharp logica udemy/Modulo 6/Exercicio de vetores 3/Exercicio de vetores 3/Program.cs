using System;

namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, j = 0;
            int[] vet;
            N = int.Parse(Console.ReadLine());
            vet = new int[N];
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(s[i]);
                if (vet[i] % 2 == 0)
                {
                    Console.Write(vet[i] + " ");
                    j++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(j);
            


        }
    }
}