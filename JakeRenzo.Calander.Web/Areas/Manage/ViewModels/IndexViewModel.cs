﻿using JakeRenzo.Calander.Web.Infrastructures.Helpers;
using JakeRenzo.Calander.Web.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JakeRenzo.Calander.Web.Areas.Manage.ViewModels
{
    public class IndexViewModel
    {
        public Page<SchoolEvent> SchoolEvents { get; set; }
    }
}