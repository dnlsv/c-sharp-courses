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
            Console.Write("Input a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            String binaryA;
            int count;
            bool flag = false;

            for (int i = a; i <= b; i++)
            {
                binaryA = Convert.ToString(a, 2);

                count = 0;
                for (int j = 0; j < binaryA.Length; j++)
                {
                    if (binaryA[j] == '1')
                        count++;
                }

                if (count == 4)
                {
                    flag = true;
                    Console.Write(a + " ");
                }

                a++;
            }

            if (flag == false)
                Console.WriteLine("No numbers found");

            Console.ReadLine();
        }
    }
}
