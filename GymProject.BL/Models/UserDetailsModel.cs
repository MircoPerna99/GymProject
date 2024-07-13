using GymProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymProject.BL.Models
{
    public class UserDetailsModel : BaseEntityModel<UserDetails>
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public override UserDetails ToEntity()
        {
            UserDetails entity = new UserDetails();
            entity.Id = Id;
            entity.CreatedBy = CreatedBy;
            entity.CreatedOn = CreatedOn;
            entity.UpdatedBy = UpdatedBy;
            entity.UpdatedOn = UpdatedOn;
            entity.UserId = UserId;
            entity.FirstName = FirstName;
            entity.LastName = LastName;
            entity.Birth = Birth;
            entity.Height = Height;
            entity.Weight = Weight;
            return entity;
        }
    }
}
