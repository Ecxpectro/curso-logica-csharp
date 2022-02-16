using System;

namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, soma = 0; ;
            N = int.Parse(Console.ReadLine());
            int[,] matriz = new int[N,N];
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matriz[i,j] = int.Parse(s[j]);
                }
            }
            for (int i = 0;i < N; i++)
            {                
                for (int j = 0; j < N; j++)
                {
                    if (j > i)
                    {
                        soma = soma + matriz[i, j];
                    }
                }
            }
            Console.WriteLine(soma);
        }
    }
}