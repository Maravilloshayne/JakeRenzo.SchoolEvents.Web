using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JakeRenzo.Calander.Web.ViewModels.SchoolEvent
{
    public class SchoolEventViewModel
    {
        public Guid? SchoolEventId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Description { get; set; }

        public string TemplateName { get; set; }

        public bool IsPublished { get; set; }

        public DateTime PostExpiry { get; set; }

        public DateTime EventStart { get; set; }

        public DateTime EventEnd { get; set; }


    }
}