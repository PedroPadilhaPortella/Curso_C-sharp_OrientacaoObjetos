using System;
using System.Globalization;

namespace _02_mercearia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Código  Descrição   Preço");
            Console.WriteLine("==========================");
            Console.WriteLine("1  Cachorro Quente  R$4,00");
            Console.WriteLine("2  X Salada         R$4,50");
            Console.WriteLine("3  X Bacon          R$5,00");
            Console.WriteLine("4  Pão na chapa     R$2,00");
            Console.WriteLine("5  Café             R$1,50");

            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);

            double total;
            if (codigo == 1)
                total = quantidade * 4.0;
            else if (codigo == 2)
                total = quantidade * 4.5;
            else if (codigo == 3)
                total = quantidade * 5.0;
            else if (codigo == 4)
                total = quantidade * 2.0;
            else
                total = quantidade * 1.5;

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
