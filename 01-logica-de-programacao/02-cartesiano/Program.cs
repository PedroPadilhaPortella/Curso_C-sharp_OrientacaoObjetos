using System;

namespace _02_cartesiano
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("CORDINATE: ");
            string[] coords = Console.ReadLine().Split(' ');
            float x = float.Parse(coords[0]);
            float y = float.Parse(coords[1]);
            if(x == 0 || y == 0){
                System.Console.WriteLine("Ponto no eixo X ou Y");
            }else if(x > 0 && y > 0){
                System.Console.WriteLine("Q1");
            }else if(x > 0 && y < 0){
                System.Console.WriteLine("Q2");
            }else if(x < 0 && y > 0){
                System.Console.WriteLine("Q4");
            }else{
                System.Console.WriteLine("Q3");
            }
        }
    }
}
