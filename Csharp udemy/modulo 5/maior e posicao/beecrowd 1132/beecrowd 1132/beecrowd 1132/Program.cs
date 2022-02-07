using System;

namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, y, soma = 0, chng;
            x = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            if ( x > n)
            {
                chng = x;
                x = n;
                n = chng;

            }
            
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