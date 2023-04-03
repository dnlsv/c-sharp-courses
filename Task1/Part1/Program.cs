using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Input miles: ");
            string s = Console.ReadLine();
            double miles = double.Parse(s);
            Console.WriteLine("In kilometers: " + miles * 1.609);
            Console.ReadLine();
            */

            Console.Write("Input temperature (°С) ");
            double tempC = Convert.ToDouble(Console.ReadLine());

            double tempF = (9 * tempC / 5) + 32;

            Console.Write("Input wind speed (m/s) ");
            double speedMS = Convert.ToDouble(Console.ReadLine());

            double speedMPH = speedMS * 2.237;

            double w = (35.74 + 0.6215 * tempF + (0.4275 * tempF - 35.75) * Math.Pow(speedMPH, 0.16) - 32) * 5 / 9;
            Console.WriteLine("Effective air temperature: " + w);

            if (tempF > 50 || speedMPH > 120 || speedMPH < 3)
                Console.WriteLine("Result may not be correct");

            Console.ReadLine();
            //Console.ReadKey();
        }
    }
}
