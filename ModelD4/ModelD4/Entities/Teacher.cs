using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelD4.Entities
{
    [Table("Teacher", Schema = "dbo")]
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int ID { set; get; }
        public virtual  School School { set; get; }
        [ForeignKey("School")]
        public virtual int SchoolId { set; get; }
        [Required]
        [MaxLength(250)]
        public virtual string Name { set; get; }
        public virtual DateTime BirthDate { set; get; }
        public int Code { set; get; }
        [Required]
        [MaxLength(50)]
        public virtual string job { set; get; }
        [Required]
        [MaxLength(250)]
        public virtual string Phone { set; get; }
        [Required]
        [MaxLength(250)]
        public virtual string Qualification { set; get; }
        [Required]
        public virtual DateTime QualficationDate { set; get; }
        [Required]
        public virtual DateTime HiringDate { set; get; } = DateTime.Now;
        [Required]
        public virtual string Address { set; get; }
        public string Notes { set; get; }


        public virtual ICollection<TeacherTransfer> TeacherTransfer { set; get; }



    }
}
