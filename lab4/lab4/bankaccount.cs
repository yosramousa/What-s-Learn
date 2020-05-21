using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class @bankaccount
    {
        //private int number;
        //private int balance;
        //public void displaynum()
        //{

        //    Console.WriteLine("please enter your number:");
        //    number = int.Parse(Console.ReadLine());
        //    Console.WriteLine("please enter your balance:");
        //   balance = int.Parse(Console.ReadLine());
        //    Console.WriteLine("your Number is :"+ number); 
        //    Console.WriteLine("your balance is :" + balance);

        //}

        private int number=10;
        private decimal balance=2000;
        public static int x = 0;
        public void bankacc()
        {
            number = 10;
            balance = 2000;

        }

        public void Setvalues(int amount)
        {
            if (amount > 1000)
            {
                return;
            }
            else
            //Balance = Balance + amount;
            {
                balance += amount;
                number = number + amount;
            }

            Console.WriteLine("your number is: " + number + "your balance is: " + balance);

        }
        public decimal GetBalance()
        {
            //Balance = Balance - amount;
            return balance - 1000;
           
        }
        public   void account()
        {
        
           x++;
            
        }
        public static int countershow()
        {
            return x;
        }

        public bankaccount()
        {
            account();

        }
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

