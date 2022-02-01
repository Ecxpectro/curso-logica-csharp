using System;

namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, x, y, media;
            n = double.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                x = double.Parse(vet[0]);
                y = double.Parse(vet[1]);
                if (y != 0)
                {
                    media = x / y;
                    Console.WriteLine(media.ToString("f1"));
                }
                else
                {
                    Console.WriteLine("impossivel calcular");
                }
            }

        }
    }
}