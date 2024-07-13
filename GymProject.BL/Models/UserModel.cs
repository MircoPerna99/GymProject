#nullable disable
using GymProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymProject.BL.Models
{
    public class UserModel : IBaseEntityModel<User>
    {
        public bool IsActived { get; set; }
        public UserDetailsModel Details { get; set; }

        public User ToEntity()
        {
            return null;
        }

    }
}
