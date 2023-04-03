using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02._2
{
    class Matr
    {
        private int[] mass;
        public int Size
        {
            get { return mass.Length; }
        }

        public Matr(params int[] mass)
        {
            if (mass == null)
                this.mass = new int[0];
            else
                this.mass = mass;
        }

        public int this[int i, int j]
        {
            get 
            {
                if (i != j)
                    return 0;
                else
                {
                    if (i < 0 || i > Size)
                        return 0;
                    else
                        return mass[i];
                }
            }

            set 
            {
                if (i == j)
                    if (i >= 0 || i <= Size)
                        mass[i] = value;
            }       
        }

        public int Track()
        {
            int sum = 0;
            foreach (int item in mass)
                sum += item;
            return sum;            
        }

        public Matr Add(Matr matr)
        {
            if (this.Size > matr.Size)
            {
                Matr _matr = this;
                for (int i = 0; i < matr.Size; i++)
                    _matr.mass[i] = this.mass[i] + matr.mass[i];
                return _matr;
            }
            else
            {
                Matr _matr = matr;
                for (int i = 0; i < this.Size; i++)
                    _matr.mass[i] = this.mass[i] + matr.mass[i];
                return _matr;
            }
            
        }

    }
}
