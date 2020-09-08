using System;
using System.Globalization;

namespace _04_divisoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de Divisões: ");
            int quant = int.Parse(Console.ReadLine());

            double[] divisao = new double[quant];

            for (int i = 0; i < quant; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                double v1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double v2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
                divisao[i] = v1 / v2;

            }

            for (int i = 0; i < divisao.Length; i++) {
                System.Console.WriteLine(divisao[i].ToString("F2", CultureInfo.InvariantCulture));

            }
        }
    }
}
