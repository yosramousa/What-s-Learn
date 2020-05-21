using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operate_overloading
{
  public   class cars
    {
        public int carPrice;
        public cars(int carPrice)
        {
            this.carPrice = carPrice;
        }

        public void Display()
        {

            Console.WriteLine("Car Price:" + carPrice);
        }
        public static cars operator+(cars first, cars second)
        {
            cars c = new cars(first.carPrice + second.carPrice);
            return c;



        }
        public static cars operator -(cars first, cars second)
        {
            cars c = new cars(first.carPrice - second.carPrice);
            return c;
        }
        public static cars operator *(cars first, cars second)
        {
            cars c = new cars(first.carPrice * second.carPrice);
            return c;
        }
            public static cars operator /(cars first, cars second)
        {
            cars c = new cars(first.carPrice / second.carPrice);
            return c;
        }
    }

    }

