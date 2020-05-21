using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelD4.Entities
{
    [Table("TeacherTransfer", Schema = "dbo")]
    public class TeacherTransfer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual  int ID { set; get; }
        public virtual  Teacher Teacher { set; get; }
        [ForeignKey("Teacher")]
        public int? TeacherID { set; get; }
        public School School { set; get; }
        [ForeignKey("School")]
        public int? FromSchoolID { set; get; }
        public School School1 { set; get; }
        [ForeignKey("School1")]
        public int? ToSchoolID { set; get; }
        public DateTime Date { set; get; } = DateTime.Now;

    }
}
