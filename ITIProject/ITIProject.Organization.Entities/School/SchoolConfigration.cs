using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIProject.Organization.Entities
{
  public class SchoolConfigration : EntityTypeConfiguration<School>
    {


        public SchoolConfigration()
        {
            ToTable("School");
            Property(i => i.Name)
                .HasColumnName("Name")
                .HasMaxLength(500)
                .IsRequired();
            Property(i => i.Address)
               .HasColumnName("Address")
               .HasMaxLength(500)
               .IsRequired();
            Property(i => i.OpenDate)
               .HasColumnName("OpenDate")
               .IsRequired();
            HasMany(i => i.Students)
                .WithRequired(i => i.School)
                .HasForeignKey(i => i.SchoolID);
        }
    }
}
