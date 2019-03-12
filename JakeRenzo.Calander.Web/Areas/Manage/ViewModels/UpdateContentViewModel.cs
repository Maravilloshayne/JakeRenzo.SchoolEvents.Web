using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JakeRenzo.Calander.Web.Areas.Manage.ViewModels
{
    public class UpdateContentViewModel
    {
        public Guid? SchoolEventId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}