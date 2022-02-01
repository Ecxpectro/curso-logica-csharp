using System;

namespace primeiro
{

    class program
    {
        static void Main(string[] args)
        {
            int maior, posicao;
            maior = int.Parse(Console.ReadLine());
            posicao = 1;
            
            for (int i = 2; i <= 100; i++)
            {
                int n = int.Parse(Console.ReadLine());
             
                if (n > maior)
                {
                    maior = n;
                    posicao = i;
                }


            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);


        }
    }
}