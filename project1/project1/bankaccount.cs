using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class bankaccount
    {
        private int accnum=10;
        private decimal balance=20;
        private string acctype;




 
        public void deposit(decimal value)
        {

            balance += value;
            Console.WriteLine(balance);
        }
        public void withdraw(decimal x)
        {
            if (x <= balance)
            {
                balance -= x;

            }

            Console.WriteLine(x);
        }
    }
}