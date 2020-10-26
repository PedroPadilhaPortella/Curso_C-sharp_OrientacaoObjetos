using System;

namespace _03_static
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estatico e = new Estatico();
            Estatico.Taxa = 10;
            int v1 = Estatico.Adicionar(12);
            int v2 = Estatico.Subtrair(8);

            System.Console.WriteLine($"{v1}, {v2}");
        }
    }
}
