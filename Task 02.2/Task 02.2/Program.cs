using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = {10, 30, 24, 49, 31};
            int[] _mass = { 10, 30, 24 };
            Matr matr = new Matr(mass);
            Matr _matr = matr.Add(new Matr(_mass));           

            Console.ReadLine();
        }
    }
}
