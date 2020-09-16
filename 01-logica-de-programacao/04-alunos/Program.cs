using System;

namespace _04_alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alunos = new string[] {"Pedro", "João", "Vinicius", "Gabriel"};
        
        foreach (string aluno in alunos)
        {
            Console.WriteLine(aluno);
        }
        }
    }
}
