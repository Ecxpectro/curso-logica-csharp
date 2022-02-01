using System;

namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, y, soma = 0;
            x = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());

            for (int i = x; i <= n; i++)
            {
                if ( i % 13 != 0)
                {
                    soma += i;
                }

            }
            Console.WriteLine(soma);
        }
    }
}