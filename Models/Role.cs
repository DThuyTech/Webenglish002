﻿using System.ComponentModel.DataAnnotations;

namespace Webenglishfinal.Models
{
    public class Role
    {
        [Key]
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
