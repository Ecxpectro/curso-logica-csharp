using System;
using System.Globalization;

namespace uri1021
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x = 0, y = 0, chng;
            n= int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

                if (x > y)
                {
                                       
                    chng = x;
                    x = y;
                    y = chng;
                   
                }
                int soma = 0;
                for  (int j = x + 1; j < y; j++)
                {
                    if (j % 2 != 0)
                    {
                        soma += j;
                        

                    }
                    
                }
                Console.WriteLine(soma);
            }
            
        }
    }
}