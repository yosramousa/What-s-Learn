using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIProject.Organization.Entities
{
    public class BaseModelConfigration : EntityTypeConfiguration<BaseModel>
    {
        public BaseModelConfigration()
        {
            HasKey(i => i.ID);
            Property(i => i.ID)
                .HasDatabaseGeneratedOption
                (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }
}
