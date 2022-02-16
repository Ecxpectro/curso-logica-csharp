using System;

namespace ExercicioClasse2
{
    class programa
    {
        static void Main(string[] args)
        {
            
            Console.Write("Qual é a cotação do dólar: ");
            double cotacao = double.Parse(Console.ReadLine());
            
            Console.Write("Qual o valor em dólares você vai comprar: ");
            double valor = double.Parse(Console.ReadLine());
            double resultado = ConversorDeMoeda.ValorSerPago(cotacao, valor);
            Console.WriteLine("Valor a ser pago em reais = " + resultado);
        }
    }
}
