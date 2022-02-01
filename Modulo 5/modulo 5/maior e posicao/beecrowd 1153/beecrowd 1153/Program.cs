using System;

namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, fat = 0;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (i == 1)
                {
                    fat = n * (n - i);
                }
                else
                {
                    fat =fat * (n - i);                                     
                }

            }
            
            Console.WriteLine(fat);

        }
    }
}