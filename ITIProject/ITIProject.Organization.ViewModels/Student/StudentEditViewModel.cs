using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIProject.Organization.ViewModels
{
    public class StudentEditViewModel
    {     
        [Required]
        public int ID { get; set; }
        [MaxLength(200)]
        [MinLength(5)]
        public string Name { set; get; }
        public string Address { set; get; }
        [MaxLength(20)]
        [MinLength(10)]
        public string Phone { set; get; }
        public int SchoolID { set; get; }
        public DateTime HireDate { get; set; }
    }
}
