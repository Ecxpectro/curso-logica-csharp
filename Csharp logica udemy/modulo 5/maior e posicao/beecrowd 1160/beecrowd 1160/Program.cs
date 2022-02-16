using System;

namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int media1, media2;
            double t1, t2, m1, m2, n, p1, p2;
            n = double.Parse(Console.ReadLine());

            for ( int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                p1 = double.Parse(vet[0]);
                p2 = double.Parse(vet[1]);
                t1 = double.Parse(vet[2]);
                t2 = double.Parse(vet[3]);
               
                             
              
             for (int j = 1; p1 <= p2; j++)
                {
                    p1 = p1 + Math.Round(t1 * p1 / 100, 0);
                    p2 = p2 + Math.Round(t2 * p2 / 100, 0);

                    if ( p1 >= p2 )
                    {
                        if (p1 == p2)
                        {
                            j++;
                          
                        }
                        p1 = p1 + Math.Round(t1 * p1 / 100, 0);
                        p2 = p2 + Math.Round(t2 * p2 / 100, 0);                       
                        if (j > 100)
                        {
                            Console.WriteLine("mais de 1 seculo");
                        }
                        else
                        {
                            Console.WriteLine(j + " anos.");
                        }
                       
                    }
                   
                }
                
            }
        }
    }
}