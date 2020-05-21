using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    public enum Accounttype
    {
        checking, saving
    }
    class banckaccountt
    {
        private int number;
      public decimal balance;
       public Accounttype atype;
        public static int nextnumber = 0;

        public static int Nextnumber()
        {
            return nextnumber++;
        }        public void Populate(decimal balance)
        {
            number = Nextnumber();
            this.balance = balance;
            atype = Accounttype.checking;
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

        public static void testwithdraw(banckaccountt acc)
        {
            Console.Write("Enter amount to withdraw: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            if (!acc.withdraw(amount))
            {
                Console.WriteLine("sorry! ..you haven't enough money");
            }


        }
            public void transferfrom(banckaccountt accfrom, decimal amount)
            {
                if (accfrom.withdraw(amount))
                {
                    this.deposit(amount);
                }
            }
        }
    } 
