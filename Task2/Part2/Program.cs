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
            int[] arr1 = { 10, 30, 24, 49, 31 };
            int[] arr2 = { 10, 30, 24 };
            Matrix mtr1 = new Matrix(arr1);
            Matrix mtr2 = mtr1.Add(new Matrix(arr2));

            Console.ReadLine();
        }
    }
}
