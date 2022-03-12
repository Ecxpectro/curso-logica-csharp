using System;
using Metodos_Abstratos.Entities;
namespace Metodos_abstratos
{
    class program
    {
        static void Main(string[] args)
        {
            List < TaxPayer > list= new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int N = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                if (ch == 'i')
                {
                    Console.Write("Anual income: ");
                    double income = double.Parse(Console.ReadLine());
                    Console.Write("Health expenditiures: ");
                    double expenditiures = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, income, expenditiures));
                    Console.WriteLine();
                }
                else if (ch == 'c')
                {
                    Console.Write("Anual income: ");
                    double income = double.Parse(Console.ReadLine());
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, employees));
                    Console.WriteLine();
                }
            }
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer taxPayer in list)
            {
                Console.WriteLine($"{taxPayer.Name} $ {taxPayer.Tax().ToString("f2")}");               
                sum += taxPayer.Tax();
            }
            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("f2")}");

        }
    }
}