using System;

namespace ExercicioClasse1
{
     class Aluno
    {
        public string Nome;
        public double NotaA;
        public double NotaB;
        public double NotaC;

        public double NotaFinal()
        {
            return NotaA + NotaB + NotaC;
        }
    }
}
