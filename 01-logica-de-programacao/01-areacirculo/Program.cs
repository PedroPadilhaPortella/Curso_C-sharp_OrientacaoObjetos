using System;

namespace _01_areacirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual o raio desse Circulo? ");
            double raio = float.Parse(Console.ReadLine());
            double pi = 3.14159;
            double area = pi * Math.Pow(raio, 2);
            System.Console.WriteLine($"AREA DO CIRCULO: {area.ToString("N4")}cm");
        }
    }
}
