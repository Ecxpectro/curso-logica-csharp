using System;


namespace ExercicioDeClassesEncapsulamento
{
    internal class DadosBancarios
    {
        public int NumeroDeConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }
        public DadosBancarios(int numeroDeConta, string nome)
        {
            NumeroDeConta = numeroDeConta;
            Nome = nome;
        }
        public DadosBancarios(int numerodeconta, string nome, double depositoInicial) : this (numerodeconta, nome) 
        { 
            Deposito(depositoInicial);
        }
        
        public void Deposito (double quantia)
        {
            Saldo += quantia;
        }
        public void Saque (double quantia)
        {
            Saldo -= quantia + 5;
        }

        public override string ToString()
        {
            return $"conta {NumeroDeConta}, Titular: {Nome}, Saldo: $ {Saldo.ToString("f2")}" ;
        }


    }
}
