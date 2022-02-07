using System;

namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, y, ant = 0, atu = 0, soma = 0, z = 0, s;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                x = i;
                y = 1;
                if (x == 0)
                {
                    Console.Write(x + " ");
                    soma = x;                    
                }
                else if (soma == 0 && y == 1)
                {
                    z = soma;
                    soma = soma + y;
                    Console.Write(soma + " ");
                    atu = soma;
                }
                else
                {
                    atu = ant + atu;
                    Console.Write(atu + " ");
                    ant = atu - ant;                  
                }
                
                
            }


        }
    }
}