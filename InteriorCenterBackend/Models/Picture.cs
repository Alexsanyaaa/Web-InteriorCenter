// Models/Product.cs
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace InteriorCenterBackend.Models
{
    public class Picture
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string ImageUrL { get; set; } = string.Empty;
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}