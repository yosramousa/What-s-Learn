using ITIProject.Organization.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIProject.Organization.ViewModels
{
    public static class StudentExtensions
    {

        public static StudentViewModel ToViewModel(this Student model)
        {
            return new StudentViewModel()
            {
                ID = model.ID,
                Name = model.Person?.Name,
                Address = model.Person?.Address,
                HireDate = model.HireDate,
                Phone = model.Person?.Phone,
                SchoolName = model.School?.Name
            };
        }
        public static Student ToModel(this StudentEditViewModel editModel)
        {
            return new Student
            {
                ID = editModel.ID,
                Person = new Person
                {
                    ID = editModel.ID,
                    Name = editModel.Name,
                    Phone = editModel.Phone,
                     Address = editModel.Address,
                },
              
                HireDate = editModel.HireDate,
                SchoolID = editModel.SchoolID
            };
        }

        public static StudentEditViewModel ToEditableViewModel(this Student model)
        {
            return new StudentEditViewModel
            {
                ID = model.ID,
                Name = model.Person?.Name,
                Address = model.Person?.Address,
                Phone = model.Person?.Phone,
                HireDate = model.HireDate,
                SchoolID = model.SchoolID
            };
        }
    }
}
