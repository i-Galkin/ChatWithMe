﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatWithMe.Web.Models.Auth
{
    public class SignUpModel 
    {
        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}