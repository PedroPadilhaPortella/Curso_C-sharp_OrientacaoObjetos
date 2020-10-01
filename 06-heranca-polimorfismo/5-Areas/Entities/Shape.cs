using _5_Areas.Entities.Enum;

namespace _5_Areas.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }
        public Shape(Color color)
        {
            Color = color;
        }
        public abstract double Area();
    }
}