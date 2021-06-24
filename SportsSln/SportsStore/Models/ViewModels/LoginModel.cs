﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models.ViewModels
{
    public class LoginModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string ReturnUrl { get; set; } = "/";
    }
}
