using System;
using System.Globalization;
using Shape.Models.Enums;

namespace Shape.Models.Entities
{
    class Circle : ShapeAbstract
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override string ToString()
        {
            return $"Circle Color : {Color}, Radius: " + Radius.ToString("F2", CultureInfo.InvariantCulture) +
            ", Area: " + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}