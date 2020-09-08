using System;

namespace _03_cartesiano
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] coordenadas = Console.ReadLine().Split();
            int x = int.Parse(coordenadas[0]);
            int y = int.Parse(coordenadas[1]);

            while(x != 0 && y != 0){
                if(x > 0 && y > 0)
                    System.Console.WriteLine("Primeiro");
                else if(x > 0 && y < 0)
                    System.Console.WriteLine("Segundo");
                else if(x < 0 && y < 0)
                    System.Console.WriteLine("Terceiro");
                else
                    System.Console.WriteLine("Quarto");
                
                coordenadas = Console.ReadLine().Split(' ');
                x = int.Parse(coordenadas[0]);
                y = int.Parse(coordenadas[1]);
            }
        }
    }
}
