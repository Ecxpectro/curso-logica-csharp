using System;

namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, maiorN;
            N = int.Parse(Console.ReadLine());
            int [,] matriz = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for(int j = 0; j < N; j++)
                {
                    matriz[i, j] = int.Parse(s[j]);
                }

            }
            maiorN = matriz[0, 0];
            for (int i = 0;i < N; i++)
            {
                maiorN = matriz[i, 0];
                for (int j = 0;j < N; j++)
                {
                    if (maiorN < matriz[i, j])
                    {
                        maiorN = matriz[ i, j];
                    }                    
                }
                Console.WriteLine(maiorN);
            }
        }
    }
}
