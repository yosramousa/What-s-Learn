using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelD4.Entities
{
    public class EntitiesContext : DbContext
    {
        public EntitiesContext() : base( "name= LuxorDB")

        { }
        public virtual DbSet<Teacher> Teachers { set; get; }
        public virtual DbSet<TeacherTransfer> TeacherTransfers { set; get; }
        public virtual DbSet<Department> Department { set; get; }
        public virtual DbSet<School> School { set; get; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {


            modelBuilder
                .Conventions
                .Remove<OneToManyCascadeDeleteConvention>();
        }

        public EntitiesContext(DbSet<Teacher> teachers, DbSet<TeacherTransfer> teacherTransfers, DbSet<Department> department, DbSet<School> school)
        {
            Teachers = teachers;
            TeacherTransfers = teacherTransfers;
            Department = department;
            School = school;
        }
    }
}
