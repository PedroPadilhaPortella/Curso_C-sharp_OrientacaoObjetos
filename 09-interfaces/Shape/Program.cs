using System;
using System.Globalization;
using Shape.Models.Entities;
using Shape.Models.Enums;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape c1 = new Circle() {Radius = 2.0, Color = Color.Black};
            IShape r1 = new Rectangle() {Width = 3.5, Height = 4.0, Color = Color.White};
            System.Console.WriteLine(c1);
            System.Console.WriteLine(r1);
        }
    }
}
