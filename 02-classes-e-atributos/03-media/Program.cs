using System;

namespace media
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Média Geral dos Alunos";
            Console.Write("Quantos Alunos serão cadastrados? ");
            int n = int.Parse(Console.ReadLine());

            Aluno[] alunos = new Aluno[n];

            for (int i = 0; i < n; i++){
                Console.Clear();
                Console.Write($"Aluno {i+1}:\nNome: ");
                string nome = Console.ReadLine();
                Console.Write("Quantidade de Provas: ");
                int qtdProvas = int.Parse(Console.ReadLine());

                alunos[i] = new Aluno(nome, qtdProvas);


                Console.Write($"insira as notas do Aluno {nome}:\n");
                alunos[i].InserirNotas();
            }      
            Console.Clear();

            double mediaGeral = 0.0;

            foreach (var aluno in alunos) {
                Console.WriteLine($"Aluno: {aluno.Nome}, Media: {aluno.Media}");
                mediaGeral += aluno.Media;
            }

            double resultadoFinal = mediaGeral / alunos.Length;
            System.Console.WriteLine($"\nMedia Geral: {resultadoFinal}");
        }
    }
}
