using System;
using System.Collections.Generic;

namespace SchoolSystem
{
    class Program
    {
        static List<Pessoa> pessoas = new List<Pessoa>();
        static List<Disciplina> disciplinas = new List<Disciplina>();

        static void Main(string[] args)
        {
            int opcao;
            do
            {
                
                Console.Clear();
                Console.WriteLine("Bem-vindo ao SchoolSystem\n");
                Console.WriteLine("=========MENU============");
                Console.WriteLine("1. Cadastrar aluno");
                Console.WriteLine("2. Cadastrar professor");
                Console.WriteLine("3. Cadastrar disciplina");
                Console.WriteLine("4. Listar pessoas cadastradas");
                Console.WriteLine("5. Listar disciplinas cadastradas");
                Console.WriteLine("6. Encerrar o programa");
                Console.Write("Escolha uma das opções: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out opcao) && (opcao >= 1 && opcao <= 6))
                {
                    switch (opcao)
                    {
                        case 1:
                            CadastrarAluno();
                            break;
                        case 2:
                            CadastrarProfessor();
                            break;
                        case 3:
                            CadastrarDisciplina();
                            break;
                        case 4:
                            ListarPessoas();
                            break;
                        case 5:
                            ListarDisciplinas();
                            break;
                        case 6:
                            Console.WriteLine("Programa encerrado. Volte sempre!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida, pressione qualquer tecla para voltar ao menu.");
                    Console.ReadKey();
                }
            } while (opcao != 6);
        }

        static void CadastrarAluno()
        {
            Console.Clear();
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a idade do aluno: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Digite a matrícula do aluno: ");
            string matricula = Console.ReadLine();
            Console.Write("Digite a disciplina do aluno: ");
            string disciplina = Console.ReadLine();

            Aluno aluno = new Aluno(nome, idade, matricula, disciplina);
            pessoas.Add(aluno);

            Console.WriteLine("Aluno cadastrado com sucesso!!!");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void CadastrarProfessor()
        {
            Console.Clear();
            Console.Write("Digite o nome do professor: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a idade do professor: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Digite a disciplina do professor: ");
            string disciplina = Console.ReadLine();

            Professor professor = new Professor(nome, idade, disciplina);
            pessoas.Add(professor);

            Console.WriteLine("Professor cadastrado com sucesso!!!");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void CadastrarDisciplina()
        {
            Console.Clear();
            Console.Write("Digite o nome da disciplina: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o código da disciplina: ");
            string codigo = Console.ReadLine();

            Disciplina disciplina = new Disciplina(nome, codigo);
            disciplinas.Add(disciplina);

            Console.WriteLine("Disciplina cadastrada com sucesso!!!");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void ListarPessoas()
        {
            Console.Clear();
            if (pessoas.Count == 0)
            {
                Console.WriteLine("Nenhuma pessoa cadastrada.");
            }
            else
            {
                foreach (var pessoa in pessoas)
                {
                    if (pessoa is Aluno aluno)
                    {
                        Console.WriteLine($"Aluno: {aluno.Nome}, Idade: {aluno.Idade}, Matrícula: {aluno.Matricula}, Disciplina: {aluno.Disciplina}");
                    }
                    else if (pessoa is Professor professor)
                    {
                        Console.WriteLine($"Professor: {professor.Nome}, Idade: {professor.Idade}, Disciplina: {professor.Disciplina}");
                    }
                }
            }
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void ListarDisciplinas()
        {
            Console.Clear();
            if (disciplinas.Count == 0)
            {
                Console.WriteLine("Nenhuma disciplina cadastrada.");
            }
            else
            {
                foreach (var disciplina in disciplinas)
                {
                    Console.WriteLine(disciplina);
                }
            }
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
