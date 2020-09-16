using System;
using System.Globalization;

namespace _01_area_poligonos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A B C");
            string[] dados1 = Console.ReadLine().Split(' ');

            double a = double.Parse(dados1[0], CultureInfo.InvariantCulture);
            double b = double.Parse(dados1[1], CultureInfo.InvariantCulture);
            double c = double.Parse(dados1[2], CultureInfo.InvariantCulture);

            double triangulo = a * c /2;
            double circulo = Math.Pow(c, 2) * 3.14159;
            double quadrado = Math.Pow(b, 2);
            double trapezio = ((a + b) * c) / 2;
            double retangulo = a * b;

            System.Console.WriteLine($"TRIANGULO: {triangulo} \nCIRCULO: {circulo} \nQUADRADO: {quadrado} \nTRAPÉZIO:{trapezio} \nRETANGULO: {retangulo}");
        }
    }
}
