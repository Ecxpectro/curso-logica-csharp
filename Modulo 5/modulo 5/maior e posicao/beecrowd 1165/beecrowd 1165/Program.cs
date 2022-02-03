using System;

namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, p;
            bool primo;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
              
                p = int.Parse(Console.ReadLine());
                primo = true;
                for (int j = 2; j < p; j++)
                {
                  
                    if (p % j == 0)
                    {
                        primo = false;
                        break;
                        
                    }
                                                                
                }
                if (primo)
                {
                    Console.WriteLine(p + " é primo");
                }
                else
                {
                    Console.WriteLine(p + " não é primo");
                    
                }
            }

        }
    }
}