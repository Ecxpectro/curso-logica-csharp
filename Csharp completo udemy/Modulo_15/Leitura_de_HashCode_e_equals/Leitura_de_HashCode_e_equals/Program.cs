using System;
using Leitura_de_HashCode_e_equals.Entities;
using System.Collections.Generic;
namespace Leitura_de_HashCode_e_equals
{
    public class program
    {
        static void Main(string[] args)
        {
            HashSet<Student> set = new HashSet<Student>();

            Console.Write("How many students for course A?");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                int code = int.Parse(Console.ReadLine());
                set.Add(new Student(code));
            }
            Console.Write("How many students for course B?");
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < b; i++)
            {
                int code = int.Parse(Console.ReadLine());
                set.Add(new Student(code));
            }
            Console.Write("How many students for course C?");
            int c = int.Parse(Console.ReadLine());
            for (int i = 0; i < c; i++)
            {
                int code = int.Parse(Console.ReadLine());
                set.Add(new Student(code));
            }
            Console.WriteLine("Total student: " + set.Count);
        }
    }
}
