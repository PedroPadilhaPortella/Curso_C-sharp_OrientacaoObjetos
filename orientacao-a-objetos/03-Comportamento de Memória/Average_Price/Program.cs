using System;
using System.Globalization;

namespace Average_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Quantos precos serão lidos? ");
            int n = int.Parse(Console.ReadLine());

            Produto[] vetor = new Produto[n];

            for (int i = 0; i < n; i++) {
                System.Console.Write("Nome: ");
                string name = Console.ReadLine();
                System.Console.Write("Preco: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vetor[i] = new Produto{Name = name, Price = price};
            }

            double soma = 0;
            for (int i = 0; i < n; i++) {
                soma += vetor[i].Price;
            }

            double media = soma / n;
            System.Console.WriteLine("Media dos Precos é: R$ " + media.ToString("F2", CultureInfo.InvariantCulture)); 
        }
    }
}
