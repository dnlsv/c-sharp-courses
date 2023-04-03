using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03._2
{
    abstract class Figure
    {
        public Color Col { get; }

        //public Figure(){}

        public Figure(byte R, byte G, byte B)
        {
            Col = new Color(R, G, B);
        }

        public abstract double Area();

    }
}
