using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ITIProject.Organization.ViewModels
{
  public  class PersonEditViewModel
    {
        [Required]
        public int ID { set; get; }
        //[MaxLength(200)]
        //[MinLength(5)]
        public string Name { set; get; }
        public string Address { set; get; }
        //[MaxLength(20)]
        //[MinLength(10)]
        public string Phone { set; get; }
    }
}
