using System;
using Expressao_lambda_2.Entities;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
namespace Expressao_lambda_2
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Employee> employee = new List<Employee>();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] vet = sr.ReadLine().Split(',');
                        string name = vet[0];
                        string email = vet[1];
                        double salary = double.Parse(vet[2], CultureInfo.InvariantCulture);
                        employee.Add(new Employee(name, email, salary));
                    }
                }
                Console.Write("Enter salary: ");
                double salary2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Email of people whose salary is more than 2000.00:");
                var cmp = employee.Where(p => p.Salary > salary2).OrderBy(p => p.Email).Select(p => p.Email);
                foreach (string email in cmp)
                {
                    Console.WriteLine(email);
                }

                Console.Write("Sum of salary of people whose name starts with 'M': ");
                var sum = employee.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
                Console.WriteLine(sum.ToString("f2", CultureInfo.InvariantCulture));
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(ex.Message);
            }
        }
    }
}