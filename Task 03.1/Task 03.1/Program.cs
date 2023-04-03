using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Color color = new Color(255, 1, 0);
            Color color_2 = new Color(255, 1, 0);
            Console.WriteLine(color.Equals(color_2));
            Console.ReadLine();
        }
    }
}
