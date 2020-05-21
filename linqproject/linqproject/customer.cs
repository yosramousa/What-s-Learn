using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqproject
{
   public  class customer
    {

        public customer() { }
        
        public customer(int _id, string _name)
        {
            ID = _id;
            Name = _name;
        }
        public customer(int _id, string _name,string _address)
        {
            ID = _id;
            Name = _name;
            Address = _address;
         
        }
        public int ID { get; set; }
    
        public string Name { get; set; }

        public string Address { get; set; }
        public override string ToString()
        {
            return $"ID  : {ID}, Name: {Name}, Address:{Address} ";
        }
    }
}
