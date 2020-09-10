using System;

namespace Aluguel
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vetor = new Estudante[10];

            Console.Write("Quantos Quartos serão alugados? ");
            int quartos = int.Parse(Console.ReadLine());

            for (int i = 0; i < quartos; i++){

                System.Console.Write($"Aluguel #{i}\nNome:");
                string nome = Console.ReadLine();

                System.Console.WriteLine("Email: ");
                string email = Console.ReadLine();

                System.Console.WriteLine("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vetor[quarto] = new Estudante(nome, email);
            }
            System.Console.WriteLine("\nQuartos Ocupados:");
            for (int i = 0; i < 10; i++) {
                if(vetor[i] != null) {
                    string value = $"{i} : {vetor[i]}";
                    System.Console.WriteLine(value);
                }
            }
        }
    }
}
