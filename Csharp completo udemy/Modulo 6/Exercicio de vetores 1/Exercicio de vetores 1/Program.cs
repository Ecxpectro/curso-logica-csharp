using System;
namespace Exercicio_de_vetores_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            Inquilino[] vet = new Inquilino[10];

            for (int i = 1; i <= M; i++)
            {
                Console.WriteLine($"Rent # {i}");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                vet[room] = new Inquilino (name,  email);
                Console.WriteLine();
            }
            Console.WriteLine("Busy rooms:");
            for (int i = 1; i < 10; i++)
            {
                if (vet[i] != null)
                    Console.WriteLine(i + ":" + vet[i]);
            }
        }
    }
}