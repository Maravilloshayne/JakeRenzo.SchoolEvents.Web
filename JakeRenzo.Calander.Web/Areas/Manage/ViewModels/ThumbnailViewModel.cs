﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JakeRenzo.Calander.Web.Areas.Manage.ViewModels
{
    public class ThumbnailViewModel
    {
        public Guid? SchoolEventId { get; set; }
        public IFormFile Thumbnail { get; set; }
    }
}