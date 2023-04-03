using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.X = 1;
            point.Y = 2;
            point.Z = 3;
            point.Mass = 5;

            Console.WriteLine(point.isZero());

            Console.WriteLine(point.distance(new Point(4, 5, 6)));

            Console.WriteLine(point.Mass + " " + point.X + " " + point.Y + " " + point.Z);
            Console.ReadLine();
        }
    }

}


