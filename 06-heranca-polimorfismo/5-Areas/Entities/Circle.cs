using _5_Areas.Entities.Enum;
using System;

namespace _5_Areas.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set ;}
        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}