using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Program
    {




        static void Main(string[] args)
        {
            //test.show();
          // Console.WriteLine("please enter num 1:");
            int n1 = int.Parse(Console.ReadLine());
            // int n1 = 10;
            int n2 = int.Parse(Console.ReadLine());
            // Console.WriteLine("please enter num 2:");
           // int n2 = 20;
          //  int x = uc.Greater(var1, var2);
           // Console.WriteLine(x);
           
            test.swap(ref n1, ref n2);
            Console.WriteLine( "fn:" + " " +n1 +" "+ "sn:" + " "+n2);

            

            Console.ReadLine();
        }

    }
}