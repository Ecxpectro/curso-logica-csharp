using System;

namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[] V1;
            int[] V2;
            int[] soma;
            N = int.Parse(Console.ReadLine());
            V1 = new int[N];
            V2 = new int[N];
            soma = new int[N];
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                
                V1[i] = int.Parse(s[i]);
                
            }
            s = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                V2[i] = int.Parse(s[i]);
            }
            
            for (int i = 0;i < N; i++)
            {
                soma[i] = V1[i] + V2[i];
                Console.Write(soma[i] + " ");
            }
            
           

        }
    }
}
