using System;

namespace Point
{
    struct Point
    {
        public double X;
        public double Y;

        public override string ToString() {
            return $"cordinate ({X}, {Y})";
        }
     }
}