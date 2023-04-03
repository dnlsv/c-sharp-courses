using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03._1
{
    class Color
    {
        public byte R { get; }
        public byte G { get; }
        public byte B { get; }


        //public Color() { }
        public Color (byte _R, byte _G, byte _B)
        {
            R = _R;
            G = _G;
            B = _B;
        }

        public override string ToString()
        {
            if (R == 255 && G == 0 && B == 0)
                return "Red";
            if (R == 0 && G == 255 && B == 0)
                return "Green";
            if (R == 0 && G == 0 && B == 255)
                return "Blue";
            return $"R:{R}, G:{G}, B:{B}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (this.ToString() == obj.ToString())
                return true;
            else
                return false;
        }


    }
}
