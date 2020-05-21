using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operate_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            string y = "yosra";
            string z = y + x;
            Console.WriteLine(z);

            cars c1 = new cars(200);
            cars c2 = new cars(300);
            //c1.Display();
            var c = c1 + c2;
            var cc = c1 - c2;
            var ccc = c1 * c2;
            var cccc = c1 / c2;
            c.Display();
            cc.Display();
            ccc.Display();
            cccc.Display();
            Console.ReadLine();
        }
    }
}
