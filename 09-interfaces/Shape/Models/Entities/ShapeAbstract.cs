using System;
using Shape.Models.Enums;

namespace Shape.Models.Entities
{
    abstract class ShapeAbstract : IShape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}