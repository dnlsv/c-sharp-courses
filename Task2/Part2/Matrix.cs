using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Matrix
    {
        private int[] arr;
        public int Size
        {
            get { return arr.Length; }
        }

        public Matrix(params int[] mass)
        {
            if (mass == null)
                this.arr = new int[0];
            else
                this.arr = mass;
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
                        return arr[i];
                }
            }

            set
            {
                if (i == j)
                    if (i >= 0 || i <= Size)
                        arr[i] = value;
            }
        }

        public int Track()
        {
            int sum = 0;
            foreach (int item in arr)
                sum += item;
            return sum;
        }

        public Matrix Add(Matrix mtr)
        {
            if (this.Size > mtr.Size)
            {
                Matrix matrix = this;
                for (int i = 0; i < mtr.Size; i++)
                    matrix.arr[i] = this.arr[i] + mtr.arr[i];
                return matrix;
            }
            else
            {
                Matrix matrix = mtr;
                for (int i = 0; i < this.Size; i++)
                    matrix.arr[i] = this.arr[i] + mtr.arr[i];
                return matrix;
            }

        }

    }
}
