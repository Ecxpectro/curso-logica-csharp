using System;
using System.Collections.Generic;
namespace Exercicio_de_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<Funcionario> lista = new List<Funcionario>();

            for (int i = 1; i <= N; i++)
            {

                Console.WriteLine($"Emplyoee: #{i}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                lista.Add(new Funcionario(id, name, salary));
                Console.WriteLine();
            }
           ;
            Console.Write("Enter the emplyoee id  that will have salary increse: ");
            double id2 = double.Parse(Console.ReadLine());
            Funcionario func = lista.Find(x => x.Id == id2);
            if (func != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                func.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();

            Console.WriteLine("Update list of employees:");
            foreach (Funcionario obj in lista)
            {
                Console.WriteLine(obj);
            }
        }
    }
}