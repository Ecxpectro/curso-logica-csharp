using System;

namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            string[] nome;
            double[] primeiro;
            double[] segundo;
            double[] media;
            N = int.Parse(Console.ReadLine());
            nome = new string[N];
            primeiro = new double[N];
            segundo = new double[N];
            media = new double[N];
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nome[i] = s[0];
                primeiro[i] = double.Parse(s[1]);
                segundo[i] = double.Parse(s[2]);
            }
            Console.WriteLine("Alunos aprovados:");
            for (int i = 0;i < N; i++)
            {
                media[i]= (primeiro[i] + segundo[i]) / 2;
                if (media[i] >= 6)
                {
                    Console.WriteLine(nome[i]);
                }
            }
        }
    }
}