using System;
namespace vetor5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, idademaior, posicao = 0;
            int[] idade;
            string[] nome;
            N = int.Parse(Console.ReadLine());
            idade = new int[N];
            nome = new string[N];
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nome[i] = s[0];
                idade[i] = int.Parse(s[1]);             
            }
            idademaior = idade[0];

            for (int i = 1; i < N; i++)
            {
                if (idade[i] > idademaior)
                {
                    idademaior = idade[i];
                    posicao = i;
                }
            }
            Console.WriteLine("pessoa mais velha: " + nome[posicao]);
        }
    }
}
