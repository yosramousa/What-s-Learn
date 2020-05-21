using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {


            Point[] array =
                    { new Point(50), new Point(5), new Point(70)};

            Array.Sort(array);
            foreach (Point p in array)
                Console.WriteLine(p.X);

            Point p1 = new Point(12);
            Point p2;
            p2 =(Point) p1.Clone();
            Console.WriteLine(p2);

            Console.ReadLine();
        }
    }
}
