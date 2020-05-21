using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIProject.Organization.Entities
{
    public class StudentConfigration : EntityTypeConfiguration<Student>
    {
        public StudentConfigration()
        {
            ToTable("Student");
            HasKey(i => i.ID);
            Property(i => i.ID).
                HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            HasRequired(i => i.Person)
                .WithMany()
                .HasForeignKey(i => i.ID);

            HasRequired(i => i.School)
                .WithMany(i => i.Students)
                .HasForeignKey(i => i.SchoolID);
        }
    }
}
