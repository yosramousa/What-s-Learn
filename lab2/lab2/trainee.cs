using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class trainee : Ipayable ,IComparer<trainee>
    {
      public  int Salary { get; set; }

        public int Compare(trainee x, trainee y)
        {
            return 0;
        }

        public void showPayment()
        {
            Console.WriteLine(1000);
        }
    }
}
