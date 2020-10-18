using System;
using System.Globalization;
using Shape.Models.Enums;

namespace Shape.Models.Entities
{
    class Rectangle : ShapeAbstract
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
        public override string ToString()
        {
            return $"Rectangle Color : " + Color + ", Width: " + Width.ToString("F2", CultureInfo.InvariantCulture) +
            ", Height: " + Height.ToString("F2", CultureInfo.InvariantCulture) +
            ", Area: " + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}