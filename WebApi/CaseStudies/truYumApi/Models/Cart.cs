﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace truYumApi.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int MenuItemId { get; set; }
        public int UserId { get; set; }

    }
}
