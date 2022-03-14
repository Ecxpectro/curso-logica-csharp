using System;
namespace Exercicio_excecoes.Entities.Exception
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
