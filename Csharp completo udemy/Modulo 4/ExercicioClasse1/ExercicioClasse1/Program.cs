using System;

namespace ExercicioClasse1
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno inf = new Aluno();
            double notafinal;

            //Requisitando Nome             
            Console.Write("Nome: ");
            inf.Nome = Console.ReadLine();
            // Requisitando notas
            Console.WriteLine("Digite as três notas do aluno:");
            inf.NotaA = double.Parse(Console.ReadLine());
            inf.NotaB = double.Parse(Console.ReadLine());
            inf.NotaC = double.Parse(Console.ReadLine());
            // Identificar se foi aprovado ou reprovado
            Console.WriteLine("Nota final = " + inf.NotaFinal().ToString("F2"));
            if (inf.NotaFinal() >= 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                notafinal = 60 - inf.NotaFinal();
                Console.WriteLine("FALTARAM " + notafinal.ToString("F2") + " PONTOS");
            }

        }
    }
}
