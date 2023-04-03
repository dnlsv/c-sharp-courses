using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03._2
{
    class Rectangle : Figure
    {
        public int Width { get; }
        public int Height { get; }

        public Rectangle(byte R, byte G, byte B, int width, int height) : base(R, G, B)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return $"Rectangle with sides {Width} and {Height}";
        }


    }
}
