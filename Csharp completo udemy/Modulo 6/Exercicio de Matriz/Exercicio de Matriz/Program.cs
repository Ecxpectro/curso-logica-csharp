using System;
namespace Exercicio_de_Matriz
{
    class Program
    {
        static void Main (string[] args)
        {
            int c = 0;
            int N = int.Parse(Console.ReadLine());
            double[,] matriz = new double[N, N];
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = double.Parse(s[j]);
                }
            }
            Console.WriteLine("Diagonal principal: ");
            for (int i = 0;i < N; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }
            Console.WriteLine();
            for (int i = 0;i < N; i++)
            {
                for (int j = 0;j < N; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        c++;
                    }
                }
            }
            Console.WriteLine("Numero negativo: " + c);
        }
    }
}