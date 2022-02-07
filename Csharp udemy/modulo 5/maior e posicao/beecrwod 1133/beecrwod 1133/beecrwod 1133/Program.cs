using System;
using System.Globalization;

namespace primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, y = 0, chng;
            x = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            if (x > n)
            {
                chng = x;
                x = n;
                n = chng;
            }
           
            
            for (int i = x + 1; i < n; i++)
            {
                if (i % 5 == 2 || i % 5 == 3)
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}