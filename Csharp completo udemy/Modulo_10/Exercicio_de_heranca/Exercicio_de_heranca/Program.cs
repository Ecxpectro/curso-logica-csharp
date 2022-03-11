using System;
using System.Collections.Generic;
using Exercicio_de_heranca.Entities;
namespace Exercicio_de_heranca
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int N = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                string outsourced = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                if (outsourced == "y")
                {                    
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());                    
                    list.Add (new OutSourcedEmployee(name, hours, valuePerHour, additionalCharge));                    
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Payments:");
            foreach (Employee emp in list) 
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("f2"));
            }
        }
    }
}