using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    class bankaccount
    {  private int number;
    public decimal balance;
       public  static void transferfrom( bankaccount acount1,bankaccount acount2,decimal amount)
        {
            //acount1 = new bankaccount();
            acount1.balance -=amount;


           // acount2 = new bankaccount();
            acount2.balance += amount;




        }

        //public banckaccount(decimal bal)
        //{
        //    balance = bal;

        //}

        public void SetBalance(decimal bal)
        {
            if (bal > 100)
            {

                balance -= bal;
            }
            else
            //Balance = Balance + amount;
            {
                Console.WriteLine("sorry!");
                
            }


        }
        public decimal GetBalance()
        {
            balance = 100;

            return balance;

        }
        public decimal deposit(decimal amount)
        {
            balance += amount;
            return balance;
        }
        public bool withdraw(decimal amount)
        {
            bool sufficientFunds = balance >= amount;
            if (sufficientFunds)
            {
                balance -= amount;
            }
            return sufficientFunds;
        }

        public void transferfrom(bankaccount accfrom, decimal amount)
        {
            if (accfrom.withdraw(amount))
            {
                this. deposit(amount);
            }
        }
    }


}
