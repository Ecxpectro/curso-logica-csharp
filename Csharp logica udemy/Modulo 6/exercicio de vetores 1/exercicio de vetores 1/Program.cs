using System;

namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double soma = 0, media = 0;
            double[] vet;
            N = int.Parse(Console.ReadLine());
            vet = new double[N];
            string[] s = Console.ReadLine().Split(' ');
           
            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(s[i]);
            }
            
            for (int i = 0; i < N; i++)
            {
                if (i < N && i <= N - 2)
                {
                    Console.Write(vet[i] + " ");
                }
                else if (i < N && i == N - 1)
                {
                    Console.WriteLine(vet[i]);
                }
            }
            
            for (int i = 0; i < N; i++)
            {
                soma += vet[i];
            }
            Console.WriteLine(soma);
            media = soma / N;
            Console.WriteLine(media);
        }
    }
}

