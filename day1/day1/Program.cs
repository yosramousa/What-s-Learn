using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    enum BankAccoount
    {
        checking,
        savings

    }
    struct BanckAcc
    {
        public long num;
        public decimal balance;
        public BankAccoount type;




    }
    class Program
    {
        static void Main(string[] args)
        {
            // How to read & display string from user
            /* Console.WriteLine("Please Enter your name");
             string name;
             name = Console.ReadLine();
             Console.WriteLine("GoodMorning" + " " + name);
             Console.Read(); */


            //How to make try&catch
            /*  int num1, num2, res;
              Console.WriteLine("Please Enter First Number");
              num1 = int.Parse(Console.ReadLine());
              Console.WriteLine("Please Enter Secong Number");
              num2 = int.Parse(Console.ReadLine());
              res = num1 / num2;
              Console.WriteLine("The Result is" + " " + res);
              try
              {
                  res = SafeDivision(num1, num2);
                  Console.WriteLine("{0} divided by {1} = {2}", num1, num2, res);
              }
              catch (DivideByZeroException e)
              {
                  Console.WriteLine("Attempted divide by zero.");
              }
          

          private static int SafeDivision(int num1, int num2)
          {
              throw new NotImplementedException();
          }
         */
            /*  BankAccoount test1 = BankAccoount.checking;
              BankAccoount test2 = BankAccoount.savings;



              Console.WriteLine(test1);
              Console.WriteLine(test2);

              BanckAcc bank = new BanckAcc();
              bank.num = 10;
              bank.balance = 20;
              bank.type = BankAccoount.checking; */



            /* Console.WriteLine(bank.num);
               Console.WriteLine(bank.balance);
               Console.WriteLine(bank.type);*/
            /*   Console.WriteLine("Enter your number");
               bank.num = long.Parse(Console.ReadLine());
               Console.WriteLine("Enter your balance");
               bank.balance = decimal.Parse(Console.ReadLine());
               Console.WriteLine(bank.num + " " + bank.balance);

               // Console.WriteLine("Type");
               int num = int.Parse(Console.ReadLine());
               switch (num) {
                   case 1:
                       Console.WriteLine("cheking=");
                       bank.type = BankAccoount.checking;

                       break;
                   case 2:
                       Console.WriteLine("savings=");

                       bank.type = BankAccoount.savings;

                       break;
               }
               */






            // lab2 ass2 task1 :

            //int dayNum = 0;
            //int monthNum = 0;
            //Console.WriteLine(" Please Enter any Integer Number betwen 1:365 ");
            //dayNum = int.Parse(Console.ReadLine());
            //if (dayNum <= 1 && dayNum >= 365)
            //{
            //    Console.WriteLine(" Day is out of range");
            //}
            //if (dayNum <= 31)
            //{ // january
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 31;
            //    monthNum++;
            //}
            //if (dayNum <= 28)
            //{ // February
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 28;
            //    monthNum++;
            //}
            //if (dayNum <= 31)
            //{ // March
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 31;
            //    monthNum++;

            //}
            //if (dayNum <= 30)
            //{ // April
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 30;
            //    monthNum++;
            //}
            //if (dayNum <= 31)
            //{ // May
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 31;
            //    monthNum++;
            //}
            //if (dayNum <= 30)
            //{ // June
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 30;
            //    monthNum++;
            //}
            //if (dayNum <= 31)
            //{ // July
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 31;
            //    monthNum++;
            //}
            //if (dayNum <= 31)
            //{ // August
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 31;
            //    monthNum++;
            //}
            //if (dayNum <= 30)
            //{ // September
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 30;
            //    monthNum++;
            //}
            //if (dayNum <= 31)
            //{ // October
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 31;
            //    monthNum++;
            //}
            //if (dayNum <= 30)
            //{ // November
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 30;
            //    monthNum++;
            //}
            //if (dayNum <= 31)
            //{ // December
            //    goto End;
            //}
            //else
            //{
            //    dayNum -= 31;
            //    monthNum++;
            //}
            //End:
            //string monthName;
            //switch (monthNum)
            //{
            //    case 0:
            //        monthName = "January"; break;
            //    case 1:
            //        monthName = "February"; break;
            //    case 2:
            //        monthName = "March"; break;
            //    case 3:
            //        monthName = "April"; break;
            //    case 4:
            //        monthName = "May"; break;
            //    case 5:
            //        monthName = "June"; break;
            //    case 6:
            //        monthName = "July"; break;
            //    case 7:
            //        monthName = "August"; break;
            //    case 8:
            //        monthName = "September"; break;
            //    case 9:
            //        monthName = "October"; break;
            //    case 10:
            //        monthName = "November"; break;
            //    case 11:
            //        monthName = "December"; break;
            //    default:
            //        monthName = "Error"; break;
            //}
            //Console.WriteLine("{0} {1}", dayNum, monthName);

            //int hour = 0;
            //Console.WriteLine("Please Enter any Number");
            //hour = int.Parse(Console.ReadLine());
            //if (hour >= 0 && hour < 24)
            //{
            //    Console.WriteLine("True..This Number is greater than or equal to zero and less than 24");
            //}
            //else
            //{
            //    hour = 0;
            //    Console.WriteLine("Try Again");
            //}

            //Console.WriteLine("Please Enter any Number");
            //int hour = 0;
            //int attempt = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    do
            //    {
            //        hour = int.Parse(Console.ReadLine());
            //        Console.WriteLine("True" + " " + hour);
            //    }

            //    while (!(hour >= 1 && hour <= 23));

            //}
            Console.WriteLine("Please Enter any Number");
            int hour;
            //int attempt = 0;
            for (int i = 0; i < 5; i++)
            { hour = int.Parse(Console.ReadLine());
                if (!(hour >= 1 && hour <= 23)) {
                    Console.WriteLine("Please Try again");
                }
                else { i = 5;
                    //  Console.WriteLine("True");
                    break;
                }
              
            }

          //  Console.WriteLine("True");



            /*  for (int hour = 0; hour <= 24; hour++)
              {
                  Console.WriteLine("Please Enter any Number");
                  hour = int.Parse(Console.ReadLine());
              } */
            /*  int percent = 0;
              Console.WriteLine("Please Enter any Number");
              percent = int.Parse(Console.ReadLine());
              if (percent<0 && percent > 100)
              {
                  Console.WriteLine(" Out Of Range Exception");
              } */
            Console.Read();
        }


    }
}

        
