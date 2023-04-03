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
            Training train = new Training();

            Practice practice1 = new Practice { Task = "123", Solution = "456" };
            Practice practice2 = new Practice { Task = "321", Solution = "654" };

            train.Add(practice1);
            train.Add(practice2);
            Console.WriteLine(train.isPractical());

            Lecture lecture = new Lecture { Topic = "789" };

            train.Add(lecture);
            Console.WriteLine(train.isPractical());

            Console.WriteLine(practice1.ToString());
            Console.WriteLine(practice2.ToString());
            Console.WriteLine(lecture.ToString());

            Console.ReadLine();
        }
    }
}
