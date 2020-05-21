using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIProject.Organization.Entities
{
    public class Student : BaseModel
    {
        public virtual Person Person { get; set; }
        public override int ID { get; set; }
        public DateTime HireDate { get; set; }
        public virtual School School { get; set; }
        public int SchoolID { get; set; }
    }
}
