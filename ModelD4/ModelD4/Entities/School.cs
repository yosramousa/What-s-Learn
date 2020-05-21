using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelD4.Entities
{
    [Table("School", Schema = "dbo")]
    public class School
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual  int ID { set; get; }
        public virtual  Department Department { set; get; }
     
        [ForeignKey("Department")]
        public virtual int? DepartmentID { set; get; }
        [Required]
        [MaxLength(250)]
        public virtual String Name { set; get; }
        [Required]
        public virtual String Type { set; get; }
        public virtual  ICollection<Teacher> Teacher { set; get; }


        [InverseProperty("School")]
        public virtual ICollection<TeacherTransfer> TeacherTransfer { set; get; }
        [InverseProperty("School1")]
        public virtual ICollection<TeacherTransfer > TeacherTransfer1  { get; set; }

    }
}
