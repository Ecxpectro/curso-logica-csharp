using System;

namespace primeiro
{

    class program
    {
        static void Main(string[] args)
        {
            double n, x, y, z, media;
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                x = double.Parse(vet[0]);
                y = double.Parse(vet[1]);
                z = double.Parse(vet[2]);

                media = (x * 2 + y * 3 + z * 5) / 10;
                Console.WriteLine(media.ToString("f1"));

            }

        }
        
    }
} 
