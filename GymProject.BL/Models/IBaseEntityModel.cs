using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymProject.BL.Models
{
    public interface IBaseEntityModel<T>
    {
        public T  ToEntity();
    }
}
