using System;

namespace ExercicioClasse2
{
    class ConversorDeMoeda
    {
        public static double Iof = 6;       
        public static double ValorSerPago(double valor, double cotacao)
        {
            return cotacao * (valor + (valor * Iof / 100));
        }
    }
}
