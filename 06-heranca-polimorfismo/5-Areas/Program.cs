using System;
using System.Globalization;
using System.Collections.Generic;
using _5_Areas.Entities;
using _5_Areas.Entities.Enum;

namespace _5_Areas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> figures = new List<Shape>();
            Console.Write("Enter with the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c): ");
                char letter = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red/Orange/Green): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(letter == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    figures.Add(new Circle(color, radius));
                }else{
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    figures.Add(new Rectangle(color, width, height));
                }

            }
            Console.WriteLine("Shape Areas:");
            foreach (Shape fig in figures)
            {
                Console.WriteLine($"Area: {fig.Area().ToString("f2", CultureInfo.InvariantCulture)}, Color: {fig.Color}");
            }
        }
    }
}
