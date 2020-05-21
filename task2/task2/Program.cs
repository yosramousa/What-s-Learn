using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
           employee e = new employee();
            company c = new company();
            c.Budget = 5000;
            List<employee> li = new List<employee>();
            c.employees.Add(new employee() { Salary = 1000, Name = "yosra" });
            c.employees.Add(new employee() {Salary = 2000, Name = "emy" });
            c.employees.Add(new employee() { Salary = 3000, Name = "smah" });
            Console.WriteLine(c.employees[0]);
            Console.WriteLine(c.employees[1]);
            Console.WriteLine(c.employees[2]);
            

            c.salaries += c.employees[0].IncreaseSalary;
            c.salaries += c.employees[1].IncreaseSalary;
            c.salaries += c.employees[2].IncreaseSalary;
            c.newsalary(1000);
       


         

            Console.ReadLine();
        }
    }
}
