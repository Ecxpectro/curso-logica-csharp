using System;
using System.Collections.Generic;
using exercicio_heranca_polimorfismo.Entities;
namespace exercicio_heranca_polimorfismo
{
    class program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char tag = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                if (tag == 'i')
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, fee));
                    Console.WriteLine();
                }
                else if (tag == 'c')
                {
                    list.Add(new Product(name, price));
                    Console.WriteLine();
                }
                else if (tag == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Price tags:");
            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
