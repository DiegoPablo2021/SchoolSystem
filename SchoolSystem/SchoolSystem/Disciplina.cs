using System;

namespace SchoolSystem
{
    public class Disciplina
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }

        public Disciplina(string nome, string codigo)
        {
            Nome = nome;
            Codigo = codigo;
        }

        public override string ToString()
        {
            return $"Disciplina: {Nome}, Código: {Codigo}";
        }
    }
}
