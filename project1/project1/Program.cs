using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bankaccount account = new bankaccount();
            bankaccount account1 = new bankaccount();
            bankaccount account2 = new bankaccount();
            account.deposit(1000);
            account.withdraw(1000);


            Console.Read();
        }

    }
}
