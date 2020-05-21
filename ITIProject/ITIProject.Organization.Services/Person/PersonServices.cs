
using ITIProject.Organization.Entities;
using ITIProject.Organization.ViewModels;
using ITIProject.Organization.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ITIProject.Organization.Services
{
    public class PersonService
    {

        UnitOfWork unitOfWork;
        GenericRepository<Person> personRepo;
        public PersonService(UnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            personRepo = unitOfWork.PersonRepo;
        }
        public PersonEditViewModel Add(PersonEditViewModel P)
        {
            Person PP = personRepo.Add(P.ToModel());
            unitOfWork.Submit();
            return PP.ToEditableViewModel();
        }
        public PersonEditViewModel Update(PersonEditViewModel P)
        {
            Person PP = personRepo.Update(P.ToModel());
            unitOfWork.Submit();
            return PP.ToEditableViewModel();
        }
        public PersonViewModel GetByID(int id)
        {
            return personRepo.GetByID(id)?.ToViewModel();
        }
        public IEnumerable<PersonViewModel> GetData(int id, string name, string phone, string address, int pageIndex, int pageSize = 20)
        {
            var query =
                personRepo.Get
                    (i => i.ID == id || i.Name == name || i.Phone == phone || i.Address == address);
            query = query.Skip(pageIndex * pageSize).Take(pageSize);
            return query.ToList().Select(i => i.ToViewModel());
        }
        public void Remove(int id)
        {
            personRepo.Remove(personRepo.GetByID(id));
            unitOfWork.Submit();
        }
    }
}
