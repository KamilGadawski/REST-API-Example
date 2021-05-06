using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBikeService.Models
{
    public class BikeModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Brand { get; set; }

        [Required]
        [MaxLength(50)]
        public string Model { get; set; }

        [Required]
        [MaxLength(4)]
        public int Size { get; set; }

        [Required]
        [MaxLength(12)]
        public float Price { get; set; }
    }
}
