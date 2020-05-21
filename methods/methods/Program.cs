using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{  /* public class test
    {
        Console.writeline("Enter first number");
           int x=int.parse(Console.readline());
        Console.writeline("Enter second number");
           int y=int.parse(Console.readline());


    }
    public class Utils
    {
        public int Greater(int x, int y)
        {
            if (x > y)
            {
                return x;
            }
            else
            { return y; }
           Console.WriteLine(Greater(20, 40));
            return 0;
        }
        */
}
    class Program
    { public void swap(ref int a, ref int b) { int t; t = a; a = b; b = t; } }
    static void Main(string[] args)
    {

        Swap ob = new Swap(); int x = 10, y = 20; Console.WriteLine("x and y before call: " + x + " " + y); ob.swap(ref x, ref y); Console.WriteLine("x and y after call: " + x + " " + y);
    }
}

    Console.Read();
      



    }
}}