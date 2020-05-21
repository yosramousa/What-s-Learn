using ITIProject.Organization.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIProject.Organization.ViewModels
{
  public static class PersonExtensions
    {
        public static PersonViewModel ToViewModel(this Person model)
        {
            return new PersonViewModel()
            {
                ID = model.ID,
                Name = model.Name,
                Address = model.Address,
                Phone = model.Phone
            };
        }
        public static Person ToModel(this PersonEditViewModel editModel)
        {
            return new Person()
            {
                ID = editModel.ID,
                Name = editModel.Name,
                Address = editModel.Address,
                Phone = editModel.Phone
            };
        }
        public static PersonEditViewModel ToEditableViewModel(this Person model)
        {
            return new PersonEditViewModel
            {
                ID = model.ID,
                Name = model.Name,
                Address = model.Address,
                Phone = model.Phone
            };
        }
    }
}
