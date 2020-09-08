using System;

namespace DigitalInnovationOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            string opcaoUsuario = ObterOpcaoUser();
            int indiceAluno = 0;

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("\nInforme o nome do Aluno:");

                        var aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a Nota do Aluno: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException ("O valor da Nota Deve ser um Decimal");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        break;

                    case "2":
                        foreach(var student in alunos)
                        {
                            if (!string.IsNullOrEmpty(student.Nome))
                            {
                                Console.WriteLine($"ALUNO: {student.Nome} -- NOTA: {student.Nota}");
                            }
                        }
                        break;
                    case "3":
                        decimal notaTotal = 0;
                        int nrAlunos = 0;
                        

                        for(int i = 0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos++;
                            }  
                        }
                        var MediaGeral = notaTotal / nrAlunos;
                        Conceito conceitoGeral;
                        if(MediaGeral < 2)
                        {
                            conceitoGeral = Conceito.E;
                        }
                        else if(MediaGeral < 4)
                        {
                            conceitoGeral = Conceito.D;
                        } 
                        else if(MediaGeral < 6)
                        {
                            conceitoGeral = Conceito.C;
                        }
                        else if(MediaGeral < 8)
                        {
                            conceitoGeral = Conceito.B;
                        }
                        else
                        {
                            conceitoGeral = Conceito.A;
                        }

                        Console.WriteLine($"Media Geral: {MediaGeral} -- CONCEITO: {conceitoGeral}");


                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUser();
            }
        }

        private static string ObterOpcaoUser()
        {
            Console.WriteLine("Informe a opção desejada:\n");
            Console.WriteLine("Inserir Novo Aluno [1]");
            Console.WriteLine("Listar Alunos [2]");
            Console.WriteLine("Calcular média Geral [3]");
            Console.WriteLine("sair [X]");
            Console.WriteLine();

            string opcaoUser = Console.ReadLine();
            return opcaoUser;
        }
    }
}