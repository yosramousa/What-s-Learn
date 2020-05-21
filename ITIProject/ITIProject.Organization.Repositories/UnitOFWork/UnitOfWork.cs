using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITIProject.Organization.Entities;
using ITIProject.Organization.Repositories;


namespace ITIProject.Organization.Repositories
{
    public class UnitOfWork
    {
        private EntitiesContext context;
       
        public GenericRepository<Person> PersonRepo { get; set; }
        public GenericRepository<Student> StudentRepo { get; set; }
        public GenericRepository<School> SchoolRepo { get; set; }

        public UnitOfWork(
            EntitiesContext _context,
            GenericRepository<Person> personRepo,
            GenericRepository<Student> studentRepo,
            GenericRepository<School> schoolRepo
            )
        {
            context = _context;
            PersonRepo = personRepo;
            PersonRepo.Context = this.context;
            SchoolRepo = schoolRepo;
            SchoolRepo.Context = this.context;
            StudentRepo = studentRepo;
            StudentRepo.Context = this.context;
        }


        public int Submit()
        {
            return context.SaveChanges();

        }

    }
}