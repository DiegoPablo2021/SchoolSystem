using System;

namespace SchoolSystem
{
    public class Professor : Pessoa
    {
        public string Disciplina { get; set; }

        public Professor(string nome, int idade, string disciplina) : base(nome, idade)
        {
            Disciplina = disciplina;
        }
    }
}
