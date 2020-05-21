using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseIndexers
{
    class Program
    {
        static void Main(string[] args)
        {
        
            EvenArray arr = new EvenArray(10);
            arr[1] = 2;
            Console.WriteLine(arr[1]);
            arr[2] = 5;
            Console.WriteLine(arr[2]);
            Console.ReadLine();



            //EvenArray array = new EvenArray();
            //int value = int.Parse(Console.ReadLine());
            //if (value % 2 == 0)
            //{
            //    array.superarray[0] = value;
            //    Console.WriteLine(array.superarray[0] * 10 );
            //}
            //else
            //{

            //    throw new Exception("invalid..Only even numbers are added");
            //}

        }
    }
}
