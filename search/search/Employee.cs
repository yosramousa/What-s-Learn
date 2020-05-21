using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search
{
    class Employee
    {  
      public int id { set; get; }
        public string name { set; get; }

        public int salary{ set; get; }

        public override string ToString()
        {
            return $"ID  : {id}, Name: {name}, Address:{salary} ";
        }

    }
     class EmployeeComparer : IEqualityComparer<Employee>
    {
        public EmployeeComparer()
        {
        }
        public bool Equals(Employee x, Employee y)
        {
            if (x.id == y.id &&
                     x.name.ToLower() == y.name.ToLower())
                return true;

            return false;
        }

        public int GetHashCode(Employee obj)
        {
            return obj.GetHashCode();
        }
    }
}
