using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02._1
{
    public class Point
    {
        private int [] arr = new int [3];
        private double mass;

        public Point()
        {

        }

        public Point(params int [] arr)
        {
            this.arr[0] = arr[0];
            this.arr[1] = arr[1];
            this.arr[2] = arr[2];
        }

        public Point(double mass, params int[] arr)
        {
            arr[0] = arr[0];
            arr[1] = arr[1];
            arr[2] = arr[2];
            this.mass = mass;
        }
        public double Mass
        {
            get => mass;
            set => mass = value > 0 ? value : 0; 
        }

        public int X
        {
            get => arr[0];
            set { arr[0] = value; }
        }

        public int Y
        {
            get => arr[1];
            set { arr[1] = value; }
        }
        public int Z
        {
            get => arr[2];
            set { arr[2] = value; }
        }

        public bool isZero()
        {
            if (arr[0] == 0 && arr[1] == 0 && arr[2] == 0)
                return true;
            else
                return false;
        }

        public double distance(Point point)
        {
            return Math.Sqrt(
                Math.Pow((point.arr[0]-arr[0]),2) +
                Math.Pow((point.arr[1] - arr[1]), 2) +
                Math.Pow((point.arr[2] - arr[2]), 2)
                );
        }

    }
}
