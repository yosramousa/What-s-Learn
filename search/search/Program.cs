using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search
{     //Quantifier operator 
    //Any ()
    //All() return true if  all elements satisfy the condition
    //contains ()

    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> li = new List<Employee>()

        {

            new Employee{id=1,name="Hamada",salary=50000},

           new Employee{id=2,name="HamadaEl3aw",salary=30000},

          new Employee{id=3,name="Yosra",salary=50000},

          new Employee{id=4,name="Hamadabrdo",salary=40000},

          new Employee{id=5,name="hamadaELGen",salary=10000},

        };



            //var list = li.Select(x => new { ID = x.id, Name = x.name });
            //var list = li.ToList();


            //foreach (var item in li)
            //{
            //    Console.WriteLine(item.ToString());

            //}

            //Console.ReadLine();



            //bool b = li.Any(x => x.salary > 30000);
            //Console.WriteLine(b);



       
          //Employee std = new Employee() { id = 4, name = "Hamadabrdo", salary = 200000 };
          //  bool result = li.Contains(std);
          //  Console.WriteLine(result);

            Employee std1 = new Employee() { id = 3, name = "Yosra", salary = 50000 };
            bool result1 = li.Contains(std1, new EmployeeComparer());
            Console.WriteLine(result1);


            //bool a = li.All(x => x.salary >= 10000);
            //Console.WriteLine(a);


            //bool c = li.All(x => x.salary > 50000);
            //Console.WriteLine(c);



            Console.ReadLine();

        }

    }

  
}
