using System;


namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());           
            
            int[,] Matriz = new int[N, N];            
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');                
                for (int j = 0; j < N; j++)
                {
                    Matriz[i, j] = int.Parse(s[j]);
                }
            }           
            for (int i = 0;i < N; i++)
            {                
                int soma = 0;               
                for (int j = 0;j < N; j++)
                {
                    soma = soma + Matriz[i, j];
                }
                Console.WriteLine(soma);                
            }
        }
    }
}