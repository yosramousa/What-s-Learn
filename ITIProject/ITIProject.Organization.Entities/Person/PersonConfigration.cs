using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIProject.Organization.Entities
{
    public class PersonConfigration : EntityTypeConfiguration<Person>
    {
        public PersonConfigration()
        {
            ToTable("Person");
            Property(i => i.Name)
                .HasColumnName("Name")
                .HasMaxLength(500)
                .IsRequired();
            Property(i => i.Address)
                   .HasColumnName("Address")
                   .HasMaxLength(500)
                   .IsRequired();
            Property(i => i.Phone)
               .HasColumnName("Phone")
               .HasMaxLength(20)
               .IsRequired();
            HasOptional(i => i.Student)
                .WithRequired(i => i.Person);
        }
    }
}