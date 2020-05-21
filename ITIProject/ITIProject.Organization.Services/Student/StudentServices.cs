using ITIProject.Organization.Entities;
using ITIProject.Organization.Repositories;
using ITIProject.Organization.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIProject.Organization.Services
{
    public class StudentService
    {

        UnitOfWork unitOfWork;
        GenericRepository<Student> StudentRepo;
        public StudentService(UnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            StudentRepo = unitOfWork.StudentRepo;
        }
        public StudentEditViewModel Add(StudentEditViewModel P)
        {
            Student PP = StudentRepo.Add(P.ToModel());
            unitOfWork.Submit();
            return PP.ToEditableViewModel();
        }
        public StudentEditViewModel Update(StudentEditViewModel P)
        {

            Student PP = StudentRepo.Update(P.ToModel());
            unitOfWork.Submit();
            return PP.ToEditableViewModel();
        }
        public StudentViewModel GetByID(int id)
        {
            return StudentRepo.GetByID(id)?.ToViewModel();
        }
        public IEnumerable<StudentViewModel> Get(int id, string name, string phone, string address, int pageIndex, int pageSize = 20)
        {
            var query =
               StudentRepo.Get
                      (i => i.ID == id || i.Person.Name == name || i.Person.Phone == phone || i.Person.Address == address);
            query = query.Skip(pageIndex * pageSize).Take(pageSize);
            return query.ToList().Select(i => i.ToViewModel());
        }
        public void Remove(int id)
        {
            StudentRepo.Remove(StudentRepo.GetByID(id));
            unitOfWork.Submit();
        }
    }
}
