using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ShopBridge.Models
{
    public partial class Admin
    {
        public int AdminId { get; set; }
        [Required]
        public string AdminName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ContactNo { get; set; }
    }
}
