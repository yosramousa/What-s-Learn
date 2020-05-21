using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class employee 
    {
        public employee()
        {
        }
        private float salary;
        private string name;
        public float Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void IncreaseSalary(float amount)
        {
            salary += amount;
            Console.WriteLine("we're in IncreaesSalary function in class employee..");



        }
        public override string ToString()
        {
            return ("Salary:"+ salary+" "+"Name:"+name);
        }

    }

}
