using ITIProject.Organization.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIProject.Organization.ViewModels
{
    public static class SchoolExtensions
    {

        public static SchoolViewModel ToViewModel(this School model)
        {
            return new SchoolViewModel()
            {
                ID = model.ID,
                Name = model.Name,
                Address = model.Address,
                OpenDate = model.OpenDate,

            };
        }
        public static School ToModel(this SchoolEditViewModel editModel)
        {
            return new School
            {
                ID = editModel.ID,
                Name = editModel.Name,
                Address = editModel.Address,
                OpenDate = editModel.OpenDate,

            };
        }

        public static SchoolEditViewModel ToEditableViewModel(this School model)
        {
            return new SchoolEditViewModel
            {
                ID = model.ID,
                Name = model.Name,
                Address = model.Address,
                OpenDate = model.OpenDate,

            };
        }
    }
}
