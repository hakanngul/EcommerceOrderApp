﻿using System.ComponentModel.DataAnnotations;

namespace UdemySiparis.Models
{
    public class CategoryModel
    {
        [Key] public int Id { get; set; }
        [Required] public string Name { get; set; }
    }
}