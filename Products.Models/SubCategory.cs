﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Models
{
    internal class SubCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public int categoryId { get; set; }
        public Category category { get; set; }
   
            
    }
}
