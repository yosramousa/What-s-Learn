using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modifystring
{
    class Program
    {
        static void Main(string[] args)
        {
          DateTime d = DateTime.Now;
            Console.WriteLine(d);
            d.getDayAsstring();


            Console.Read();
        }
    }
}
