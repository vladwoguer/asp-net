﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapi.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public int role { get; set; }
    }
}