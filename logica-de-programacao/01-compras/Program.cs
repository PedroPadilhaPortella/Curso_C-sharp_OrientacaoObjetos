using System;
using System.Globalization;

namespace _01_compras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Id Quant Valor");
            string[] dados1 = Console.ReadLine().Split(' ');
            string[] dados2 = Console.ReadLine().Split(' ');

            int code1 = int.Parse(dados1[0]);
            int code2 = int.Parse(dados2[0]);
            int quant1 = int.Parse(dados1[1]);
            int quant2 = int.Parse(dados2[1]);
            double preco1 = float.Parse(dados1[2], CultureInfo.InvariantCulture);
            double preco2 = float.Parse(dados2[2], CultureInfo.InvariantCulture);

            double total = (preco1 * quant1) + (preco2 * quant2);
            System.Console.WriteLine($"Total a pagar: R${total.ToString("N2")}");
        }
    }
}
