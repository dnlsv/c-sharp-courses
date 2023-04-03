using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03._3
{
    class Lecture : Lesson
    {
        public string Topic { get; set; }

        public override string ToString()
        {
            return $"Topic is {Topic}";
        }
    }
}
