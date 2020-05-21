using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
  public  class Book :IComparable ,ICloneable
    {
        private int id;
        private string name;
        public int ID {
            get { return id; }
            set { id= value; }
        }
        public string Name { 
            get { return name; }
            set { name = value; }
        }
        public Book() { }

       




        public int CompareTo(Book obj)
        {
            if (this.ID > obj.ID)
                return 1;
            else if (this.ID < obj.ID)
                return -1;
            else
                return 0;
        }
        public object Clone()
        {
            return new Book() { ID = this.ID, Name = this.Name };
        }
        public override string ToString()
        {
            return $"ID = {ID}, Name= {Name}";
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}





    
