using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Point : IComparable, ICloneable
    {
        public Point() { }
        public Point(int x) { X = x; }






        public int X { get; set; }

        public object Clone()

        {
            Point p1 = new Point(X);
            return p1;

        }

        public int CompareTo(object obj)
        {
            // throw new NotImplementedException();
            Point P = obj as Point;
            if (this.X == P.X)
                return 0;
            else if (this.X > P.X)
                return 1;
            else
                return -1;

        }
        public override string ToString()
        {
            return X.ToString();
        }
    }



}