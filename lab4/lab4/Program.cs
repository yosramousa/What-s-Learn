using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            bankaccount account = new bankaccount();
            bankaccount account1 = new bankaccount();
            bankaccount account2 = new bankaccount();
            //account.bankacc();
            //account.Setvalues(2000);
            //    Console.WriteLine("your number is: " + +number + " & your balance is: "+ balance);

            // account.account();
            Console.WriteLine(bankaccount.countershow());
            //  account.GetBalance();
            //  account.Setvalues(1000);
            account1.deposit(1000);
            account1.withdraw(1000);

            Console.ReadLine();
        }
    }
}
