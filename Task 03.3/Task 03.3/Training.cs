using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03._3
{
    class Training : Template
    {
        Lesson[] less = new Lesson[0];

        public void Add(Lesson _less)
        {
            Array.Resize(ref less, less.Length + 1);
            less[less.Length - 1] = _less;
        }

        public bool isPractical()
        {
            foreach(Lesson item in less)
            {
                if (item.GetType() == typeof(Lecture))
                    return false;
            }
            return true;
        }
        
    }
}
