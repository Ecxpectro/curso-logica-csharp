using System;

namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            string[] s = Console.ReadLine().Split(' ');
            M = int.Parse(s[0]);
            N = int.Parse(s[1]);
            int[,] matriz1 = new int[M, N];
            int[,] matriz2 = new int[M, N];
            int[,] C = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matriz1[i, j] = int.Parse(s[j]);                    
                }
            }
            for (int i = 0; i < M; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0;j < N; j++)
                {
                    matriz2[i, j] = int.Parse(s[j]);
                }
            }
           for (int i = 0;i < M; i++)
            {
                int soma = 0;
                for (int j = 0;j < N; j++)
                {
                    soma = matriz1[i, j] + matriz2[i, j];
                    C[i, j] = soma;
                }
            }
           for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }                    
        }
    }
}
