using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class employee : Ipayable
    {
        public int Salary { get; set; }
        public void showPayment()
        {
            Console.WriteLine(1000);
        }
    }
}
}
