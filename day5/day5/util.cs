using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    class util { 
    
        public static string reverse(string x)
        {
            char[] array = x.ToCharArray();
            Array.Reverse(array);
            return new string(array);

        }
        public static void Reverse(string message)
        {
            StringBuilder reverse = new StringBuilder();
            for(int i = message.Length - 1; i >= 0; i--)
            {
                reverse.Append(message[i]);
            }
            Console.WriteLine("reverse message is:" + reverse);
        }
        public static void showReverse()
        {
            Console.WriteLine("Enter messgae to reverse :" );
            string message = Console.ReadLine();
            Reverse( message);
        }


        public static bool isitformattable(object ob)
        {
            //  return ob is (isitformatble);
            if (ob is IFormattable)
                return true;

            return false;


        }
    }
}
