﻿using System.ComponentModel.DataAnnotations;

namespace JMMerloModelado.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }
    }
}
