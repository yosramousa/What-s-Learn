using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankaccount
{   public  enum Accounttype {
        checking,saving
    }
    class bankaccount
    {
        public int number;
        public Accounttype accounttype;
        decimal balance;
        public static int  nextnumber=0;
        public static int Nextnumber()
        {
            return(nextnumber++);
        }
        public decimal deposit(decimal amount)
        {
            balance += amount;
            return balance;
        }

        public bankaccount( )
        {
            balance = 0;
            number = Nextnumber() ;
            accounttype = Accounttype.checking;
        }
        public bankaccount(Accounttype accounttype )
        {
            balance = 0;
            number = Nextnumber() ;
         this.accounttype = accounttype;
        }
        public bankaccount(decimal bal)
        {
            balance = bal;
            number = Nextnumber();
            accounttype = Accounttype.saving;
        }
        public bankaccount(Accounttype accounttype,decimal bal)
        {
            balance = bal;
            number = Nextnumber();
            this.accounttype = accounttype;
        }

    }
}
