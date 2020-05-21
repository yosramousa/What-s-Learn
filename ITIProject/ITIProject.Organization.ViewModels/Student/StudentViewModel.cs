using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIProject.Organization.ViewModels
{
    public class StudentViewModel
    {
        public int ID { get; set; }
        public string Name { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string SchoolName { set; get; }
        public DateTime HireDate { get; set; }
    }
}
