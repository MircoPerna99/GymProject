#nullable disable
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymProject.DAL.Entities
{
    public class User : IdentityUser<Guid>
    {
        public bool IsActived { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid? UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public UserDetails Details { get; set; }

    }
}
