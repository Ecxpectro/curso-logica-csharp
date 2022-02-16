using System;

namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;
            int[] vet;
            n = int.Parse(Console.ReadLine());
            vet = new int[n];
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                vet[i] = int.Parse(s[i]);
            }
            double maior = vet[0];
            int posicaoMaior = 0;

            for (int i = 1; i < n; i++)
            {
                if (vet[i] > maior)
                {
                    maior = vet[i];
                    posicaoMaior = i;
                }
            }
            Console.WriteLine(maior.ToString("F1"));
            Console.WriteLine(posicaoMaior);
        }
    }
}