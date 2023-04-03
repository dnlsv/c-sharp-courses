using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input 9 character-numbers: ");
            String str = Console.ReadLine();
            int sum;
            String d10 = "";

            for (int i = 0; i <= 10; i++)
            {
                sum = 10 * Int32.Parse(str[0].ToString()) +
                    9 * Int32.Parse(str[1].ToString()) +
                    8 * Int32.Parse(str[2].ToString()) +
                    7 * Int32.Parse(str[3].ToString()) +
                    6 * Int32.Parse(str[4].ToString()) +
                    5 * Int32.Parse(str[5].ToString()) +
                    4 * Int32.Parse(str[6].ToString()) +
                    3 * Int32.Parse(str[7].ToString()) +
                    2 * Int32.Parse(str[8].ToString()) +
                    1 * i;
                if (sum % 11 == 0)
                {
                    if (i == 10)
                        d10 = Convert.ToString('X');
                    else
                        d10 = Convert.ToString(i);
                    break;
                }
            }

            String isbn = str + d10;
            Console.WriteLine("Final ISBN: " + isbn);

            Console.ReadLine();
        }
    }
}
