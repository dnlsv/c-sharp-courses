using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Circle : Figure
    {
        public int Radius { get; }

        public Circle(byte R, byte G, byte B, int radius) : base(R, G, B)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return 3.14 * Radius * Radius;
        }

        public override string ToString()
        {
            return $"Circle with radius {Radius}";
        }
    }
}
