﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JakeRenzo.Calander.Web.Areas.Manage.ViewModels
{
    public class CreateViewModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime PostExpiry { get; set; }

        [Required]
        public DateTime EventStart { get; set; }

        [Required]
        public DateTime EventEnd { get; set; }
    }
}