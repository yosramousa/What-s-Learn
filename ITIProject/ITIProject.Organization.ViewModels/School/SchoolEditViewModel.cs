using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIProject.Organization.ViewModels
{
  public  class SchoolEditViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime OpenDate { get; set; }
    }
}
