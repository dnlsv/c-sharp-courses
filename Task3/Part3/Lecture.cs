using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
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
