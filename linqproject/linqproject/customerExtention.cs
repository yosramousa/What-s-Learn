using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqproject
{
    public static class customerExtention
    {
        // 8 
      
        public static int ToMyCustomID(this string ID)
        {

         
            return int.Parse(ID);
        }

        // 9
        public static string GetFileExtention(this string fileurl)
        {
            string[] urlsplit = fileurl.Split('.');
            return urlsplit[1];
        }
      
        public static string Getcustomername(this customer _customer)
        {
            return "welcome soly" + _customer.Name;
        }
    }
}
