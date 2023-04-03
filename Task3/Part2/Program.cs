using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {

            Figure[] figure = {
                new Rectangle(100, 100, 100, 100, 100),
                new Circle(100, 100, 100, 100)
            };
            for (int i = 0; i < figure.Length; i++)
            {
                Console.WriteLine(figure[i].ToString());
                Console.WriteLine(figure[i].Area());
            }
            Console.ReadLine();
        }
    }
}
