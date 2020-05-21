using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelD4.Entities
{
    [Table("Department", Schema = "dbo")]
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int ID { set; get; }
        [Required]
        [MaxLength(250)]
        public virtual string Name { set; get; }
        public virtual  ICollection<School> School { set; get; }
    }
}
