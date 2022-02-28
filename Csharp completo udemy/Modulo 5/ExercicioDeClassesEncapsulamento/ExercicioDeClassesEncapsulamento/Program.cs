using System;

namespace ExercicioDeClassesEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            string cond;
            double quantia;
            DadosBancarios conta;
            //Numero da conta
            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());            
            
            
            //Nome do cliente
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();


            //Se fará depósito inicial
            Console.Write("Haverá depósito inicial (s/n)? ");
            cond = Console.ReadLine();
            if (cond == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double saldoInicial = double.Parse(Console.ReadLine());
                conta = new DadosBancarios(numero, nome, saldoInicial);
                
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(conta);
                Console.WriteLine();

            }
            else
            {
                conta = new DadosBancarios(numero, nome);
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(conta);
                Console.WriteLine();
            }

            //Acrescimo de deposito
            Console.Write("Entre um valor para depósito: ");
            quantia = double.Parse(Console.ReadLine());
            conta.Deposito(quantia);
            Console.WriteLine("Dados atualizado:");
            Console.WriteLine(conta);
            Console.WriteLine();
            //valor a ser retirado
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine());
            conta.Saque(quantia);
            Console.WriteLine("Dados atualizados: ");            
            Console.WriteLine(conta);
        }
    }
}