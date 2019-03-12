using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JakeRenzo.Calander.Web.Infrastructures.Enums
{
    public enum LoginStatus
    {
        Locked = 0,
        Active = 1,
        NeedsToChangePassword = 2,
        NewRegister = 3
    }
}
