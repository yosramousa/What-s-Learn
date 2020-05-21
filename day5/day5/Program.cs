using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    class Program
    {
        static void Main(string[] args)
        {
            util b = new util();
            //Console.WriteLine(util.reverse("yosra"));
            //Console.WriteLine(util.reverse("emy"));
            //Console.WriteLine(util.reverse("hello worled"));
            //util.showReverse();
            //file.showfile();

            bankaccount acount1 = new bankaccount();
            acount1.balance = 100;
            bankaccount acount2 = new bankaccount();
            acount2.balance = 100;

            bankaccount.transferfrom(acount1, acount2, 10);
            Console.WriteLine(acount1.balance);
            Console.WriteLine(acount2.balance);


            acount1.transferfrom(acount2, 10);
            Console.WriteLine(acount1.balance);
            Console.WriteLine(acount2.balance);
            acount2.balance = 0;
        //    b1.transferfrom();
            //banckaccountt c1 = new banckaccountt();
            //banckaccountt c2 = new banckaccountt();
            // c1.Populate(1000);
            // c1.deposit(1000);
            // c1.withdraw(1000);
            // c1.transferfrom(c2,10);
            // Console.WriteLine("After transfer");
            // Console.WriteLine("{0} {1}",
            //c1.atype,  c1.balance);
            // Console.WriteLine("{0} {1} ",
            // c2.atype, c2.balance);

            //Console.WriteLine(util.isitformattable("yosra"));
            //Console.WriteLine(util.isitformattable(10));


            Console.ReadLine();

        }
    }
}

