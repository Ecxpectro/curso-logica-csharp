using System;

namespace uri1049
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, primeiro, segundo, terceiro;
            n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                primeiro = i;
                segundo = i * i;
                terceiro = i * i * i;
                Console.WriteLine(primeiro + " " + segundo + " " + terceiro);
                segundo = segundo + 1;
                terceiro = terceiro + 1;
                Console.WriteLine(primeiro + " " + segundo + " " + terceiro);
            }
            
            
            

        }
    }
}