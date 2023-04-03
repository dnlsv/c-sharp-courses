using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    class Practice : Lesson
    {
        public string Task { get; set; }
        public string Solution { get; set; }

        public override string ToString()
        {
            return $"Task is {Task}, Solution is {Solution}";
        }
    }
}
