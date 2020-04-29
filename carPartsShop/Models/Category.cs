﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace carPartsShop.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

#nullable disable

        public ICollection<Product> Products { get; set; }

    }
}
