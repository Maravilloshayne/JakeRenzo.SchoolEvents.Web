using JakeRenzo.Calander.Web.Infrastructures.Enums;
using JakeRenzo.Calander.Web.Infrastructures.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JakeRenzo.Calander.Web.Infrastructures.Models
{
    public class UserRole : BaseModel
    {
        public Guid? UserId { get; set; }

        public Role Role { get; set; }
    }
}