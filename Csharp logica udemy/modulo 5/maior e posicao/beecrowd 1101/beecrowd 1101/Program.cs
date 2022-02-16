using System;

namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 1, n = 1, soma = 0;
           

            while (m > 0 && n > 0)
            {
               
                string[] vet = Console.ReadLine().Split(' ');
                m = int.Parse(vet[0]);
                n = int.Parse(vet[1]);
                soma = 0;
                if ( m > n && n > 0)
                {
                    for (int i = n; i <= m; i++)
                    {
                        
                        n = n + 1;
                        soma = soma + i;
                        Console.Write(i + " ");
                    }
                    Console.WriteLine(" sum=" + soma);
                } 
                else if ( n > m && m > 0)
                {
                    for (int i = m; i <= n; i++)
                    {
                       
                        m = m + 1;
                        soma = soma + i;
                        Console.Write(i + " ");
                    }
                    Console.WriteLine(" sum=" + soma);
                }
            }

        }
    }
}