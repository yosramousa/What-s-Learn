using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int[] arr = new int[5] {1,100,200,300,400 };
             Console.WriteLine("lengh of arr", arr.Length);
             // Console.WriteLine("lengh of arr", arr.[0]); */
            int[,] arr = new int[2, 3];
            arr=[1, 1]= 50;
            Console.WriteLine(arr[1,1]);
            Console.WriteLine(arr.Length);



            Console.ReadLine ();
        }
    }
}
