﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApp.Models
{
    public class RestaurantEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public long PhoneNo { get; set; }
        public string EmailAddress { get; set; }
    }
}