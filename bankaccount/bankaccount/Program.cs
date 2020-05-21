using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankaccount
{
    class Program
    {
        static void Main(string[] args)
        {
            bankaccount ac1, ac2, ac3, ac4;
            ac1 = new bankaccount();
            ac2 = new bankaccount(Accounttype.saving);
            ac3 = new bankaccount(100);
            ac4 = new bankaccount(Accounttype.checking,500);
            Console.WriteLine(ac1);
            Console.WriteLine(ac2);
            Console.WriteLine(ac3);
            Console.WriteLine(ac4);
            Console.WriteLine(bankaccount.Nextnumber());
            Console.ReadLine();
            

        }
    }
}
