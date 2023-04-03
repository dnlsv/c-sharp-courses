using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Color color1 = new Color(255, 1, 0);
            Color color2 = new Color(255, 1, 0);
            Console.WriteLine(color1.Equals(color2));
            Console.ReadLine();
        }
    }
}
