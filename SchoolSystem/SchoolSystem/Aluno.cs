using System;

namespace SchoolSystem
{
    public class Aluno : Pessoa
    {
        public string Matricula { get; set; }
        public string Disciplina { get; set; }

        public Aluno(string nome, int idade, string matricula, string disciplina) : base(nome, idade)
        {
            Matricula = matricula;
            Disciplina = disciplina;
        }
    }
}
