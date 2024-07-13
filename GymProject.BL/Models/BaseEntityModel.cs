using GymProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymProject.BL.Models
{
    public abstract class BaseEntityModel<T> : IBaseEntityModel<T> where T : BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public Guid? UpdatedBy { get; set; }

        public abstract T ToEntity();


    }
}
