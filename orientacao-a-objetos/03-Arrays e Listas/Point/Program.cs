using System;

namespace Point
{
    class Program
    {
        static void Main(string[] args)
        {
            // O tipo struct pode ser inicializado de duas formas, atribuindo valores ou usando New Struct
            Point ponto;

            ponto.X = 10;
            ponto.Y = 12;
            System.Console.WriteLine(ponto);

            ponto = new Point();
            System.Console.WriteLine(ponto);
        }
    }
}
