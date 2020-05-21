using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqproject
{
    class Program
    {   

        static void Main(string[] args)
        {
            string str = "1";
            int Y = str.ToMyCustomID();
            Console.WriteLine(Y);
            string url = "jshoasflfjoewf/jefwvhwoiefvwukiedfe.docx";
            Console.WriteLine(url.GetFileExtention());


            List<customer> customerlist = new List<customer>();
           customerlist.Add(new customer() { ID = 1, Name = "yosra", Address = "Luxor" });
            customerlist.Add(new customer() { ID = 2, Name = "dina", Address = "minia" });
            customerlist.Add(new customer() { ID = 3, Name = "sohila", Address = "Aswan" });
            customerlist.Add(new customer() { ID = 4, Name = "hadeer", Address = "sohag"});
            customerlist.Add(new customer() { ID = 5, Name = "Ahmed", Address = "Aswan"});


            foreach (var c in customerlist)
            {
                Console.WriteLine(c.ToString());


            }
            customer cc = new customer(10,"yosra");
            Console.WriteLine(cc.Getcustomername());
            Console.ReadLine();
        }
    }
}
