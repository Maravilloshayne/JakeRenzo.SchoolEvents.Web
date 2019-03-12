using JakeRenzo.Calander.Web.Infrastructures.Enums;
using JakeRenzo.Calander.Web.Infrastructures.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JakeRenzo.Calander.Web.Infrastructures.Models
{
    public class User : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public LoginStatus LoginStatus { get; set; }
        public string RegistrationCode { get; set; }
        public int LoginTrials { get; set; }
    }
}