using System;
using Projeto_orientado_objeto.Entities.Enum;
using Projeto_orientado_objeto.Entities;
namespace Projeto_orientado_objeto
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthDate);
            
            
            Console.WriteLine();

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            DateTime date2 = DateTime.Now;
            Order order = new Order(date2, status, client);

            Console.WriteLine();
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(productName, price);
                OrderItem item = new OrderItem(quantity, price, product);
                order.Items.Add(item);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }

}