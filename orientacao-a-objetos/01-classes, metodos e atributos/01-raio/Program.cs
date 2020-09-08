using System;
using System.Globalization;

namespace _01_raio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o Valor do Raio:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circunferencia = Calculadora.Circuferencia(raio);
            double volume = Calculadora.Volume(raio);
            
            System.Console.WriteLine("Circunferencia: " + circunferencia.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Pi: " + Calculadora.PI.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
