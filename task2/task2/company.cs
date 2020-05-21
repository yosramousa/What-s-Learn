using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public delegate void Newsalary(float item);
     
    public class company : List<employee>
        
    {
        public event Newsalary salaries;
        private string name;
        private float budget;
      
        public List<employee> employees;
        public company()
        {
            employees = new List<employee>();

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public float Budget
        {
            get { return budget; }
            set { budget = value; }
        }

        public void newsalary(float item)
        {
            Console.WriteLine("salary in my newsalary function in class company");
            salaries(item);
            //Budget -= item;


            this.Budget -= (employees.Count) * item;
            Console.WriteLine(Budget);
        }



        }
}
