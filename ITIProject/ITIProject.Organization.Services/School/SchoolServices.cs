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
    public class SchoolService
    {
        UnitOfWork unitOfWork;
        GenericRepository<School> SchoolRepo;
        public SchoolService(UnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            SchoolRepo = unitOfWork.SchoolRepo;
        }
        public SchoolEditViewModel Add(SchoolEditViewModel P)
        {
            School PP = SchoolRepo.Add(P.ToModel());
            unitOfWork.Submit();
            return PP.ToEditableViewModel();
        }
        public SchoolEditViewModel Update(SchoolEditViewModel P)
        {
            School PP = SchoolRepo.Update(P.ToModel());
            unitOfWork.Submit();
            return PP.ToEditableViewModel();
        }
        public SchoolViewModel GetByID(int id)
        {
            return SchoolRepo.GetByID(id)?.ToViewModel();
        }
        //public IEnumerable<SchoolViewModel> Get(int id, string name,string phone, int pageIndex ,int pageSize = 20)
        //{

        //    var query =
        //       SchoolRepo.GetAll();
        //    query = query.Skip(pageIndex * pageSize).Take(pageSize);
        //    return query.ToList().Select(i => i.ToViewModel());
        //    //var query =
        //    //   SchoolRepo.Get
        //    //        (i => i.ID == id || i.Name == name || i.Address == address);
        //    //query = query.Skip(pageIndex * pageSize).Take(pageSize);
        //    //return query.ToList().Select(i => i.ToViewModel());
        //}

        public void Remove(int id)
        {
            SchoolRepo.Remove(SchoolRepo.GetByID(id));
            unitOfWork.Submit();
        }
    }
}
