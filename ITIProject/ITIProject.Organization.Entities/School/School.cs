using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIProject.Organization.Entities
{
    public class School : BaseModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime OpenDate { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
