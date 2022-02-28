using System;
namespace Exercicio_de_matriz_2
{
    class Program
    {
        static void Main (string[] args)
        {
            string[] vet = Console.ReadLine ().Split(' ');
            int N = int.Parse(vet[0]);
            int M = int.Parse(vet[1]);

            int[,] matriz = new int[N, M];
            for (int i = 0; i < N; i++)
            {
               string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < M; j++)
                {
                    matriz[i, j] = int.Parse(s[j]);
                }
            }
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0;i < N; i++)
            {
                for (int j = 0;j < M; j++)
                {
                    if (numero == matriz[i, j])
                    {
                        Console.WriteLine($"position {i},{j}:");
                        if (j > 0)
                        {
                            Console.WriteLine($"Left: {matriz[i, j-1]}");
                        }
                        if (i > 0)
                        {
                            Console.WriteLine($"Up: {matriz[i - 1, j]}");
                        }
                        if (j < M - 1)
                        {
                            Console.WriteLine($"Right: {matriz[i, j + 1]}");
                        }
                        if (i < N - 1)
                        {
                            Console.WriteLine($"Down: {matriz[i + 1, j]}");
                        }
                    }
                }
            }
        }
    }
}
