using System;
using System.Globalization;

namespace _01_areaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            System.Console.WriteLine("Entre com as medidas do triangulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Entre com as medidas do triangulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areax = x.CalcularArea();
            double areay = y.CalcularArea();

            System.Console.WriteLine($"Area de X igual a " + areax.ToString("N2", CultureInfo.InvariantCulture));
            System.Console.WriteLine($"Area de Y igual a " + areay.ToString("N2", CultureInfo.InvariantCulture));

            if (areax > areay)
            {
                System.Console.WriteLine("Maior area é do Triangulo X");
            }
            else if(areax == areay)
            {
                System.Console.WriteLine("As areas dos Triangulos são iguais");
            }else{
                System.Console.WriteLine("Maior area é do Triangulo Y");
            }
                
        }
    }
}
