using System;
using Exercicio_excecoes.Entities;
using Exercicio_excecoes.Entities.Exception;
namespace Exercicio_excecoes
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw limit: ");
            double withdrawL = double.Parse(Console.ReadLine());

            Account account = new Account(number, holder, balance, withdrawL);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine());
            try
            {                
                account.Whithdraw(amount);
                Console.WriteLine($"New balance {account.Balance}");
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}