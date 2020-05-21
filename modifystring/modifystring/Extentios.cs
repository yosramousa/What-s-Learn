using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modifystring
{
   public static class Extentios
    {

        public static string getDayAsstring(this DateTime d)
        {

            string asString = d.ToString("dd MMMM yyyy hh:mm:ss tt");
            Console.WriteLine(asString);
            return  asString ;
        }

    }
}
