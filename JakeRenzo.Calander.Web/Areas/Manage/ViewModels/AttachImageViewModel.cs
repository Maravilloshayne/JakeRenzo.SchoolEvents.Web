using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JakeRenzo.Calander.Web.Areas.Manage.ViewModels
{
    public class AttachImageViewModel
    {
        public Guid? SchoolEventId { get; set; }
        public IFormFile Image { get; set; }
    }
}
