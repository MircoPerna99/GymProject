#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymProject.DAL.Entities
{
    public class UserDetails : BaseEntity
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public double Height { get; set; }
        public double Weight{ get; set; }
        public virtual User UserOwner { get; set; }
    }
}
