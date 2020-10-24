using System;

namespace Delegates
{
    delegate double BinaryNumericOperation(double n1, double n2);
    delegate double UnaryNumericOperation(double n);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            //Delegates
            BinaryNumericOperation soma = CalculationService.Sum;
            BinaryNumericOperation maior = new BinaryNumericOperation(CalculationService.Max);
            UnaryNumericOperation quadrado = CalculationService.Square;

            System.Console.WriteLine("Soma: " + soma(a, b));
            System.Console.WriteLine("Maior: " + maior.Invoke(a, b));
            System.Console.WriteLine("Quadrado: " + quadrado(b));
        }
    }
}
