using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Training train = new Training();

            Practice practice_1 = new Practice { Task = "123", Solution = "456" };
            Practice practice_2 = new Practice { Task = "321", Solution = "654" };

            train.Add(practice_1);
            train.Add(practice_2);
            Console.WriteLine(train.isPractical());

            Lecture lecture = new Lecture { Topic = "789" };

            train.Add(lecture);
            Console.WriteLine(train.isPractical());

            Console.WriteLine(practice_1.ToString());
            Console.WriteLine(practice_2.ToString());
            Console.WriteLine(lecture.ToString());

            Console.ReadLine();
        }
    }
}
