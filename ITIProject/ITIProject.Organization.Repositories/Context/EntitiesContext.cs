using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITIProject.Organization.Repositories;
using ITIProject.Organization.Entities;

namespace ITIProject.Organization.Repositories
{
    public class EntitiesContext : DbContext
    {
        public EntitiesContext() : base("Company")
        { }

        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add
                (new PersonConfigration());
            modelBuilder.Configurations.Add
               (new StudentConfigration());
            modelBuilder.Configurations.Add
               (new SchoolConfigration());
        }
    }
}
