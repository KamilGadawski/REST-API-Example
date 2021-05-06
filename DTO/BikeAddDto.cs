using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBikeService.DTO
{
    public class BikeAddDto
    {
        [Required]
        public string Brand { get; set; }

        [Required]
        public string Model { get; set; }
        
        [Required]
        [Range(46, 64)]
        public int Size { get; set; }
        
        [Required]
        [Range(1, float.MaxValue, ErrorMessage = "Price must by greater than 1")]
        public float Price { get; set; }
    }
}
