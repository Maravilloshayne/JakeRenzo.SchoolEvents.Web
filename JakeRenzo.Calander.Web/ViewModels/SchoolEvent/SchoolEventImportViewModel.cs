using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JakeRenzo.Calander.Web.ViewModels.SchoolEvent
{
    public class SchoolEventImportViewModel
    {
        public string Id { get; set; }


        public string Title { get; set; }

        public string Content { get; set; }

        public string Description { get; set; }

        public DateTime EventStart { get; set; }

        public DateTime EventEnd { get; set; }

    }
}