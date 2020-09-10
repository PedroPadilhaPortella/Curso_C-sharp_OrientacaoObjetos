using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            // double x = null; metodo inválido, uma variavel não pode ser nula
            // Nullable<double> x = null;
            double? x = null;
            double? y = 10.0;

            System.Console.WriteLine(x.GetValueOrDefault());
            System.Console.WriteLine(y.GetValueOrDefault());

            System.Console.WriteLine(x.HasValue);
            System.Console.WriteLine(y.HasValue);

            if (x.HasValue)
                System.Console.WriteLine(x.Value);
            else
                System.Console.WriteLine("X is Null");
            
            if (y.HasValue)
                System.Console.WriteLine(y.Value);
            else
                System.Console.WriteLine("Y is Null");

            // double? valor1 = null;
            // double? valor2 = 10;

            double a = x ?? 5;
            double b = y ?? 7;
            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
        }
    }
}