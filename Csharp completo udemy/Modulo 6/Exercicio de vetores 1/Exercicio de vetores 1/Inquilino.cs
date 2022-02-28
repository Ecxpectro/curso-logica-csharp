﻿namespace Exercicio_de_vetores_1
{
    class Inquilino
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Inquilino(string name, string email)
        {
            Name = name;
            Email = email;
        }


        public override string ToString()
        {
            return $" {Name}, {Email}";
        }
    }
}
