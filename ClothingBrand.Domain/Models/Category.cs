﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingBrand.Domain.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string? Description { get; set; }


        // Navigation property
        public virtual ICollection<Product>? Products { get; set; }
    }

}