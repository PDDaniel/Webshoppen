﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webshoppen.Models
{
    public class Member
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Admin { get; set; }
    }
}