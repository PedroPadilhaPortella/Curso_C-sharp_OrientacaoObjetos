using System;
using System.Globalization;

namespace Average_Height
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Quantas alturas serão lidas? ");
            int n = int.Parse(Console.ReadLine());
            double[] vetor = new double[n];

            for (int i = 0; i < n; i++) {
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            
            double sum = 0.0;
            
            for (int i = 0; i < n; i++) {
                sum += vetor[i];
            }
            double average = sum / n;
            System.Console.WriteLine($"Average Height: "+ average.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
